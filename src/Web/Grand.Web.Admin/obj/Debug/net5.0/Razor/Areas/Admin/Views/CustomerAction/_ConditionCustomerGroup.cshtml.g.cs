#pragma checksum "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\CustomerAction\_ConditionCustomerGroup.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8e0298456dacff6e6dce121dee09b9e18bddba5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_CustomerAction__ConditionCustomerGroup), @"mvc.1.0.view", @"/Areas/Admin/Views/CustomerAction/_ConditionCustomerGroup.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8e0298456dacff6e6dce121dee09b9e18bddba5", @"/Areas/Admin/Views/CustomerAction/_ConditionCustomerGroup.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b5aef36527620dc7872a6461ea7946585dc22b9", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_CustomerAction__ConditionCustomerGroup : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CustomerActionConditionModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\CustomerAction\_ConditionCustomerGroup.cshtml"
 if (String.IsNullOrEmpty(Model.Id))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"note note-info\">\r\n        ");
#nullable restore
#line 5 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\CustomerAction\_ConditionCustomerGroup.cshtml"
   Write(Loc["Admin.Customers.CustomerActionCondition.SaveBeforeEdit"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 7 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\CustomerAction\_ConditionCustomerGroup.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\CustomerAction\_ConditionCustomerGroup.cshtml"
 if (!String.IsNullOrEmpty(Model.Id))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"panel panel-default\">\r\n        <div class=\"panel-body\">\r\n            <div id=\"customergroup-grid\"></div>\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral(@"    <script>
                $(document).ready(function () {
                $(""#customergroup-grid"").kendoGrid({
                    dataSource: {
                        transport: {
                            read: {
                                url: """);
#nullable restore
#line 22 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\CustomerAction\_ConditionCustomerGroup.cshtml"
                                 Write(Html.Raw(Url.Action("ConditionCustomerGroup", "CustomerAction", new { customerActionId = Model.CustomerActionId, conditionId = Model.Id, area = Constants.AreaAdmin })));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
                                type: ""POST"",
                                dataType: ""json"",
                                data: addAntiForgeryToken
                            },
                            create: {
                                url: """);
#nullable restore
#line 28 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\CustomerAction\_ConditionCustomerGroup.cshtml"
                                 Write(Html.Raw(Url.Action("ConditionCustomerGroupInsert", "CustomerAction", new { customerActionId = Model.CustomerActionId, conditionId = Model.Id, area = Constants.AreaAdmin })));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
                                type: ""POST"",
                                dataType: ""json"",
                                data: addAntiForgeryToken
                            },
                            destroy: {
                                url: """);
#nullable restore
#line 34 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\CustomerAction\_ConditionCustomerGroup.cshtml"
                                 Write(Html.Raw(Url.Action("ConditionDeletePosition", "CustomerAction", new { customerActionId = Model.CustomerActionId, conditionId = Model.Id, area = Constants.AreaAdmin })));

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
                                    CustomerGroup: { editable: true, type: ""string"" },
                                    CustomerGroupId: { editable: true, type: ""string"" },
                                    Id: { editable: false, type: ""string"" }
                                }
                            }
                        },
                        requestEnd: function (e) {
                            if (e.type == ""create"" || e.type == ""update"") {
                                ");
            WriteLiteral(@"this.read();
                            }
                        },
                        error: function (e) {
                            display_kendoui_grid_error(e);
                            // Cancel the changes
                            this.cancelChanges();
                        },
                        serverPaging: true,
                        serverFiltering: true,
                        serverSorting: true
                    },
                    pageable: {
                        refresh: true,
                        numeric: false,
                        previousNext: false,
                        info: false
                    },
                    toolbar: [{ name: ""create"", text: """);
#nullable restore
#line 73 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\CustomerAction\_ConditionCustomerGroup.cshtml"
                                                  Write(Loc["Admin.Common.AddNewRecord"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" }, { name: \"save\", text: \"");
#nullable restore
#line 73 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\CustomerAction\_ConditionCustomerGroup.cshtml"
                                                                                                               Write(Loc["Admin.Common.Save"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" }, { name: \"cancel\", text: \"");
#nullable restore
#line 73 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\CustomerAction\_ConditionCustomerGroup.cshtml"
                                                                                                                                                                      Write(Loc["Admin.Common.Cancel"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" }],
                    editable: {
                        confirmation: false,
                        mode: ""inline"",
                    },
                    scrollable: false,
                    columns: [{
                            field: ""CustomerGroup"",
                            title: """);
#nullable restore
#line 81 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\CustomerAction\_ConditionCustomerGroup.cshtml"
                               Write(Loc["Admin.Customers.CustomerActionCondition.Fields.CustomerGroupName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
                            width: 200,
                            editor: customerGroupDropDownEditor,
                            template: ""#:CustomerGroup#""
                        },
                        {
                        command: [
                        {
                            name: ""destroy"",
                            text: """);
#nullable restore
#line 90 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\CustomerAction\_ConditionCustomerGroup.cshtml"
                              Write(Loc["Admin.Common.Delete"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""
                        }],
                        width: 200
                    }]
                });
            });

            function customerGroupDropDownEditor(container, options) {
                $('<input required data-text-field=""Name"" data-value-field=""Id"" data-bind=""value:CustomerGroupId""/>')
                    .appendTo(container)
                    .kendoDropDownList({
                        autoBind: false,
                        dataSource:
                        {
                            transport: {
                                read: """);
#nullable restore
#line 105 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\CustomerAction\_ConditionCustomerGroup.cshtml"
                                  Write(Html.Raw(Url.Action("CustomerGroups", "CustomerAction", new { area = Constants.AreaAdmin })));

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n                            }\r\n                        },\r\n                        optionLabel: \" -- Select -- \"\r\n                    });\r\n                }\r\n    </script>\r\n");
#nullable restore
#line 112 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\CustomerAction\_ConditionCustomerGroup.cshtml"

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CustomerActionConditionModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
