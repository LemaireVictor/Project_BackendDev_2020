#pragma checksum "C:\Users\Victor Lemaire\source\repos\JAQ_BackendDev\JAQ_BackendDev.Web\Views\Quiz\EndQuiz.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fdc177eab93216547e9acea725752acfbb1b5d49"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Quiz_EndQuiz), @"mvc.1.0.view", @"/Views/Quiz/EndQuiz.cshtml")]
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
#line 1 "C:\Users\Victor Lemaire\source\repos\JAQ_BackendDev\JAQ_BackendDev.Web\Views\_ViewImports.cshtml"
using JAQ_BackendDev.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Victor Lemaire\source\repos\JAQ_BackendDev\JAQ_BackendDev.Web\Views\_ViewImports.cshtml"
using JAQ_BackendDev.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Victor Lemaire\source\repos\JAQ_BackendDev\JAQ_BackendDev.Web\Views\_ViewImports.cshtml"
using JAQ_BackendDev.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Victor Lemaire\source\repos\JAQ_BackendDev\JAQ_BackendDev.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fdc177eab93216547e9acea725752acfbb1b5d49", @"/Views/Quiz/EndQuiz.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41327eabe561072ed9115b1743626b052c32fe9a", @"/Views/_ViewImports.cshtml")]
    public class Views_Quiz_EndQuiz : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<JAQ_BackendDev.Web.ViewModels.QuizScore>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Victor Lemaire\source\repos\JAQ_BackendDev\JAQ_BackendDev.Web\Views\Quiz\EndQuiz.cshtml"
  
    ViewData["Title"] = "EndQuiz";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 6 "C:\Users\Victor Lemaire\source\repos\JAQ_BackendDev\JAQ_BackendDev.Web\Views\Quiz\EndQuiz.cshtml"
Write(Model.quiz.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<h2>Congratulations Your score is :</h2>\r\n\r\n<h3>");
#nullable restore
#line 10 "C:\Users\Victor Lemaire\source\repos\JAQ_BackendDev\JAQ_BackendDev.Web\Views\Quiz\EndQuiz.cshtml"
Write(ViewBag.score);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<JAQ_BackendDev.Web.ViewModels.QuizScore> Html { get; private set; }
    }
}
#pragma warning restore 1591
