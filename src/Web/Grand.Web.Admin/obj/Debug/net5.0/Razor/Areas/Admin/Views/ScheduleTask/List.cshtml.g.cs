#pragma checksum "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\ScheduleTask\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54c4aaa319aa8b3514bda2ffbc3a8883e2177c4b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ScheduleTask_List), @"mvc.1.0.view", @"/Areas/Admin/Views/ScheduleTask/List.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54c4aaa319aa8b3514bda2ffbc3a8883e2177c4b", @"/Areas/Admin/Views/ScheduleTask/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b5aef36527620dc7872a6461ea7946585dc22b9", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_ScheduleTask_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::AspNetCore.Areas_Admin_Views_ScheduleTask_List.__Generated__AdminWidgetViewComponentTagHelper __AdminWidgetViewComponentTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\ScheduleTask\List.cshtml"
  
    //page title
    ViewBag.Title = Loc["Admin.System.ScheduleTasks"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <div class=\"x_panel light form-fit\">\r\n            <div class=\"x_title\">\r\n                <div class=\"caption level-caption\">\r\n                    <i class=\"fa fa-tasks\"></i>\r\n                    ");
#nullable restore
#line 12 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\ScheduleTask\List.cshtml"
               Write(Loc["Admin.System.ScheduleTasks"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:admin-widget", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "54c4aaa319aa8b3514bda2ffbc3a8883e2177c4b15478", async() => {
            }
            );
            __AdminWidgetViewComponentTagHelper = CreateTagHelper<global::AspNetCore.Areas_Admin_Views_ScheduleTask_List.__Generated__AdminWidgetViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__AdminWidgetViewComponentTagHelper);
            BeginWriteTagHelperAttribute();
            WriteLiteral("schedule_task_list_buttons");
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __AdminWidgetViewComponentTagHelper.widgetZone = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("widget-zone", __AdminWidgetViewComponentTagHelper.widgetZone, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 14 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\ScheduleTask\List.cshtml"
__AdminWidgetViewComponentTagHelper.additionalData = null;

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
            WriteLiteral("\r\n            </div>\r\n            <div class=\"note note-info\">\r\n                <strong>");
#nullable restore
#line 17 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\ScheduleTask\List.cshtml"
                   Write(Loc["Admin.System.ScheduleTasks.RestartApplication"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong>
            </div>
            <div class=""x_content form"">
                <div class=""form-horizontal"">
                    <div class=""form-body"">
                        <div class=""x_content"">
                            <div id=""schedule-tasks-grid""></div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<script>
    $(document).ready(function () {
        $(""#schedule-tasks-grid"").on(""click"", "".run-now"", function (e) {
            showThrobber('");
#nullable restore
#line 34 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\ScheduleTask\List.cshtml"
                     Write(Html.Raw(System.Text.Encodings.Web.JavaScriptEncoder.Default.Encode(Loc["Admin.System.ScheduleTasks.RunNow.Progress"])));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"');
        });
    });
</script>
<div id=""schedule-tasks-grid""></div>

<script>
    $(document).ready(function () {
        $(""#schedule-tasks-grid"").kendoGrid({
            dataSource: {
                transport: {
                    read: {
                        url: """);
#nullable restore
#line 46 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\ScheduleTask\List.cshtml"
                         Write(Html.Raw(Url.Action("List", "ScheduleTask", new { area = Constants.AreaAdmin })));

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\r\n                        type: \"POST\",\r\n                        dataType: \"json\",\r\n                        data: addAntiForgeryToken\r\n                    },\r\n                    update: {\r\n                        url: \"");
#nullable restore
#line 52 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\ScheduleTask\List.cshtml"
                         Write(Html.Raw(Url.Action("TaskUpdate", "ScheduleTask", new { area = Constants.AreaAdmin })));

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
                            Id: { editable: false, type: ""string"" },
                            ScheduleTaskName: { editable: true, type: ""string"" },
                            Enabled: { editable: true, type: ""boolean"" },
                            StopOnError: { editable: true, type: ""boolean"" },
                            LastStartUtc: { editable: false, type: ""date"" },
                            LastEndUtc: { editable: false, type: ""date"" },
                            LastSuccessUtc: { editable: false, type: ""date"" }
                        }
                    }
                ");
            WriteLiteral(@"},
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
            editable: {
                confirmation: false,
                mode: ""inline""
            },
            scrollable: false,
            columns: [
                    {
                        field: ""ScheduleTaskName"",
                        title: """);
#nullable restore
#line 98 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\ScheduleTask\List.cshtml"
                           Write(Loc["Admin.System.ScheduleTasks.Name"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
                        width: 300,
                        template: '<a class=""k-link"" href=""EditScheduler/#=Id#"">#=ScheduleTaskName#</a>',
                    },
                    {
                        field: ""Enabled"",
                        title: """);
#nullable restore
#line 104 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\ScheduleTask\List.cshtml"
                           Write(Loc["Admin.System.ScheduleTasks.Enabled"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
                        width: 100,
                        headerAttributes: { style: ""text-align:center"" },
                        attributes: { style: ""text-align:center"" },
                        template: '# if(Enabled) {# <i class=""fa fa-check"" aria-hidden=""true"" style=""color:green""></i> #} else {# <i class=""fa fa-times"" aria-hidden=""true"" style=""color:red""></i> #} #'
                    }, {
                        field: ""StopOnError"",
                        title: """);
#nullable restore
#line 111 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\ScheduleTask\List.cshtml"
                           Write(Loc["Admin.System.ScheduleTasks.StopOnError"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
                        width: 100,
                        headerAttributes: { style: ""text-align:center"" },
                        attributes: { style: ""text-align:center"" },
                        template: '# if(StopOnError) {# <i class=""fa fa-check"" aria-hidden=""true"" style=""color:green""></i> #} else {# <i class=""fa fa-times"" aria-hidden=""true"" style=""color:red""></i> #} #'
                    }, {
                        field: ""LastStartUtc"",
                        title: """);
#nullable restore
#line 118 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\ScheduleTask\List.cshtml"
                           Write(Loc["Admin.System.ScheduleTasks.LastStart"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\r\n                        width: 200,\r\n                        type: \"date\",\r\n                        format: \"{0:G}\"\r\n                    }, {\r\n                        field: \"LastSuccessUtc\",\r\n                        title: \"");
#nullable restore
#line 124 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\ScheduleTask\List.cshtml"
                           Write(Loc["Admin.System.ScheduleTasks.LastSuccess"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\r\n                        width: 200,\r\n                        type: \"date\",\r\n                        format: \"{0:G}\"\r\n                    }, {\r\n                        field: \"LastEndUtc\",\r\n                        title: \"");
#nullable restore
#line 130 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\ScheduleTask\List.cshtml"
                           Write(Loc["Admin.System.ScheduleTasks.LastEnd"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\r\n                        width: 200,\r\n                        type: \"date\",\r\n                        format: \"{0:G}\"\r\n                    }, {\r\n                        field: \"Id\",\r\n                        title: \"");
#nullable restore
#line 136 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\ScheduleTask\List.cshtml"
                           Write(Loc["Admin.System.ScheduleTasks.RunNow"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\r\n                        width: 100,\r\n                        template: \'<a href=\"");
#nullable restore
#line 138 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\ScheduleTask\List.cshtml"
                                       Write(Url.Action("RunNow", "ScheduleTask", new { area = Constants.AreaAdmin }));

#line default
#line hidden
#nullable disable
            WriteLiteral("/#=Id#\" class=\"k-button run-now k-button-icontext\"><i class=\"fa fa-forward\"></i> ");
#nullable restore
#line 138 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web.Admin\Areas\Admin\Views\ScheduleTask\List.cshtml"
                                                                                                                                                                                                 Write(Loc["Admin.System.ScheduleTasks.RunNow"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\'\r\n                }]\r\n        });\r\n    });\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
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
