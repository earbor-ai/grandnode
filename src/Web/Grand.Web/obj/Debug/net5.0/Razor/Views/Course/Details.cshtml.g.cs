#pragma checksum "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web\Views\Course\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "372b1a84749952dfa9c38c14a526e96d4ab8147e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Course_Details), @"mvc.1.0.view", @"/Views/Course/Details.cshtml")]
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
#line 8 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.ViewFeatures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web\Views\_ViewImports.cshtml"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web\Views\_ViewImports.cshtml"
using Grand.SharedKernel.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web\Views\_ViewImports.cshtml"
using Grand.Web.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web\Views\_ViewImports.cshtml"
using Grand.Web.Common.Page;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web\Views\_ViewImports.cshtml"
using Grand.Web.Common.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web\Views\_ViewImports.cshtml"
using Grand.Web.Common.Security.Captcha;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web\Views\_ViewImports.cshtml"
using Grand.Web.Common.Themes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web\Views\_ViewImports.cshtml"
using Grand.Web.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web\Views\_ViewImports.cshtml"
using Grand.Web.Models.Blogs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web\Views\_ViewImports.cshtml"
using Grand.Web.Models.Catalog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web\Views\_ViewImports.cshtml"
using Grand.Web.Models.Checkout;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web\Views\_ViewImports.cshtml"
using Grand.Web.Models.Cms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web\Views\_ViewImports.cshtml"
using Grand.Web.Models.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web\Views\_ViewImports.cshtml"
using Grand.Web.Models.Course;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web\Views\_ViewImports.cshtml"
using Grand.Web.Models.Customer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web\Views\_ViewImports.cshtml"
using Grand.Web.Models.Knowledgebase;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web\Views\_ViewImports.cshtml"
using Grand.Web.Models.Media;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web\Views\_ViewImports.cshtml"
using Grand.Web.Models.News;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web\Views\_ViewImports.cshtml"
using Grand.Web.Models.Newsletter;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web\Views\_ViewImports.cshtml"
using Grand.Web.Models.Orders;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web\Views\_ViewImports.cshtml"
using Grand.Web.Models.ShoppingCart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web\Views\_ViewImports.cshtml"
using Grand.Web.Models.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web\Views\_ViewImports.cshtml"
using Grand.Web.Models.Vendors;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web\Views\_ViewImports.cshtml"
using Grand.Domain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web\Views\_ViewImports.cshtml"
using Grand.Domain.Catalog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web\Views\_ViewImports.cshtml"
using Grand.Domain.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web\Views\_ViewImports.cshtml"
using Grand.Domain.Orders;

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web\Views\_ViewImports.cshtml"
using Grand.Domain.Customers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web\Views\_ViewImports.cshtml"
using Grand.Domain.Tax;

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web\Views\_ViewImports.cshtml"
using Grand.Domain.Seo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web\Views\_ViewImports.cshtml"
using Grand.Domain.Stores;

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web\Views\_ViewImports.cshtml"
using Grand.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"372b1a84749952dfa9c38c14a526e96d4ab8147e", @"/Views/Course/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c5e7d055263222a80545b02d059604b599b8f3e", @"/Views/_ViewImports.cshtml")]
    public class Views_Course_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CourseModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web\Views\Course\Details.cshtml"
  
    Layout = "_SingleColumn";
    pagebuilder.AddTitleParts(!String.IsNullOrEmpty(Model.MetaTitle) ? Model.MetaTitle : Model.Name);
    pagebuilder.AddMetaDescriptionParts(Model.MetaDescription);
    pagebuilder.AddMetaKeywordParts(Model.MetaKeywords);

    var canonicalUrlsEnabled = seoSettings.CanonicalUrlsEnabled;
    if (canonicalUrlsEnabled)
    {
        var courseUrl = Url.RouteUrl("Course", new { SeName = Model.SeName }, this.Url.ActionContext.HttpContext.Request.Scheme);
        pagebuilder.AddCanonicalUrlParts(courseUrl);
    }


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"page category-page\">\r\n    ");
#nullable restore
#line 20 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web\Views\Course\Details.cshtml"
Write(await Component.InvokeAsync("Widget", new { widgetZone = "coursedetails_top", additionalData = Model.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"jumbotron p-4 mt-3\">\r\n        <div class=\"container d-inline-flex px-0\">\r\n            <div class=\"d-inline-flex flex-sm-row flex-column align-items-sm-start w-100\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 1006, "\"", 1029, 1);
#nullable restore
#line 24 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web\Views\Course\Details.cshtml"
WriteAttributeValue("", 1012, Model.PictureUrl, 1012, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"mr-3\" />\r\n                <div class=\"media-body\">\r\n                    <h2 class=\"d-flex flex-column\">");
#nullable restore
#line 26 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web\Views\Course\Details.cshtml"
                                              Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("<span class=\"h6\">(");
#nullable restore
#line 26 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web\Views\Course\Details.cshtml"
                                                                           Write(Model.Level);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</span></h2>\r\n");
#nullable restore
#line 27 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web\Views\Course\Details.cshtml"
                     if (!String.IsNullOrWhiteSpace(Model.Description))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>\r\n                            ");
#nullable restore
#line 30 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web\Views\Course\Details.cshtml"
                       Write(Html.Raw(Model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n");
#nullable restore
#line 32 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web\Views\Course\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n            <div class=\"d-inline-flex\">\r\n");
#nullable restore
#line 36 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web\Views\Course\Details.cshtml"
                 if (Model.Approved)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""custom-control custom-checkbox my-1 mr-sm-2"">
                        <input type=""checkbox"" class=""custom-control-input"" id=""customControlInline"" checked disabled>
                        <label class=""custom-control-label"" for=""customControlInline""></label>
                    </div>
");
#nullable restore
#line 42 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web\Views\Course\Details.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""custom-control disabled custom-checkbox my-1 mr-sm-2"">
                        <input type=""checkbox"" class=""custom-control-input"" id=""customControlInline"" disabled>
                        <label class=""custom-control-label"" for=""customControlInline""></label>
                    </div>
");
#nullable restore
#line 49 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web\Views\Course\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n    ");
#nullable restore
#line 53 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web\Views\Course\Details.cshtml"
Write(await Component.InvokeAsync("Widget", new { widgetZone = "coursedetails_before_subcategories", additionalData = Model.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"list-group\">\r\n");
#nullable restore
#line 55 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web\Views\Course\Details.cshtml"
         foreach (var subject in Model.Subjects)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"list-group-item list-group-item-action mb-3\">\r\n                <h4>\r\n                    <strong>");
#nullable restore
#line 59 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web\Views\Course\Details.cshtml"
                       Write(subject.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                </h4>\r\n                <ul class=\"list-unstyled\">\r\n");
#nullable restore
#line 62 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web\Views\Course\Details.cshtml"
                     foreach (var lesson in Model.Lessons.Where(x => x.SubjectId == subject.Id).OrderBy(x => x.DisplayOrder))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"media mb-3\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 3013, "\"", 3037, 1);
#nullable restore
#line 65 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web\Views\Course\Details.cshtml"
WriteAttributeValue("", 3019, lesson.PictureUrl, 3019, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"mr-3\" />\r\n                            <div class=\"media-body d-inline-flex\">\r\n                                <div class=\"w-100\">\r\n\r\n                                    <h5 class=\"mt-0 mb-1\">");
#nullable restore
#line 69 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web\Views\Course\Details.cshtml"
                                                     Write(Html.ActionLink(lesson.Name, "Lesson", "Course", new { id = lesson.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                    ");
#nullable restore
#line 70 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web\Views\Course\Details.cshtml"
                               Write(lesson.ShortDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"d-inline-flex\">\r\n");
#nullable restore
#line 73 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web\Views\Course\Details.cshtml"
                                     if (lesson.Approved)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"custom-control custom-checkbox my-1 mr-sm-2\">\r\n                                            <input type=\"checkbox\" class=\"custom-control-input\"");
            BeginWriteAttribute("id", " id=\"", 3772, "\"", 3787, 1);
#nullable restore
#line 76 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web\Views\Course\Details.cshtml"
WriteAttributeValue("", 3777, lesson.Id, 3777, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" checked disabled>\r\n                                            <label class=\"custom-control-label\"");
            BeginWriteAttribute("for", " for=\"", 3887, "\"", 3903, 1);
#nullable restore
#line 77 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web\Views\Course\Details.cshtml"
WriteAttributeValue("", 3893, lesson.Id, 3893, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></label>\r\n                                        </div>\r\n");
#nullable restore
#line 79 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web\Views\Course\Details.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"custom-control disabled custom-checkbox my-1 mr-sm-2\">\r\n                                            <input type=\"checkbox\" class=\"custom-control-input\"");
            BeginWriteAttribute("id", " id=\"", 4286, "\"", 4303, 2);
            WriteAttributeValue("", 4291, "2-", 4291, 2, true);
#nullable restore
#line 83 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web\Views\Course\Details.cshtml"
WriteAttributeValue("", 4293, lesson.Id, 4293, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" disabled>\r\n                                            <label class=\"custom-control-label\"");
            BeginWriteAttribute("for", " for=\"", 4395, "\"", 4413, 2);
            WriteAttributeValue("", 4401, "2-", 4401, 2, true);
#nullable restore
#line 84 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web\Views\Course\Details.cshtml"
WriteAttributeValue("", 4403, lesson.Id, 4403, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></label>\r\n                                        </div>\r\n");
#nullable restore
#line 86 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web\Views\Course\Details.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </div>\r\n                            </div>\r\n                        </li>\r\n");
#nullable restore
#line 90 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web\Views\Course\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n            </div>\r\n");
#nullable restore
#line 93 "C:\Users\kishore\source\repos\grandnode\grandnode2\src\Web\Grand.Web\Views\Course\Details.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IPageHeadBuilder pagebuilder { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SeoSettings seoSettings { get; private set; }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CourseModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
