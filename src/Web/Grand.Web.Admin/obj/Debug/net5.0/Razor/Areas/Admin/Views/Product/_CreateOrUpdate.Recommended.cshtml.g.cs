#pragma checksum "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\Product\_CreateOrUpdate.Recommended.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0fa763ff4154ddcbc122bcecb17ce90b5aad2bda"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Product__CreateOrUpdate_Recommended), @"mvc.1.0.view", @"/Areas/Admin/Views/Product/_CreateOrUpdate.Recommended.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0fa763ff4154ddcbc122bcecb17ce90b5aad2bda", @"/Areas/Admin/Views/Product/_CreateOrUpdate.Recommended.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b5aef36527620dc7872a6461ea7946585dc22b9", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Product__CreateOrUpdate_Recommended : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductModel>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::AspNetCore.Areas_Admin_Views_Product__CreateOrUpdate_Recommended.__Generated__AdminWidgetViewComponentTagHelper __AdminWidgetViewComponentTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\Product\_CreateOrUpdate.Recommended.cshtml"
 if (!String.IsNullOrEmpty(Model.Id))
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"panel panel-default\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:admin-widget", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0fa763ff4154ddcbc122bcecb17ce90b5aad2bda15048", async() => {
            }
            );
            __AdminWidgetViewComponentTagHelper = CreateTagHelper<global::AspNetCore.Areas_Admin_Views_Product__CreateOrUpdate_Recommended.__Generated__AdminWidgetViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__AdminWidgetViewComponentTagHelper);
            BeginWriteTagHelperAttribute();
            WriteLiteral("product_details_recommended_top");
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __AdminWidgetViewComponentTagHelper.widgetZone = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("widget-zone", __AdminWidgetViewComponentTagHelper.widgetZone, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 7 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\Product\_CreateOrUpdate.Recommended.cshtml"
__AdminWidgetViewComponentTagHelper.additionalData = Model;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("additional-data", __AdminWidgetViewComponentTagHelper.additionalData, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <div class=\"panel-heading\">\r\n            ");
#nullable restore
#line 9 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\Product\_CreateOrUpdate.Recommended.cshtml"
       Write(Loc["Admin.Catalog.Products.Recommended"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"panel-body\">\r\n            <div id=\"recommendedproducts-grid\"></div>\r\n        </div>\r\n        <div class=\"panel-footer\">\r\n            <a id=\"btnAddNewRecommendedProduct\"");
            BeginWriteAttribute("href", " href=\"", 502, "\"", 687, 1);
#nullable restore
#line 15 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\Product\_CreateOrUpdate.Recommended.cshtml"
WriteAttributeValue("", 509, Url.Action("RecommendedProductAddPopup", "Product", new { productId = Model.Id, btnId = "btnRefreshRecommendedProducts", formId = "product-form", area = Constants.AreaAdmin }), 509, 178, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"k-button\"><i class=\"fa fa-plus\"></i>&nbsp;");
#nullable restore
#line 15 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\Product\_CreateOrUpdate.Recommended.cshtml"
                                                                                                                                                                                                                                                                                      Write(Loc["Admin.Catalog.Products.Recommended.AddNew"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            <input type=\"submit\" id=\"btnRefreshRecommendedProducts\" style=\"display: none\" />\r\n        </div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:admin-widget", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0fa763ff4154ddcbc122bcecb17ce90b5aad2bda18911", async() => {
            }
            );
            __AdminWidgetViewComponentTagHelper = CreateTagHelper<global::AspNetCore.Areas_Admin_Views_Product__CreateOrUpdate_Recommended.__Generated__AdminWidgetViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__AdminWidgetViewComponentTagHelper);
            BeginWriteTagHelperAttribute();
            WriteLiteral("product_details_recommended_bottom");
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __AdminWidgetViewComponentTagHelper.widgetZone = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("widget-zone", __AdminWidgetViewComponentTagHelper.widgetZone, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 18 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\Product\_CreateOrUpdate.Recommended.cshtml"
__AdminWidgetViewComponentTagHelper.additionalData = Model;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("additional-data", __AdminWidgetViewComponentTagHelper.additionalData, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral(@"    <script>
        $(document).ready(function () {
            $('#btnAddNewRecommendedProduct').magnificPopup({
                type: 'ajax',
                settings: { cache: false, async: false },
                midClick: true,
                callbacks: {
                    parseAjax: function (mfpResponse) {
                        mfpResponse.data = $('<div></div>').html(mfpResponse.data);
                    },
                    ajaxContentAdded: function () {
                        $('.mfp-wrap').removeAttr('tabindex');
                    }
                }
            });
            $(""#recommendedproducts-grid"").kendoGrid({
                dataSource: {
                    transport: {
                        read: {
                            url: """);
#nullable restore
#line 40 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\Product\_CreateOrUpdate.Recommended.cshtml"
                             Write(Html.Raw(Url.Action("RecommendedProductList", "Product", new { productId = Model.Id, area = Constants.AreaAdmin })));

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\r\n                            type: \"POST\",\r\n                            dataType: \"json\",\r\n                            data: addAntiForgeryToken\r\n                        },\r\n                        destroy: {\r\n                            url: \"");
#nullable restore
#line 46 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\Product\_CreateOrUpdate.Recommended.cshtml"
                             Write(Html.Raw(Url.Action("RecommendedProductDelete", "Product", new { productId = Model.Id, area = Constants.AreaAdmin })));

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
                                ProductId: { editable: false, type: ""string"" },
                                Product2Name: { editable: false, type: ""string"" },
                            }
                        }
                    },
                    error: function(e) {
                        display_kendoui_grid_error(e);
                        // Cancel the changes
                        this.cancelChanges();
                    },
                    serverPaging: true,
                    serverFiltering: true,
          ");
            WriteLiteral(@"          serverSorting: true
                },
                autoBind: false,
                pageable: {
                    refresh: true,
                    numeric: false,
                    previousNext: false,
                    info: false
                },
                editable: {
                    confirmation: false,
                    mode: ""inline""
                },
                scrollable: false,
                columns: [
                    {
                        field: ""Product2Name"",
                        title: """);
#nullable restore
#line 88 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\Product\_CreateOrUpdate.Recommended.cshtml"
                           Write(Loc["Admin.Catalog.Products.Recommended.Fields.Product"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\r\n                        template: \'<a class=\"k-link\" href=\"");
#nullable restore
#line 89 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\Product\_CreateOrUpdate.Recommended.cshtml"
                                                      Write(Url.Action("Edit", "Product", new { id = "", area = Constants.AreaAdmin }));

#line default
#line hidden
#nullable disable
            WriteLiteral("/#=Id#\">#=kendo.htmlEncode(Product2Name)#</a>\',\r\n                    }, {\r\n                        command: { name: \"destroy\", text: \"");
#nullable restore
#line 91 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\Product\_CreateOrUpdate.Recommended.cshtml"
                                                      Write(Loc["Admin.Common.Delete"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" },\r\n                        title: \"");
#nullable restore
#line 92 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\Product\_CreateOrUpdate.Recommended.cshtml"
                           Write(Loc["Admin.Common.Delete"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\r\n                    }\r\n                ]\r\n            });\r\n        });\r\n    </script>\r\n");
            WriteLiteral(@"    <script>
        $(document).ready(function () {
            $('#btnRefreshRecommendedProducts').click(function () {
                //refresh grid
                var grid = $(""#recommendedproducts-grid"").data('kendoGrid');
                grid.dataSource.read();

                //return false to don't reload a page
                return false;
            });
        });
    </script>
");
#nullable restore
#line 111 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\Product\_CreateOrUpdate.Recommended.cshtml"

}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"note note-info\">\r\n        ");
#nullable restore
#line 116 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\Product\_CreateOrUpdate.Recommended.cshtml"
   Write(Loc["Admin.Catalog.Products.Recommended.SaveBeforeEdit"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 118 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\Product\_CreateOrUpdate.Recommended.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductModel> Html { get; private set; }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("vc:admin-widget")]
        public class __Generated__AdminWidgetViewComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
        {
            private readonly global::Microsoft.AspNetCore.Mvc.IViewComponentHelper __helper = null;
            public __Generated__AdminWidgetViewComponentTagHelper(global::Microsoft.AspNetCore.Mvc.IViewComponentHelper helper)
            {
                __helper = helper;
            }
            [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute, global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
            public global::Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
            public System.String widgetZone { get; set; }
            public System.Object additionalData { get; set; }
            public override async global::System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext __context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput __output)
            {
                (__helper as global::Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware)?.Contextualize(ViewContext);
                var __helperContent = await __helper.InvokeAsync("AdminWidget", new { widgetZone, additionalData });
                __output.TagName = null;
                __output.Content.SetHtmlContent(__helperContent);
            }
        }
    }
}
#pragma warning restore 1591
