#pragma checksum "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\ProductTags\_CreateOrUpdate.TabProducts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2b268acf7188f4ea7c88fd193227b3f805a6f6f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ProductTags__CreateOrUpdate_TabProducts), @"mvc.1.0.view", @"/Areas/Admin/Views/ProductTags/_CreateOrUpdate.TabProducts.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
#nullable restore
#line 6 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.ViewFeatures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\_ViewImports.cshtml"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\_ViewImports.cshtml"
using Grand.SharedKernel.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\_ViewImports.cshtml"
using Grand.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\_ViewImports.cshtml"
using Grand.Domain.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\_ViewImports.cshtml"
using Grand.Domain.Catalog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\_ViewImports.cshtml"
using Grand.Domain.Directory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\_ViewImports.cshtml"
using Grand.Domain.Documents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\_ViewImports.cshtml"
using Grand.Domain.Orders;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\_ViewImports.cshtml"
using Grand.Infrastructure.TypeConverters;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\_ViewImports.cshtml"
using Grand.Business.Cms.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\_ViewImports.cshtml"
using Grand.Web.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\_ViewImports.cshtml"
using Grand.Web.Common.Events;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\_ViewImports.cshtml"
using Grand.Web.Common.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\_ViewImports.cshtml"
using Grand.Web.Common.Security.Captcha;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\_ViewImports.cshtml"
using Grand.Web.Common.Themes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\_ViewImports.cshtml"
using Grand.Web.Common.Page;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\_ViewImports.cshtml"
using Grand.Web.Common.Link;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\_ViewImports.cshtml"
using Grand.Web.Admin.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\_ViewImports.cshtml"
using Grand.Web.Admin.Models.Affiliates;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\_ViewImports.cshtml"
using Grand.Web.Admin.Models.Blogs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\_ViewImports.cshtml"
using Grand.Web.Admin.Models.Catalog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\_ViewImports.cshtml"
using Grand.Web.Admin.Models.Cms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\_ViewImports.cshtml"
using Grand.Web.Admin.Models.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\_ViewImports.cshtml"
using Grand.Web.Admin.Models.Courses;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\_ViewImports.cshtml"
using Grand.Web.Admin.Models.Country;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\_ViewImports.cshtml"
using Grand.Web.Admin.Models.Customers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\_ViewImports.cshtml"
using Grand.Web.Admin.Models.Directory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\_ViewImports.cshtml"
using Grand.Web.Admin.Models.Discounts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\_ViewImports.cshtml"
using Grand.Web.Admin.Models.Documents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\_ViewImports.cshtml"
using Grand.Web.Admin.Models.ExternalAuthentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\_ViewImports.cshtml"
using Grand.Web.Admin.Models.Home;

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\_ViewImports.cshtml"
using Grand.Web.Admin.Models.Layouts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\_ViewImports.cshtml"
using Grand.Web.Admin.Models.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\_ViewImports.cshtml"
using Grand.Web.Admin.Models.Logging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\_ViewImports.cshtml"
using Grand.Web.Admin.Models.Messages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\_ViewImports.cshtml"
using Grand.Web.Admin.Models.News;

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\_ViewImports.cshtml"
using Grand.Web.Admin.Models.Orders;

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\_ViewImports.cshtml"
using Grand.Web.Admin.Models.Payments;

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\_ViewImports.cshtml"
using Grand.Web.Admin.Models.Plugins;

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\_ViewImports.cshtml"
using Grand.Web.Admin.Models.Settings;

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\_ViewImports.cshtml"
using Grand.Web.Admin.Models.Shipping;

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\_ViewImports.cshtml"
using Grand.Web.Admin.Models.ShoppingCart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\_ViewImports.cshtml"
using Grand.Web.Admin.Models.Stores;

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\_ViewImports.cshtml"
using Grand.Web.Admin.Models.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\_ViewImports.cshtml"
using Grand.Web.Admin.Models.Tax;

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\_ViewImports.cshtml"
using Grand.Web.Admin.Models.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\_ViewImports.cshtml"
using Grand.Web.Admin.Models.Vendors;

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\_ViewImports.cshtml"
using Grand.Web.Admin.Models.Knowledgebase;

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\_ViewImports.cshtml"
using Grand.Web.Admin.Models.Permissions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2b268acf7188f4ea7c88fd193227b3f805a6f6f", @"/Areas/Admin/Views/ProductTags/_CreateOrUpdate.TabProducts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b5aef36527620dc7872a6461ea7946585dc22b9", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_ProductTags__CreateOrUpdate_TabProducts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductTagModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""panel panel-default"">
    <div class=""panel-body"">
        <div id=""product-tags-grid""></div>
    </div>
</div>
<script>
        $(document).ready(function () {
            $(""#product-tags-grid"").kendoGrid({
                dataSource: {
                    transport: {
                        read: {
                            url: """);
#nullable restore
#line 14 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\ProductTags\_CreateOrUpdate.TabProducts.cshtml"
                             Write(Html.Raw(Url.Action("Products", "ProductTags", new { tagId = Model.Id, area = Constants.AreaAdmin })));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
                            type: ""POST"",
                            dataType: ""json"",
                            data: addAntiForgeryToken
                        }
                    },
                    schema: {
                        data: ""Data"",
                        total: ""Total"",
                        errors: ""Errors"",
                        model: {
                            id: ""Id"",
                            fields: {
                                Name: { editable: true, type: ""string"" },
                                Id: { editable: false, type: ""string"" }
                            }
                        }
                    },
                    requestEnd: function (e) {
                        if (e.type == ""create"" || e.type == ""update"") {
                            this.read();
                        }
                    },
                    error: function (e) {
                        display_kendoui_grid_error(e);
               ");
            WriteLiteral("         // Cancel the changes\r\n                        this.cancelChanges();\r\n                    },\r\n                    pageSize: ");
#nullable restore
#line 42 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\ProductTags\_CreateOrUpdate.TabProducts.cshtml"
                          Write(adminAreaSettings.DefaultGridPageSize);

#line default
#line hidden
#nullable disable
            WriteLiteral(",\r\n                    serverPaging: true,\r\n                    serverFiltering: true,\r\n                    serverSorting: true\r\n                },\r\n                pageable: {\r\n                    refresh: true,\r\n                    pageSizes: [");
#nullable restore
#line 49 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\ProductTags\_CreateOrUpdate.TabProducts.cshtml"
                            Write(adminAreaSettings.GridPageSizes);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"]
                },
                editable: {
                    confirmation: true,
                    mode: ""inline""
                },
                scrollable: false,
                columns: [{
                    field: ""Name"",
                    title: """);
#nullable restore
#line 58 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\ProductTags\_CreateOrUpdate.TabProducts.cshtml"
                       Write(Loc["Admin.Catalog.ProductTags.Fields.ProductName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\r\n                    width: 300,\r\n                    template: \'<a class=\"k-link\" href=\"");
#nullable restore
#line 60 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\ProductTags\_CreateOrUpdate.TabProducts.cshtml"
                                                  Write(Url.Action("Edit", "Product", new { area = Constants.AreaAdmin }));

#line default
#line hidden
#nullable disable
            WriteLiteral("/#=Id#\">#=kendo.htmlEncode(Name)#</a>\',\r\n                }]\r\n            });\r\n        });\r\n</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public AdminAreaSettings adminAreaSettings { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Grand.Web.Common.Localization.LocService Loc { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductTagModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
