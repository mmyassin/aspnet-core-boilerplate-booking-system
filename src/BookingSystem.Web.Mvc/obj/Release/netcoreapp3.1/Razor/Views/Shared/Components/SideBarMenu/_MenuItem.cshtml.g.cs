#pragma checksum "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Shared\Components\SideBarMenu\_MenuItem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0547380108833a3bdef428caaa90d4a8843a467d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_SideBarMenu__MenuItem), @"mvc.1.0.view", @"/Views/Shared/Components/SideBarMenu/_MenuItem.cshtml")]
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
#line 1 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Shared\Components\SideBarMenu\_MenuItem.cshtml"
using BookingSystem.Web.Views;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Shared\Components\SideBarMenu\_MenuItem.cshtml"
using BookingSystem.Web.Views.Shared.Components.SideBarMenu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Shared\Components\SideBarMenu\_MenuItem.cshtml"
using Abp.Application.Navigation;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0547380108833a3bdef428caaa90d4a8843a467d", @"/Views/Shared/Components/SideBarMenu/_MenuItem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b92bd3c898a7223efde67b33c5a52b3cb4585955", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_SideBarMenu__MenuItem : BookingSystem.Web.Views.BookingSystemRazorPage<Abp.Application.Navigation.UserMenuItem>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Shared\Components\SideBarMenu\_MenuItem.cshtml"
  
    var isActive = IsActiveMenuItem(Model, ViewBag.CurrentPageName);
    var subMenus = Model.Items.Where(x => x.IsVisible).OrderByCustom().ToList();
    var hasSubMenus = subMenus.Any();

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Shared\Components\SideBarMenu\_MenuItem.cshtml"
 if (!hasSubMenus)
{
    var linkUrl = CalculateMenuUrl(Model.Url);
    var linkClasses = $"nav-link {(isActive ? "active" : null)}";
    var linkTarget = !string.IsNullOrEmpty(Model.Target) ? Html.Raw($" target=\"{Model.Target}\"") : null;


#line default
#line hidden
#nullable disable
            WriteLiteral("    <li class=\"nav-item\">\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 1293, "\"", 1308, 1);
#nullable restore
#line 39 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Shared\Components\SideBarMenu\_MenuItem.cshtml"
WriteAttributeValue("", 1300, linkUrl, 1300, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 1309, "\"", 1329, 1);
#nullable restore
#line 39 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Shared\Components\SideBarMenu\_MenuItem.cshtml"
WriteAttributeValue("", 1317, linkClasses, 1317, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 39 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Shared\Components\SideBarMenu\_MenuItem.cshtml"
                                           Write(linkTarget);

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n");
#nullable restore
#line 40 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Shared\Components\SideBarMenu\_MenuItem.cshtml"
             if (!string.IsNullOrEmpty(Model.Icon))
            {
                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <i");
            BeginWriteAttribute("class", " class=\"", 1459, "\"", 1500, 2);
            WriteAttributeValue("", 1467, "nav-icon", 1467, 8, true);
#nullable restore
#line 43 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Shared\Components\SideBarMenu\_MenuItem.cshtml"
WriteAttributeValue(" ", 1475, Url.Content(Model.Icon), 1476, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                ");
#nullable restore
#line 44 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Shared\Components\SideBarMenu\_MenuItem.cshtml"
                       
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>");
#nullable restore
#line 46 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Shared\Components\SideBarMenu\_MenuItem.cshtml"
          Write(Model.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </a>\r\n    </li>\r\n");
#nullable restore
#line 49 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Shared\Components\SideBarMenu\_MenuItem.cshtml"
}
else
{
    var navitemClasses = $"nav-item {(hasSubMenus ? "has-treeview" : "")} {(isActive ? "menu-open" : "")}";
    navitemClasses = !string.IsNullOrEmpty(navitemClasses?.Trim()) ? navitemClasses : null;
    var linkClasses = $"nav-link {(isActive ? "active" : null)}";


#line default
#line hidden
#nullable disable
            WriteLiteral("    <li");
            BeginWriteAttribute("class", " class=\"", 1902, "\"", 1925, 1);
#nullable restore
#line 56 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Shared\Components\SideBarMenu\_MenuItem.cshtml"
WriteAttributeValue("", 1910, navitemClasses, 1910, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <a href=\"javascript:;\"");
            BeginWriteAttribute("class", " class=\"", 1959, "\"", 1979, 1);
#nullable restore
#line 57 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Shared\Components\SideBarMenu\_MenuItem.cshtml"
WriteAttributeValue("", 1967, linkClasses, 1967, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 58 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Shared\Components\SideBarMenu\_MenuItem.cshtml"
             if (!string.IsNullOrEmpty(Model.Icon))
            {
                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <i");
            BeginWriteAttribute("class", " class=\"", 2097, "\"", 2138, 2);
            WriteAttributeValue("", 2105, "nav-icon", 2105, 8, true);
#nullable restore
#line 61 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Shared\Components\SideBarMenu\_MenuItem.cshtml"
WriteAttributeValue(" ", 2113, Url.Content(Model.Icon), 2114, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                ");
#nullable restore
#line 62 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Shared\Components\SideBarMenu\_MenuItem.cshtml"
                       
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>\r\n                ");
#nullable restore
#line 65 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Shared\Components\SideBarMenu\_MenuItem.cshtml"
           Write(Model.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 66 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Shared\Components\SideBarMenu\_MenuItem.cshtml"
                 if (LanguageManager.CurrentLanguage.IsRightToLeft)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <i class=\"fas fa-angle-right right\"></i>\r\n");
#nullable restore
#line 69 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Shared\Components\SideBarMenu\_MenuItem.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <i class=\"fas fa-angle-left right\"></i>\r\n");
#nullable restore
#line 73 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Shared\Components\SideBarMenu\_MenuItem.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </p>\r\n        </a>\r\n");
#nullable restore
#line 76 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Shared\Components\SideBarMenu\_MenuItem.cshtml"
         if (hasSubMenus)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <ul class=\"nav nav-treeview\">\r\n");
#nullable restore
#line 79 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Shared\Components\SideBarMenu\_MenuItem.cshtml"
                 foreach (var subMenu in subMenus)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Shared\Components\SideBarMenu\_MenuItem.cshtml"
               Write(await Html.PartialAsync("Components/SideBarMenu/_MenuItem", subMenu));

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Shared\Components\SideBarMenu\_MenuItem.cshtml"
                                                                                         
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n");
#nullable restore
#line 84 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Shared\Components\SideBarMenu\_MenuItem.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </li>\r\n");
#nullable restore
#line 86 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Shared\Components\SideBarMenu\_MenuItem.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Shared\Components\SideBarMenu\_MenuItem.cshtml"
            
    static bool IsActiveMenuItem(UserMenuItem menuItem, string pageName)
    {
        if (string.IsNullOrWhiteSpace(pageName))
            return false;

        return pageName.Equals(menuItem.Name, StringComparison.InvariantCultureIgnoreCase)
            || menuItem.Items.Any(cn => IsActiveMenuItem(cn, pageName));
    }

    string CalculateMenuUrl(string url)
    {
        if (string.IsNullOrEmpty(url))
            return ApplicationPath;

        if (UrlChecker.IsRooted(url))
            return url;

        return ApplicationPath + url;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ILanguageManager LanguageManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Abp.Application.Navigation.UserMenuItem> Html { get; private set; }
    }
}
#pragma warning restore 1591
