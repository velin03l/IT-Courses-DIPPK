#pragma checksum "D:\My Documents\ppmgkk\IT-кариера\проекти\модул 12\ProjectManagement-Problems\ProjectManagement\Views\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8aee158ca33f5156cd404e5df0bbbaae11c8b308"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Index), @"mvc.1.0.view", @"/Views/Users/Index.cshtml")]
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
#line 2 "D:\My Documents\ppmgkk\IT-кариера\проекти\модул 12\ProjectManagement-Problems\ProjectManagement\Views\Users\Index.cshtml"
using ProjectManagement.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8aee158ca33f5156cd404e5df0bbbaae11c8b308", @"/Views/Users/Index.cshtml")]
    public class Views_Users_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectManagement.ViewModels.Users.IndexVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\My Documents\ppmgkk\IT-кариера\проекти\модул 12\ProjectManagement-Problems\ProjectManagement\Views\Users\Index.cshtml"
  
    this.Layout = "/Views/Shared/_Site.cshtml";
    ViewData["title"] = "USERS";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"grid\">\r\n    <div class=\"row\">\r\n        <div class=\"col-1\">Username</div>\r\n        <div class=\"col-2\">First Name</div>\r\n        <div class=\"col-2\">Last Name</div>\r\n        <div class=\"col-2\"></div>\r\n    </div>\r\n");
#nullable restore
#line 15 "D:\My Documents\ppmgkk\IT-кариера\проекти\модул 12\ProjectManagement-Problems\ProjectManagement\Views\Users\Index.cshtml"
 foreach(User item in Model.Items)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-1\">");
#nullable restore
#line 18 "D:\My Documents\ppmgkk\IT-кариера\проекти\модул 12\ProjectManagement-Problems\ProjectManagement\Views\Users\Index.cshtml"
                  Write(item.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <div class=\"col-2\">");
#nullable restore
#line 19 "D:\My Documents\ppmgkk\IT-кариера\проекти\модул 12\ProjectManagement-Problems\ProjectManagement\Views\Users\Index.cshtml"
                  Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <div class=\"col-2\">");
#nullable restore
#line 20 "D:\My Documents\ppmgkk\IT-кариера\проекти\модул 12\ProjectManagement-Problems\ProjectManagement\Views\Users\Index.cshtml"
                  Write(item.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <div class=\"col-2\">\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 629, "\"", 659, 2);
            WriteAttributeValue("", 636, "/Users/Edit?id=", 636, 15, true);
#nullable restore
#line 22 "D:\My Documents\ppmgkk\IT-кариера\проекти\модул 12\ProjectManagement-Problems\ProjectManagement\Views\Users\Index.cshtml"
WriteAttributeValue("", 651, item.Id, 651, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">edit</a>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 681, "\"", 713, 2);
            WriteAttributeValue("", 688, "/Users/Delete?id=", 688, 17, true);
#nullable restore
#line 23 "D:\My Documents\ppmgkk\IT-кариера\проекти\модул 12\ProjectManagement-Problems\ProjectManagement\Views\Users\Index.cshtml"
WriteAttributeValue("", 705, item.Id, 705, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n           onclick=\"return confirm(\'Delete Record?\');\">delete</a>\r\n        <input type=\"submit\" class=\"right\" value=\"Save\" />\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 28 "D:\My Documents\ppmgkk\IT-кариера\проекти\модул 12\ProjectManagement-Problems\ProjectManagement\Views\Users\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectManagement.ViewModels.Users.IndexVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
