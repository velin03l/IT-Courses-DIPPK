#pragma checksum "D:\IT-career\Module 12 ИНТЕРНЕТ ПРОГРАМИРАНЕ\ProjectManagement-Problems\ProjectManagement\Views\Users\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96b5869143a5680ccaace13fdd2a0a12d2151ee6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Create), @"mvc.1.0.view", @"/Views/Users/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96b5869143a5680ccaace13fdd2a0a12d2151ee6", @"/Views/Users/Create.cshtml")]
    public class Views_Users_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectManagement.ViewModels.Users.CreateVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\IT-career\Module 12 ИНТЕРНЕТ ПРОГРАМИРАНЕ\ProjectManagement-Problems\ProjectManagement\Views\Users\Create.cshtml"
  
    this.Layout = "/Views/Shared/_Site.cshtml";
    ViewData["title"] = "CREATE USERS";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<fieldset>\r\n    <legend>CREATE USER</legend>\r\n    <form action=\"/Users/Create\" method=\"post\">\r\n        <div class=\"grid\">\r\n            <div class=\"row\">\r\n                <div class=\"col-1\">\r\n                    ");
#nullable restore
#line 13 "D:\IT-career\Module 12 ИНТЕРНЕТ ПРОГРАМИРАНЕ\ProjectManagement-Problems\ProjectManagement\Views\Users\Create.cshtml"
               Write(Html.LabelFor(m => m.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-2\">\r\n                    ");
#nullable restore
#line 16 "D:\IT-career\Module 12 ИНТЕРНЕТ ПРОГРАМИРАНЕ\ProjectManagement-Problems\ProjectManagement\Views\Users\Create.cshtml"
               Write(Html.TextBoxFor(m => m.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-2\">\r\n                    ");
#nullable restore
#line 19 "D:\IT-career\Module 12 ИНТЕРНЕТ ПРОГРАМИРАНЕ\ProjectManagement-Problems\ProjectManagement\Views\Users\Create.cshtml"
               Write(Html.ValidationMessageFor(m => m.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col-1\">\r\n                    ");
#nullable restore
#line 24 "D:\IT-career\Module 12 ИНТЕРНЕТ ПРОГРАМИРАНЕ\ProjectManagement-Problems\ProjectManagement\Views\Users\Create.cshtml"
               Write(Html.LabelFor(m => m.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-2\">\r\n                    ");
#nullable restore
#line 27 "D:\IT-career\Module 12 ИНТЕРНЕТ ПРОГРАМИРАНЕ\ProjectManagement-Problems\ProjectManagement\Views\Users\Create.cshtml"
               Write(Html.TextBoxFor(m => m.Password, new { @class = "form-control", @type = "password" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-2\">\r\n                    ");
#nullable restore
#line 30 "D:\IT-career\Module 12 ИНТЕРНЕТ ПРОГРАМИРАНЕ\ProjectManagement-Problems\ProjectManagement\Views\Users\Create.cshtml"
               Write(Html.ValidationMessageFor(m => m.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col-1\">\r\n                    ");
#nullable restore
#line 35 "D:\IT-career\Module 12 ИНТЕРНЕТ ПРОГРАМИРАНЕ\ProjectManagement-Problems\ProjectManagement\Views\Users\Create.cshtml"
               Write(Html.LabelFor(m => m.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-2\">\r\n                    ");
#nullable restore
#line 38 "D:\IT-career\Module 12 ИНТЕРНЕТ ПРОГРАМИРАНЕ\ProjectManagement-Problems\ProjectManagement\Views\Users\Create.cshtml"
               Write(Html.TextBoxFor(m => m.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-2\">\r\n                    ");
#nullable restore
#line 41 "D:\IT-career\Module 12 ИНТЕРНЕТ ПРОГРАМИРАНЕ\ProjectManagement-Problems\ProjectManagement\Views\Users\Create.cshtml"
               Write(Html.ValidationMessageFor(m => m.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col-1\">\r\n                    ");
#nullable restore
#line 46 "D:\IT-career\Module 12 ИНТЕРНЕТ ПРОГРАМИРАНЕ\ProjectManagement-Problems\ProjectManagement\Views\Users\Create.cshtml"
               Write(Html.LabelFor(m => m.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-2\">\r\n                    ");
#nullable restore
#line 49 "D:\IT-career\Module 12 ИНТЕРНЕТ ПРОГРАМИРАНЕ\ProjectManagement-Problems\ProjectManagement\Views\Users\Create.cshtml"
               Write(Html.TextBoxFor(m => m.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-2\">\r\n                    ");
#nullable restore
#line 52 "D:\IT-career\Module 12 ИНТЕРНЕТ ПРОГРАМИРАНЕ\ProjectManagement-Problems\ProjectManagement\Views\Users\Create.cshtml"
               Write(Html.ValidationMessageFor(m => m.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
            </div>
            <div class=""row"">
                <div class=""col-1""></div>
                <div class=""col-2"">
                    <input type=""submit"" class=""right"" value=""Save"" />
                    <a href=""/Users/Index"" class=""right"">Back</a>
                </div>
            </div>
        </div>
    </form>
</fieldset>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectManagement.ViewModels.Users.CreateVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
