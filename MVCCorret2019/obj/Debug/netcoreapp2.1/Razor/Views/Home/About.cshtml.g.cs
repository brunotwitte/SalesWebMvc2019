#pragma checksum "C:\Users\casa\source\repos\MVCCorret2019\MVCCorret2019\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbac9bf16c4a105ee7b9180e65ad693476e1c278"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/About.cshtml", typeof(AspNetCore.Views_Home_About))]
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
#line 1 "C:\Users\casa\source\repos\MVCCorret2019\MVCCorret2019\Views\_ViewImports.cshtml"
using MVCCorret2019;

#line default
#line hidden
#line 2 "C:\Users\casa\source\repos\MVCCorret2019\MVCCorret2019\Views\_ViewImports.cshtml"
using MVCCorret2019.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbac9bf16c4a105ee7b9180e65ad693476e1c278", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42f386691ce4ccc43b5cf96f038fbc465550cd49", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\casa\source\repos\MVCCorret2019\MVCCorret2019\Views\Home\About.cshtml"
      
    ViewData["Title"] = "About";

#line default
#line hidden
            BeginContext(45, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(50, 17, false);
#line 4 "C:\Users\casa\source\repos\MVCCorret2019\MVCCorret2019\Views\Home\About.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(67, 11, true);
            WriteLiteral("</h2>\r\n<h3>");
            EndContext();
            BeginContext(79, 19, false);
#line 5 "C:\Users\casa\source\repos\MVCCorret2019\MVCCorret2019\Views\Home\About.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(98, 22, true);
            WriteLiteral("</h3>\r\n\r\n<p>Developer ");
            EndContext();
            BeginContext(121, 21, false);
#line 7 "C:\Users\casa\source\repos\MVCCorret2019\MVCCorret2019\Views\Home\About.cshtml"
        Write(ViewData["Developer"]);

#line default
#line hidden
            EndContext();
            BeginContext(142, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(152, 17, false);
#line 8 "C:\Users\casa\source\repos\MVCCorret2019\MVCCorret2019\Views\Home\About.cshtml"
Write(ViewData["email"]);

#line default
#line hidden
            EndContext();
            BeginContext(169, 136, true);
            WriteLiteral("</p>\r\n<address>\r\n    <strong> More Information:</strong>\r\n    <a href=\"http://www.gcfsistemas.com.br\">gcfsistemas.com.br</a>\r\n</address>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
