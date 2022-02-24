using Grand.Business.Catalog.Utilities;
using Grand.Infrastructure.Models;
using Grand.Web.Models.Media;
using System;
using System.Collections.Generic;

namespace Grand.Web.Models.Catalog
{
    public partial class CollectionModel : BaseEntityModel
    {
        public CollectionModel()
        {
            PictureModel = new PictureModel();
            FeaturedProducts = new List<ProductOverviewModel>();
            Products = new List<ProductOverviewModel>();            
            PagingFilteringContext = new CatalogPagingFilteringModel();
            AppliedDiscountDetails = new List<CollectionDiscountModel>(); //CSD
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public string BottomDescription { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescription { get; set; }
        public string MetaTitle { get; set; }
        public string SeName { get; set; }
        public string Icon { get; set; }

        public IList<CollectionDiscountModel> AppliedDiscountDetails { get; set; } //CSD
        public PictureModel PictureModel { get; set; }
        public CatalogPagingFilteringModel PagingFilteringContext { get; set; }
        public IList<ProductOverviewModel> FeaturedProducts { get; set; }
        public IList<ProductOverviewModel> Products { get; set; }       
    }
}