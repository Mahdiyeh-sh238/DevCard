#pragma checksum "E:\asp_project\DevCard\Mahdiyeh-sh238\DevCard\DevCard_MVC\Views\Home\Components\LateastArticles\_LateastArticles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dfb211eb4b79d2b4049302f980edbff7e0e31e6a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Components_LateastArticles__LateastArticles), @"mvc.1.0.view", @"/Views/Home/Components/LateastArticles/_LateastArticles.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\asp_project\DevCard\Mahdiyeh-sh238\DevCard\DevCard_MVC\Views\_ViewImports.cshtml"
using DevCard_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\asp_project\DevCard\Mahdiyeh-sh238\DevCard\DevCard_MVC\Views\_ViewImports.cshtml"
using DevCard_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfb211eb4b79d2b4049302f980edbff7e0e31e6a", @"/Views/Home/Components/LateastArticles/_LateastArticles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"520493a69a7d20751d0e9831363d66b394bf2f41", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Components_LateastArticles__LateastArticles : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Article>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<section class=\"latest-blog-section p-3 p-lg-5\">\r\n    <div class=\"container\">\r\n        <h2 class=\"section-title font-weight-bold mb-5\">آخرین مقالات</h2>\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 6 "E:\asp_project\DevCard\Mahdiyeh-sh238\DevCard\DevCard_MVC\Views\Home\Components\LateastArticles\_LateastArticles.cshtml"
             foreach (var article in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-4 mb-5\">\r\n                    <div class=\"card blog-post-card\">\r\n                        <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 412, "\"", 451, 2);
            WriteAttributeValue("", 418, "assets/images/blog/", 418, 19, true);
#nullable restore
#line 10 "E:\asp_project\DevCard\Mahdiyeh-sh238\DevCard\DevCard_MVC\Views\Home\Components\LateastArticles\_LateastArticles.cshtml"
WriteAttributeValue("", 437, article.Image, 437, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"image\">\r\n                        <div class=\"card-body\">\r\n                            <h5 class=\"card-title\">\r\n                                <a class=\"theme-link\" href=\"blog-post.html\">\r\n                                    ");
#nullable restore
#line 14 "E:\asp_project\DevCard\Mahdiyeh-sh238\DevCard\DevCard_MVC\Views\Home\Components\LateastArticles\_LateastArticles.cshtml"
                               Write(article.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </a>\r\n                            </h5>\r\n                            <p class=\"card-text\">\r\n                                ");
#nullable restore
#line 18 "E:\asp_project\DevCard\Mahdiyeh-sh238\DevCard\DevCard_MVC\Views\Home\Components\LateastArticles\_LateastArticles.cshtml"
                           Write(article.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </p>\r\n                            <p class=\"mb-0\"><a class=\"more-link\" href=\"blog-post.html\">ادامه مطلب</a></p>\r\n\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 25 "E:\asp_project\DevCard\Mahdiyeh-sh238\DevCard\DevCard_MVC\Views\Home\Components\LateastArticles\_LateastArticles.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n\r\n        </div>\r\n    </div>\r\n</section>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Article>> Html { get; private set; }
    }
}
#pragma warning restore 1591
