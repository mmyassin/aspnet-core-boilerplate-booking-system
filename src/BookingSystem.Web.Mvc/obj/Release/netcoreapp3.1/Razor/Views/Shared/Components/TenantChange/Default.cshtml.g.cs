#pragma checksum "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Shared\Components\TenantChange\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1435f6102d1fed7d0fefd5ee135ee1acfd0bbf64"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_TenantChange_Default), @"mvc.1.0.view", @"/Views/Shared/Components/TenantChange/Default.cshtml")]
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
#line 1 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\_ViewImports.cshtml"
using Abp.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Shared\Components\TenantChange\Default.cshtml"
using BookingSystem.Web.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1435f6102d1fed7d0fefd5ee135ee1acfd0bbf64", @"/Views/Shared/Components/TenantChange/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09d9865d15f5ae9bd37882112c97727d84c9c534", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_TenantChange_Default : BookingSystem.Web.Views.BookingSystemRazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Shared\Components\TenantChange\Default.cshtml"
  
    WebResourceManager.AddScript(ApplicationPath + "view-resources/Views/Shared/Components/TenantChange/Default.js");

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"text-center tenant-change-component\">\n    <span>\n        ");
#nullable restore
#line 8 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Shared\Components\TenantChange\Default.cshtml"
   Write(L("CurrentTenant"));

#line default
#line hidden
#nullable disable
            WriteLiteral(":\n\n");
#nullable restore
#line 10 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Shared\Components\TenantChange\Default.cshtml"
         if (Model.Tenant != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span");
            BeginWriteAttribute("title", " title=\"", 358, "\"", 384, 1);
#nullable restore
#line 12 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Shared\Components\TenantChange\Default.cshtml"
WriteAttributeValue("", 366, Model.Tenant.Name, 366, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><strong>");
#nullable restore
#line 12 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Shared\Components\TenantChange\Default.cshtml"
                                                Write(Model.Tenant.TenancyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></span>\n");
#nullable restore
#line 13 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Shared\Components\TenantChange\Default.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span>");
#nullable restore
#line 16 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Shared\Components\TenantChange\Default.cshtml"
             Write(L("NotSelected"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n");
#nullable restore
#line 17 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Shared\Components\TenantChange\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        (<a href=\"javascript:;\" data-toggle=\"modal\" data-target=\"#TenantChangeModal\">");
#nullable restore
#line 19 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Shared\Components\TenantChange\Default.cshtml"
                                                                                Write(L("Change"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>)
    </span>
</div>
<div class=""modal fade"" id=""TenantChangeModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""UserCreateModalLabel"" data-backdrop=""static"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
        </div>
    </div>
</div>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IWebResourceManager WebResourceManager { get; private set; }
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
