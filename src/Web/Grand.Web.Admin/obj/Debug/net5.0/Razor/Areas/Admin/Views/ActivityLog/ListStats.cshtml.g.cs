#pragma checksum "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\ActivityLog\ListStats.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3586e384a08e71f0555bc5fe7da999cee9cc6ddc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ActivityLog_ListStats), @"mvc.1.0.view", @"/Areas/Admin/Views/ActivityLog/ListStats.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3586e384a08e71f0555bc5fe7da999cee9cc6ddc", @"/Areas/Admin/Views/ActivityLog/ListStats.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b5aef36527620dc7872a6461ea7946585dc22b9", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_ActivityLog_ListStats : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ActivityLogSearchModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-flex flex-column align-items-start mw-100 px-0 text-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Grand.Web.Common.TagHelpers.Admin.LabelRequiredTagHelper __Grand_Web_Common_TagHelpers_Admin_LabelRequiredTagHelper;
        private global::Grand.Web.Common.TagHelpers.Admin.AdminInputTagHelper __Grand_Web_Common_TagHelpers_Admin_AdminInputTagHelper;
        private global::Grand.Web.Common.TagHelpers.Admin.AdminSelectTagHelper __Grand_Web_Common_TagHelpers_Admin_AdminSelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\ActivityLog\ListStats.cshtml"
  
    //page title
    ViewBag.Title = Loc["admin.reports.activitylog.activitystats"];

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-12"">
        <div class=""x_panel light form-fit popup-window"">
            <div class=""x_title"">
                <div class=""caption level-caption"">
                    <i class=""fa fa-sitemap""></i>
                    ");
#nullable restore
#line 14 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\ActivityLog\ListStats.cshtml"
               Write(Loc["admin.reports.activitylog.activitystats"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
            </div>
            <div class=""x_content form"">
                <div class=""form-horizontal col-12 px-0"">
                    <div class=""form-body row align-items-end"">
                        <div class=""form-group mb-0 col-md-3 col-sm-12 col-12"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("admin-label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3586e384a08e71f0555bc5fe7da999cee9cc6ddc16491", async() => {
            }
            );
            __Grand_Web_Common_TagHelpers_Admin_LabelRequiredTagHelper = CreateTagHelper<global::Grand.Web.Common.TagHelpers.Admin.LabelRequiredTagHelper>();
            __tagHelperExecutionContext.Add(__Grand_Web_Common_TagHelpers_Admin_LabelRequiredTagHelper);
#nullable restore
#line 21 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\ActivityLog\ListStats.cshtml"
__Grand_Web_Common_TagHelpers_Admin_LabelRequiredTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CreatedOnFrom);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Grand_Web_Common_TagHelpers_Admin_LabelRequiredTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("admin-input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3586e384a08e71f0555bc5fe7da999cee9cc6ddc18117", async() => {
            }
            );
            __Grand_Web_Common_TagHelpers_Admin_AdminInputTagHelper = CreateTagHelper<global::Grand.Web.Common.TagHelpers.Admin.AdminInputTagHelper>();
            __tagHelperExecutionContext.Add(__Grand_Web_Common_TagHelpers_Admin_AdminInputTagHelper);
#nullable restore
#line 22 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\ActivityLog\ListStats.cshtml"
__Grand_Web_Common_TagHelpers_Admin_AdminInputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CreatedOnFrom);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Grand_Web_Common_TagHelpers_Admin_AdminInputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"form-group mb-0 col-md-3 col-sm-12 col-12\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("admin-label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3586e384a08e71f0555bc5fe7da999cee9cc6ddc19764", async() => {
            }
            );
            __Grand_Web_Common_TagHelpers_Admin_LabelRequiredTagHelper = CreateTagHelper<global::Grand.Web.Common.TagHelpers.Admin.LabelRequiredTagHelper>();
            __tagHelperExecutionContext.Add(__Grand_Web_Common_TagHelpers_Admin_LabelRequiredTagHelper);
#nullable restore
#line 25 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\ActivityLog\ListStats.cshtml"
__Grand_Web_Common_TagHelpers_Admin_LabelRequiredTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CreatedOnTo);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Grand_Web_Common_TagHelpers_Admin_LabelRequiredTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("admin-input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3586e384a08e71f0555bc5fe7da999cee9cc6ddc21388", async() => {
            }
            );
            __Grand_Web_Common_TagHelpers_Admin_AdminInputTagHelper = CreateTagHelper<global::Grand.Web.Common.TagHelpers.Admin.AdminInputTagHelper>();
            __tagHelperExecutionContext.Add(__Grand_Web_Common_TagHelpers_Admin_AdminInputTagHelper);
#nullable restore
#line 26 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\ActivityLog\ListStats.cshtml"
__Grand_Web_Common_TagHelpers_Admin_AdminInputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CreatedOnTo);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Grand_Web_Common_TagHelpers_Admin_AdminInputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"form-group mb-0 col-md-3 col-sm-12 col-12\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("admin-label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3586e384a08e71f0555bc5fe7da999cee9cc6ddc23033", async() => {
            }
            );
            __Grand_Web_Common_TagHelpers_Admin_LabelRequiredTagHelper = CreateTagHelper<global::Grand.Web.Common.TagHelpers.Admin.LabelRequiredTagHelper>();
            __tagHelperExecutionContext.Add(__Grand_Web_Common_TagHelpers_Admin_LabelRequiredTagHelper);
#nullable restore
#line 29 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\ActivityLog\ListStats.cshtml"
__Grand_Web_Common_TagHelpers_Admin_LabelRequiredTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ActivityLogTypeId);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Grand_Web_Common_TagHelpers_Admin_LabelRequiredTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("admin-select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3586e384a08e71f0555bc5fe7da999cee9cc6ddc24663", async() => {
            }
            );
            __Grand_Web_Common_TagHelpers_Admin_AdminSelectTagHelper = CreateTagHelper<global::Grand.Web.Common.TagHelpers.Admin.AdminSelectTagHelper>();
            __tagHelperExecutionContext.Add(__Grand_Web_Common_TagHelpers_Admin_AdminSelectTagHelper);
#nullable restore
#line 30 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\ActivityLog\ListStats.cshtml"
__Grand_Web_Common_TagHelpers_Admin_AdminSelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ActivityLogTypeId);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Grand_Web_Common_TagHelpers_Admin_AdminSelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 30 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\ActivityLog\ListStats.cshtml"
__Grand_Web_Common_TagHelpers_Admin_AdminSelectTagHelper.Items = Model.ActivityLogType;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Grand_Web_Common_TagHelpers_Admin_AdminSelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                        <div class=""form-actions col-md-3 col-sm-12 col-12"">
                            <button class=""btn btn-success filter-submit"" id=""search-log"">
                                <i class=""fa fa-search""></i> ");
#nullable restore
#line 34 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\ActivityLog\ListStats.cshtml"
                                                        Write(Loc["Admin.Common.Search"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </button>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""x_content"">
                <div id=""activityLog-grid""></div>
            </div>
        </div>
    </div>
</div>
<script>
    $(document).ready(function () {
        $(""#activityLog-grid"").kendoGrid({
            dataSource: {
                transport: {
                    read: {
                        url: """);
#nullable restore
#line 52 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\ActivityLog\ListStats.cshtml"
                         Write(Html.Raw(Url.Action("ListStats", "ActivityLog", new { area = Constants.AreaAdmin })));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
                        type: ""POST"",
                        dataType: ""json"",
                        data: additionalData
                    },
                },
                schema: {
                    data: ""Data"",
                    total: ""Total"",
                    errors: ""Errors"",
                    model: {
                        id: ""Id"",
                    }
                },
                error: function(e) {
                    display_kendoui_grid_error(e);
                    // Cancel the changes
                    this.cancelChanges();
                },
                pageSize: ");
#nullable restore
#line 71 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\ActivityLog\ListStats.cshtml"
                      Write(adminAreaSettings.DefaultGridPageSize);

#line default
#line hidden
#nullable disable
            WriteLiteral(",\r\n                serverPaging: true,\r\n                serverFiltering: true,\r\n                serverSorting: true\r\n            },\r\n            pageable: {\r\n                refresh: true,\r\n                pageSizes: [");
#nullable restore
#line 78 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\ActivityLog\ListStats.cshtml"
                        Write(adminAreaSettings.GridPageSizes);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"]
            },
            editable: {
                confirmation: false,
                mode: ""inline""
            },
            scrollable: false,
            columns: [{
                field: ""ActivityLogTypeName"",
                title: """);
#nullable restore
#line 87 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\ActivityLog\ListStats.cshtml"
                   Write(Loc["admin.reports.activitylog.activitystats.Fields.ActivityLogType"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\r\n                width: 250\r\n            }, {\r\n                field: \"Name\",\r\n                title: \"");
#nullable restore
#line 91 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\ActivityLog\ListStats.cshtml"
                   Write(Loc["admin.reports.activitylog.activitystats.Fields.Name"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n            }, {\r\n                field: \"Count\",\r\n                title: \"");
#nullable restore
#line 94 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\ActivityLog\ListStats.cshtml"
                   Write(Loc["admin.reports.activitylog.activitystats.Fields.Count"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
                width: 100,
            }]
        });
    });
</script>
<script>

    $(document).ready(function () {

        $('#search-log').click(function () {
            var grid = $('#activityLog-grid').data('kendoGrid');
            grid.dataSource.page(1); //new search. Set page size to 1
            //grid.dataSource.read(); we already loaded the grid above using ""page"" function
            return false;
        });
    });

    function additionalData() {
        var data = {
            CreatedOnFrom: $('#");
#nullable restore
#line 114 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\ActivityLog\ListStats.cshtml"
                          Write(Html.IdFor(model => model.CreatedOnFrom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\').val(),\r\n            CreatedOnTo: $(\'#");
#nullable restore
#line 115 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\ActivityLog\ListStats.cshtml"
                        Write(Html.IdFor(model => model.CreatedOnTo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\').val(),\r\n            ActivityLogTypeId: $(\'#ActivityLogTypeId\').val()\r\n        };\r\n        addAntiForgeryToken(data);\r\n        return data;\r\n    }\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ActivityLogSearchModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
