#pragma checksum "D:\IT-career\Module 12 ИНТЕРНЕТ ПРОГРАМИРАНЕ\ProjectManagement-Problems\ProjectManagement\Views\Projects\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32a8d3d3693daa5c296ef4171d3d9244968a67e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Projects_Edit), @"mvc.1.0.view", @"/Views/Projects/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32a8d3d3693daa5c296ef4171d3d9244968a67e5", @"/Views/Projects/Edit.cshtml")]
    public class Views_Projects_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectManagement.ViewModels.Projects.EditVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\IT-career\Module 12 ИНТЕРНЕТ ПРОГРАМИРАНЕ\ProjectManagement-Problems\ProjectManagement\Views\Projects\Edit.cshtml"
  
    this.Layout = "/Views/Shared/_Site.cshtml";
    ViewData["title"] = "EDIT PROJECT";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<fieldset>\r\n    <legend>EDIT PROJECT</legend>\r\n    <form action=\"/Projects/Edit\" method=\"post\">\r\n        ");
#nullable restore
#line 10 "D:\IT-career\Module 12 ИНТЕРНЕТ ПРОГРАМИРАНЕ\ProjectManagement-Problems\ProjectManagement\Views\Projects\Edit.cshtml"
   Write(Html.HiddenFor(m => m.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 11 "D:\IT-career\Module 12 ИНТЕРНЕТ ПРОГРАМИРАНЕ\ProjectManagement-Problems\ProjectManagement\Views\Projects\Edit.cshtml"
   Write(Html.HiddenFor(m => m.OwnerId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"grid\">\r\n            <div class=\"row\">\r\n                <div class=\"col-1\">\r\n                    ");
#nullable restore
#line 15 "D:\IT-career\Module 12 ИНТЕРНЕТ ПРОГРАМИРАНЕ\ProjectManagement-Problems\ProjectManagement\Views\Projects\Edit.cshtml"
               Write(Html.LabelFor(m => m.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-2\">\r\n                    ");
#nullable restore
#line 18 "D:\IT-career\Module 12 ИНТЕРНЕТ ПРОГРАМИРАНЕ\ProjectManagement-Problems\ProjectManagement\Views\Projects\Edit.cshtml"
               Write(Html.TextBoxFor(m => m.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-2\">\r\n                    ");
#nullable restore
#line 21 "D:\IT-career\Module 12 ИНТЕРНЕТ ПРОГРАМИРАНЕ\ProjectManagement-Problems\ProjectManagement\Views\Projects\Edit.cshtml"
               Write(Html.ValidationMessageFor(m => m.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col-1\">\r\n                    ");
#nullable restore
#line 26 "D:\IT-career\Module 12 ИНТЕРНЕТ ПРОГРАМИРАНЕ\ProjectManagement-Problems\ProjectManagement\Views\Projects\Edit.cshtml"
               Write(Html.LabelFor(m => m.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-2\">\r\n                    ");
#nullable restore
#line 29 "D:\IT-career\Module 12 ИНТЕРНЕТ ПРОГРАМИРАНЕ\ProjectManagement-Problems\ProjectManagement\Views\Projects\Edit.cshtml"
               Write(Html.TextAreaFor(m => m.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-2\">\r\n                    ");
#nullable restore
#line 32 "D:\IT-career\Module 12 ИНТЕРНЕТ ПРОГРАМИРАНЕ\ProjectManagement-Problems\ProjectManagement\Views\Projects\Edit.cshtml"
               Write(Html.ValidationMessageFor(m => m.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col-3\">\r\n                    ");
#nullable restore
#line 37 "D:\IT-career\Module 12 ИНТЕРНЕТ ПРОГРАМИРАНЕ\ProjectManagement-Problems\ProjectManagement\Views\Projects\Edit.cshtml"
               Write(Html.ValidationMessage("summaryError"));

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
                    <a href=""/Projects/Index"" class=""right"">Back</a>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectManagement.ViewModels.Projects.EditVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
