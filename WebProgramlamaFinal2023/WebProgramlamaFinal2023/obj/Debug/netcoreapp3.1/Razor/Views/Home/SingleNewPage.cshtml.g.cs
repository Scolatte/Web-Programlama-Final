#pragma checksum "C:\Users\Kerim\source\repos\WebProgramlamaFinal2023\WebProgramlamaFinal2023\Views\Home\SingleNewPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b8c9561c4cacc1acde1b06aa9f18d320e05a5d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SingleNewPage), @"mvc.1.0.view", @"/Views/Home/SingleNewPage.cshtml")]
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
#line 1 "C:\Users\Kerim\source\repos\WebProgramlamaFinal2023\WebProgramlamaFinal2023\Views\_ViewImports.cshtml"
using WebProgramlamaFinal2023;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kerim\source\repos\WebProgramlamaFinal2023\WebProgramlamaFinal2023\Views\_ViewImports.cshtml"
using WebProgramlamaFinal2023.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b8c9561c4cacc1acde1b06aa9f18d320e05a5d3", @"/Views/Home/SingleNewPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7e8538034d07beb195e84edbf8acd4079ebbf00", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_SingleNewPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<News>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Kerim\source\repos\WebProgramlamaFinal2023\WebProgramlamaFinal2023\Views\Home\SingleNewPage.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Breadcrumb Start -->
<div class=""breadcrumb-wrap"">
    <div class=""container-fluid"">
        <ul class=""breadcrumb"">
            <li class=""breadcrumb-item""><a href=""#"">Home</a></li>
            <li class=""breadcrumb-item""><a href=""#"">News</a></li>
            <li class=""breadcrumb-item active"">News details</li>
        </ul>
    </div>
</div>
<!-- Breadcrumb End -->

<!-- Single News Start-->
<div class=""single-news"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-md-8"">
                <div class=""sn-img"">
                    <img");
            BeginWriteAttribute("src", " src=\"", 664, "\"", 682, 1);
#nullable restore
#line 25 "C:\Users\Kerim\source\repos\WebProgramlamaFinal2023\WebProgramlamaFinal2023\Views\Home\SingleNewPage.cshtml"
WriteAttributeValue("", 670, Model.Image, 670, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </div>\r\n                <div class=\"sn-content\">\r\n                    <a class=\"sn-title\"");
            BeginWriteAttribute("href", " href=\"", 793, "\"", 800, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 28 "C:\Users\Kerim\source\repos\WebProgramlamaFinal2023\WebProgramlamaFinal2023\Views\Home\SingleNewPage.cshtml"
                                           Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                    <a class=\"sn-date\"");
            BeginWriteAttribute("href", " href=\"", 858, "\"", 865, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"far fa-clock\"></i>");
#nullable restore
#line 29 "C:\Users\Kerim\source\repos\WebProgramlamaFinal2023\WebProgramlamaFinal2023\Views\Home\SingleNewPage.cshtml"
                                                                      Write(Model.PublishDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
            WriteLiteral("                    <p>\r\n                        ");
#nullable restore
#line 34 "C:\Users\Kerim\source\repos\WebProgramlamaFinal2023\WebProgramlamaFinal2023\Views\Home\SingleNewPage.cshtml"
                   Write(Model.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                </div>\r\n            </div>\r\n\r\n");
            WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- Single News End-->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<News> Html { get; private set; }
    }
}
#pragma warning restore 1591
