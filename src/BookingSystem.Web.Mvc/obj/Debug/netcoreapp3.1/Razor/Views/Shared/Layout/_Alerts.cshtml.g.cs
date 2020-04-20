#pragma checksum "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Shared\Layout\_Alerts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "878887058f572187a47582793769c86c64517e2f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Layout__Alerts), @"mvc.1.0.view", @"/Views/Shared/Layout/_Alerts.cshtml")]
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
#line 1 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Shared\Layout\_Alerts.cshtml"
using Abp.Web.Mvc.Alerts;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"878887058f572187a47582793769c86c64517e2f", @"/Views/Shared/Layout/_Alerts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b92bd3c898a7223efde67b33c5a52b3cb4585955", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Layout__Alerts : BookingSystem.Web.Views.BookingSystemRazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Shared\Layout\_Alerts.cshtml"
 if (AlertManager.Alerts.Any())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container-fluid\">\r\n");
#nullable restore
#line 8 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Shared\Layout\_Alerts.cshtml"
         foreach (var alert in AlertManager.Alerts)
        {
            var alertClass = "alert-";
            var iconClass = "fa-";
            switch (alert.Type)
            {
                case AlertType.Success:
                    alertClass += "success";
                    iconClass += "check";
                    break;
                case AlertType.Danger:
                    alertClass += "danger";
                    iconClass += "ban";
                    break;
                case AlertType.Warning:
                    alertClass += "warning";
                    iconClass += "exclamation-triangle";
                    break;
                case AlertType.Info:
                    alertClass += "info";
                    iconClass += "info";
                    break;
            }


#line default
#line hidden
#nullable disable
            WriteLiteral("            <div");
            BeginWriteAttribute("class", " class=\"", 995, "\"", 1082, 6);
            WriteAttributeValue("", 1003, "alert", 1003, 5, true);
#nullable restore
#line 32 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Shared\Layout\_Alerts.cshtml"
WriteAttributeValue(" ", 1008, alertClass, 1009, 11, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Shared\Layout\_Alerts.cshtml"
WriteAttributeValue(" ", 1020, alert.Dismissible ? "alert-dismisable" : "", 1021, 46, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1067, "mt-3", 1068, 5, true);
            WriteAttributeValue(" ", 1072, "mr-1", 1073, 5, true);
            WriteAttributeValue(" ", 1077, "ml-1", 1078, 5, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 33 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Shared\Layout\_Alerts.cshtml"
                 if (alert.Dismissible)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-hidden=\"true\">×</button>\r\n");
#nullable restore
#line 36 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Shared\Layout\_Alerts.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h5>\r\n                    <i");
            BeginWriteAttribute("class", " class=\"", 1317, "\"", 1344, 3);
            WriteAttributeValue("", 1325, "icon", 1325, 4, true);
            WriteAttributeValue(" ", 1329, "fas", 1330, 4, true);
#nullable restore
#line 38 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Shared\Layout\_Alerts.cshtml"
WriteAttributeValue(" ", 1333, iconClass, 1334, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                    ");
#nullable restore
#line 39 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Shared\Layout\_Alerts.cshtml"
               Write(alert.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </h5>\r\n                ");
#nullable restore
#line 41 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Shared\Layout\_Alerts.cshtml"
           Write(alert.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 43 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Shared\Layout\_Alerts.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 45 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Shared\Layout\_Alerts.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IAlertManager AlertManager { get; private set; }
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