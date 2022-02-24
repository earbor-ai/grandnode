using Grand.Business.Catalog.Interfaces.Products;
using Grand.Business.Catalog.Queries.Handlers;
using Grand.Domain;
using Grand.Domain.Catalog;
using Grand.Domain.Customers;
using Grand.Infrastructure.Caching;
using Grand.Web.Events.Cache;
using Grand.Web.Extensions;
using Grand.Web.Features.Models.Catalog;
using Grand.Web.Features.Models.Products;
using Grand.Web.Models.Catalog;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Grand.Business.Catalog.Interfaces.Discounts;

namespace Grand.Web.Features.Handlers.Catalog
{
    public class GetCollectionHandler : IRequestHandler<GetCollection, CollectionModel>
    {
        private readonly IMediator _mediator;
        private readonly ICacheBase _cacheBase;
        private readonly ISpecificationAttributeService _specificationAttributeService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IDiscountService _discountService; //CSD

        private readonly CatalogSettings _catalogSettings;

        public GetCollectionHandler(
            IMediator mediator,
            ICacheBase cacheBase,
            ISpecificationAttributeService specificationAttributeService,
            IHttpContextAccessor httpContextAccessor,
            IDiscountService discountService,
            CatalogSettings catalogSettings)
        {
            _mediator = mediator;
            _cacheBase = cacheBase;
            _discountService = discountService;
            _specificationAttributeService = specificationAttributeService;
            _httpContextAccessor = httpContextAccessor;
            _catalogSettings = catalogSettings;
        }

        public async Task<CollectionModel> Handle(GetCollection request, CancellationToken cancellationToken)
        {
            var model = request.Collection.ToModel(request.Language);

            if (request.Command != null && request.Command.OrderBy == null && request.Collection.DefaultSort >= 0)
                request.Command.OrderBy = request.Collection.DefaultSort;
            
            //view/sorting/page size
            var options = await _mediator.Send(new GetViewSortSizeOptions() {
                Command = request.Command,
                PagingFilteringModel = request.Command,
                Language = request.Language,
                AllowCustomersToSelectPageSize = request.Collection.AllowCustomersToSelectPageSize,
                PageSizeOptions = request.Collection.PageSizeOptions,
                PageSize = request.Collection.PageSize
            });
            model.PagingFilteringContext = options.command;

            //featured products
            if (!_catalogSettings.IgnoreFeaturedProducts)
            {
                IPagedList<Product> featuredProducts = null;

                //We cache a value indicating whether we have featured products
                string cacheKey = string.Format(CacheKeyConst.COLLECTION_HAS_FEATURED_PRODUCTS_KEY,
                    request.Collection.Id,
                    string.Join(",", request.Customer.GetCustomerGroupIds()),
                    request.Store.Id);
                var hasFeaturedProductsCache = await _cacheBase.GetAsync<bool?>(cacheKey, async () =>
                {
                    var featuredProducts = (await _mediator.Send(new GetSearchProductsQuery() {
                        PageSize = _catalogSettings.LimitOfFeaturedProducts,
                        CollectionId = request.Collection.Id,
                        Customer = request.Customer,
                        StoreId = request.Store.Id,
                        VisibleIndividuallyOnly = true,
                        FeaturedProducts = true
                    })).products;
                    return featuredProducts.Any();
                });
                if (hasFeaturedProductsCache.Value && featuredProducts == null)
                {
                    //cache indicates that the collection has featured products
                    featuredProducts = (await _mediator.Send(new GetSearchProductsQuery() {
                        PageSize = _catalogSettings.LimitOfFeaturedProducts,
                        CollectionId = request.Collection.Id,
                        Customer = request.Customer,
                        StoreId = request.Store.Id,
                        VisibleIndividuallyOnly = true,
                        FeaturedProducts = true
                    })).products;
                }
                if (featuredProducts != null && featuredProducts.Any())
                {
                    model.FeaturedProducts = (await _mediator.Send(new GetProductOverview() {
                        Products = featuredProducts,
                    })).ToList();
                }
            }

            IList<string> alreadyFilteredSpecOptionIds = await model.PagingFilteringContext.SpecificationFilter.GetAlreadyFilteredSpecOptionIds
                (_httpContextAccessor.HttpContext.Request.Query, _specificationAttributeService);

            //CSD
            var products = (await _mediator.Send(new GetSearchProductsQuery() {
                LoadFilterableSpecificationAttributeOptionIds = !_catalogSettings.IgnoreFilterableSpecAttributeOption,
                CollectionId = request.Collection.Id,
                Customer = request.Customer,
                StoreId = request.Store.Id,
                VisibleIndividuallyOnly = true,
                FeaturedProducts = _catalogSettings.IncludeFeaturedProductsInNormalLists ? null : (bool?)false,
                FilteredSpecs = alreadyFilteredSpecOptionIds,
                OrderBy = (ProductSortingEnum)request.Command.OrderBy,
                PageIndex = request.Command.PageNumber - 1,
                PageSize = request.Command.PageSize
            }));

            model.Products = (await _mediator.Send(new GetProductOverview() {
                Products = products.products,
                PrepareSpecificationAttributes = _catalogSettings.ShowSpecAttributeOnCatalogPages
            })).ToList();

            model.PagingFilteringContext.LoadPagedList(products.products);

            //specs
            await model.PagingFilteringContext.SpecificationFilter.PrepareSpecsFilters(alreadyFilteredSpecOptionIds,
                products.filterableSpecificationAttributeOptionIds,
                _specificationAttributeService, _httpContextAccessor.HttpContext.Request.GetDisplayUrl(), request.Language.Id);

            //CSD
            var discount = await _discountService.GetDiscountById("61a75cb00c27b17cf306bbc1");

            model.AppliedDiscountDetails = new List<CollectionDiscountModel>();
            model.AppliedDiscountDetails.Add(new CollectionDiscountModel());
            model.AppliedDiscountDetails[0].DiscountId= discount.Id;
            model.AppliedDiscountDetails[0].Name = discount.Name;
            model.AppliedDiscountDetails[0].StartDateUtc = (System.DateTime)discount.StartDateUtc;
            model.AppliedDiscountDetails[0].EndDateUtc = (System.DateTime)discount.EndDateUtc;


            return model;
        }

        /*public async Task<IActionResult> ProductAddPopup(DiscountModel.AddProductToDiscountModel model)
        {
            var discount = await _discountService.GetDiscountById(model.DiscountId);
            if (discount == null)
                throw new Exception("No discount found with the specified id");

            if (model.SelectedProductIds != null)
            {
                await _discountViewModelService.InsertProductToDiscountModel(model);
            }
            return Content("");
        }*/
    }
}
