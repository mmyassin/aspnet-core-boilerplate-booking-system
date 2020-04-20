#pragma checksum "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Tenants\_CreateModal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef2669b9ba9bd8bca18dbf5ab3d0279dec5414d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tenants__CreateModal), @"mvc.1.0.view", @"/Views/Tenants/_CreateModal.cshtml")]
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
#line 1 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Tenants\_CreateModal.cshtml"
using Abp.Authorization.Users;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Tenants\_CreateModal.cshtml"
using Abp.MultiTenancy;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Tenants\_CreateModal.cshtml"
using BookingSystem.MultiTenancy;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Tenants\_CreateModal.cshtml"
using BookingSystem.Web.Models.Common.Modals;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef2669b9ba9bd8bca18dbf5ab3d0279dec5414d4", @"/Views/Tenants/_CreateModal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b92bd3c898a7223efde67b33c5a52b3cb4585955", @"/Views/_ViewImports.cshtml")]
    public class Views_Tenants__CreateModal : BookingSystem.Web.Views.BookingSystemRazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("tenantCreateForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Tenants\_CreateModal.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"modal fade\" id=\"TenantCreateModal\" tabindex=\"-1\" role=\"dialog\" aria-labelledby=\"TenantCreateModalLabel\" data-backdrop=\"static\">\r\n    <div class=\"modal-dialog modal-lg\" role=\"document\">\r\n        <div class=\"modal-content\">\r\n            ");
#nullable restore
#line 11 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Tenants\_CreateModal.cshtml"
       Write(await Html.PartialAsync("~/Views/Shared/Modals/_ModalHeader.cshtml", new ModalHeaderViewModel(L("CreateNewTenant"))));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef2669b9ba9bd8bca18dbf5ab3d0279dec5414d45879", async() => {
                WriteLiteral("\r\n                <div class=\"modal-body\">\r\n                    <div class=\"form-group row required\">\r\n                        <label class=\"col-md-3 col-form-label\">");
#nullable restore
#line 15 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Tenants\_CreateModal.cshtml"
                                                          Write(L("TenancyName"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                        <div class=\"col-md-9\">\r\n                            <input type=\"text\" name=\"TenancyName\" class=\"form-control\" required");
                BeginWriteAttribute("maxlength", " maxlength=\"", 946, "\"", 993, 1);
#nullable restore
#line 17 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Tenants\_CreateModal.cshtml"
WriteAttributeValue("", 958, AbpTenantBase.MaxTenancyNameLength, 958, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" minlength=\"2\">\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"form-group row required\">\r\n                        <label class=\"col-md-3 col-form-label\">");
#nullable restore
#line 21 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Tenants\_CreateModal.cshtml"
                                                          Write(L("Name"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                        <div class=\"col-md-9\">\r\n                            <input type=\"text\" name=\"Name\" class=\"form-control\" required");
                BeginWriteAttribute("maxlength", " maxlength=\"", 1349, "\"", 1382, 1);
#nullable restore
#line 23 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Tenants\_CreateModal.cshtml"
WriteAttributeValue("", 1361, Tenant.MaxNameLength, 1361, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"form-group row required\">\r\n                        <label class=\"col-md-3 col-form-label\">");
#nullable restore
#line 27 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Tenants\_CreateModal.cshtml"
                                                          Write(L("AdminEmailAddress"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                        <div class=\"col-md-9\">\r\n                            <input type=\"email\" name=\"AdminEmailAddress\" class=\"form-control\" required");
                BeginWriteAttribute("maxlength", " maxlength=\"", 1751, "\"", 1797, 1);
#nullable restore
#line 29 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Tenants\_CreateModal.cshtml"
WriteAttributeValue("", 1763, AbpUserBase.MaxEmailAddressLength, 1763, 34, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"form-group row\">\r\n                        <label class=\"col-md-3 col-form-label\">");
#nullable restore
#line 33 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Tenants\_CreateModal.cshtml"
                                                          Write(L("DatabaseConnectionString"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" (");
#nullable restore
#line 33 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Tenants\_CreateModal.cshtml"
                                                                                          Write(L("Optional"));

#line default
#line hidden
#nullable disable
                WriteLiteral(")</label>\r\n                        <div class=\"col-md-9\">\r\n                            <input type=\"text\" name=\"ConnectionString\" class=\"form-control\"");
                BeginWriteAttribute("maxlength", " maxlength=\"", 2170, "\"", 2222, 1);
#nullable restore
#line 35 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Tenants\_CreateModal.cshtml"
WriteAttributeValue("", 2182, AbpTenantBase.MaxConnectionStringLength, 2182, 40, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"form-group row\">\r\n                        <label class=\"col-md-3 col-form-label\" for=\"CreateTenantIsActive\">");
#nullable restore
#line 39 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Tenants\_CreateModal.cshtml"
                                                                                     Write(L("IsActive"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label>
                        <div class=""col-md-9"">
                            <input id=""CreateTenantIsActive"" type=""checkbox"" name=""IsActive"" value=""true"" checked />
                        </div>
                    </div>
                    <div class=""form-group row"">
                        <div class=""col-md-3"">
                        </div>
                        <div class=""col-md-9"">
                            <p>");
#nullable restore
#line 48 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Tenants\_CreateModal.cshtml"
                          Write(L("DefaultPasswordIs", BookingSystem.Authorization.Users.User.DefaultPassword));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                ");
#nullable restore
#line 52 "D:\Projects\repos\BookingSystem\aspnet-core\src\BookingSystem.Web.Mvc\Views\Tenants\_CreateModal.cshtml"
           Write(await Html.PartialAsync("~/Views/Shared/Modals/_ModalFooterWithSaveAndCancel.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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