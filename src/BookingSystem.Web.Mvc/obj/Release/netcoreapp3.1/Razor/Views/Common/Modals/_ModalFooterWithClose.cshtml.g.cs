#pragma checksum "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Common\Modals\_ModalFooterWithClose.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef6b3ffe0d7138847d21be46559b838a50d9f063"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Common_Modals__ModalFooterWithClose), @"mvc.1.0.view", @"/Views/Common/Modals/_ModalFooterWithClose.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef6b3ffe0d7138847d21be46559b838a50d9f063", @"/Views/Common/Modals/_ModalFooterWithClose.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b92bd3c898a7223efde67b33c5a52b3cb4585955", @"/Views/_ViewImports.cshtml")]
    public class Views_Common_Modals__ModalFooterWithClose : BookingSystem.Web.Views.BookingSystemRazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"modal-footer\">\r\n    <button type=\"button\" class=\"btn btn-secondary close-button\" data-dismiss=\"modal\">");
#nullable restore
#line 2 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Common\Modals\_ModalFooterWithClose.cshtml"
                                                                                 Write(L("Close"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n</div>");
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
