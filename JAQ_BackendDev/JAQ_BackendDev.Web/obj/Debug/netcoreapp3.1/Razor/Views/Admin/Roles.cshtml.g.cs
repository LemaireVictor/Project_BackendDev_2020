#pragma checksum "C:\Users\Victor Lemaire\source\repos\JAQ_BackendDev\JAQ_BackendDev.Web\Views\Admin\Roles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a4509d0fecfadd360ed7a97ade629e3f9d2649d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Roles), @"mvc.1.0.view", @"/Views/Admin/Roles.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4509d0fecfadd360ed7a97ade629e3f9d2649d1", @"/Views/Admin/Roles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41327eabe561072ed9115b1743626b052c32fe9a", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Roles : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IdentityRole>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Victor Lemaire\source\repos\JAQ_BackendDev\JAQ_BackendDev.Web\Views\Admin\Roles.cshtml"
  
    ViewData["Title"] = "Roles";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Roles</h1>\r\n\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 12 "C:\Users\Victor Lemaire\source\repos\JAQ_BackendDev\JAQ_BackendDev.Web\Views\Admin\Roles.cshtml"
               Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 15 "C:\Users\Victor Lemaire\source\repos\JAQ_BackendDev\JAQ_BackendDev.Web\Views\Admin\Roles.cshtml"
               Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 21 "C:\Users\Victor Lemaire\source\repos\JAQ_BackendDev\JAQ_BackendDev.Web\Views\Admin\Roles.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 25 "C:\Users\Victor Lemaire\source\repos\JAQ_BackendDev\JAQ_BackendDev.Web\Views\Admin\Roles.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 28 "C:\Users\Victor Lemaire\source\repos\JAQ_BackendDev\JAQ_BackendDev.Web\Views\Admin\Roles.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 31 "C:\Users\Victor Lemaire\source\repos\JAQ_BackendDev\JAQ_BackendDev.Web\Views\Admin\Roles.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<IdentityRole>> Html { get; private set; }
    }
}
#pragma warning restore 1591
