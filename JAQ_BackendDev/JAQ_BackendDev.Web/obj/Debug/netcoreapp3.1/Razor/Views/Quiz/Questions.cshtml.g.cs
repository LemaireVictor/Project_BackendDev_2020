#pragma checksum "C:\Users\Victor Lemaire\source\repos\JAQ_BackendDev\JAQ_BackendDev.Web\Views\Quiz\Questions.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "314fd8f56b17156c726cd2c83a3e86aac722ac1e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Quiz_Questions), @"mvc.1.0.view", @"/Views/Quiz/Questions.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"314fd8f56b17156c726cd2c83a3e86aac722ac1e", @"/Views/Quiz/Questions.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41327eabe561072ed9115b1743626b052c32fe9a", @"/Views/_ViewImports.cshtml")]
    public class Views_Quiz_Questions : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<JAQ_BackendDev.Models.Question>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateQuestion", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Victor Lemaire\source\repos\JAQ_BackendDev\JAQ_BackendDev.Web\Views\Quiz\Questions.cshtml"
  
    ViewData["Title"] = "Questions";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Questions</h1>\r\n\r\n<h2> ");
#nullable restore
#line 9 "C:\Users\Victor Lemaire\source\repos\JAQ_BackendDev\JAQ_BackendDev.Web\Views\Quiz\Questions.cshtml"
Write(ViewBag.QuizName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - (Quiz)</h2>\r\n\r\n<p>\r\n    ");
#nullable restore
#line 12 "C:\Users\Victor Lemaire\source\repos\JAQ_BackendDev\JAQ_BackendDev.Web\Views\Quiz\Questions.cshtml"
Write(Html.ActionLink("Return To My Quizzes", "MyQuizzes", new { }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "314fd8f56b17156c726cd2c83a3e86aac722ac1e4761", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-quizid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 13 "C:\Users\Victor Lemaire\source\repos\JAQ_BackendDev\JAQ_BackendDev.Web\Views\Quiz\Questions.cshtml"
                                        WriteLiteral(ViewBag.QuizId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["quizid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-quizid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["quizid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\Victor Lemaire\source\repos\JAQ_BackendDev\JAQ_BackendDev.Web\Views\Quiz\Questions.cshtml"
           Write(Html.DisplayNameFor(model => model.QuestionSelf));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\Victor Lemaire\source\repos\JAQ_BackendDev\JAQ_BackendDev.Web\Views\Quiz\Questions.cshtml"
           Write(Html.DisplayNameFor(model => model.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 28 "C:\Users\Victor Lemaire\source\repos\JAQ_BackendDev\JAQ_BackendDev.Web\Views\Quiz\Questions.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 31 "C:\Users\Victor Lemaire\source\repos\JAQ_BackendDev\JAQ_BackendDev.Web\Views\Quiz\Questions.cshtml"
           Write(Html.DisplayFor(modelItem => item.QuestionSelf));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "C:\Users\Victor Lemaire\source\repos\JAQ_BackendDev\JAQ_BackendDev.Web\Views\Quiz\Questions.cshtml"
           Write(Html.DisplayFor(modelItem => item.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\Victor Lemaire\source\repos\JAQ_BackendDev\JAQ_BackendDev.Web\Views\Quiz\Questions.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 38 "C:\Users\Victor Lemaire\source\repos\JAQ_BackendDev\JAQ_BackendDev.Web\Views\Quiz\Questions.cshtml"
           Write(Html.ActionLink("Answers", "Answers", new {id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 39 "C:\Users\Victor Lemaire\source\repos\JAQ_BackendDev\JAQ_BackendDev.Web\Views\Quiz\Questions.cshtml"
           Write(Html.ActionLink("Delete", "DeleteQuestion", new { /* id=item.PrimaryKey */id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 42 "C:\Users\Victor Lemaire\source\repos\JAQ_BackendDev\JAQ_BackendDev.Web\Views\Quiz\Questions.cshtml"
} 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<JAQ_BackendDev.Models.Question>> Html { get; private set; }
    }
}
#pragma warning restore 1591
