#pragma checksum "D:\Asp.net mvccrudupdate\Asp.netcrudchanges\Asp.netmvfinalupres\Asp.Net mvc crud\Views\Students\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8bc3f04f5f58853a45a7c09bad9bb52cdfbe363b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_Index), @"mvc.1.0.view", @"/Views/Students/Index.cshtml")]
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
#line 1 "D:\Asp.net mvccrudupdate\Asp.netcrudchanges\Asp.netmvfinalupres\Asp.Net mvc crud\Views\_ViewImports.cshtml"
using Asp.net_student;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Asp.net mvccrudupdate\Asp.netcrudchanges\Asp.netmvfinalupres\Asp.Net mvc crud\Views\_ViewImports.cshtml"
using Asp.net_student.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bc3f04f5f58853a45a7c09bad9bb52cdfbe363b", @"/Views/Students/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b916a39d23f8cf7c8396dc2665b89d865e23461d", @"/Views/_ViewImports.cshtml")]
    public class Views_Students_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Asp.net_student.Models.Student>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "D:\Asp.net mvccrudupdate\Asp.netcrudchanges\Asp.netmvfinalupres\Asp.Net mvc crud\Views\Students\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";
   

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8bc3f04f5f58853a45a7c09bad9bb52cdfbe363b3673", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <title>");
#nullable restore
#line 15 "D:\Asp.net mvccrudupdate\Asp.netcrudchanges\Asp.netmvfinalupres\Asp.Net mvc crud\Views\Students\Index.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - Students</title>\r\n");
                WriteLiteral("   \r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8bc3f04f5f58853a45a7c09bad9bb52cdfbe363b5091", async() => {
                WriteLiteral("\r\n\r\n    \r\n\r\n    <div class=\"btn\">\r\n        &nbsp;&nbsp;\r\n");
                WriteLiteral("\r\n");
#nullable restore
#line 39 "D:\Asp.net mvccrudupdate\Asp.netcrudchanges\Asp.netmvfinalupres\Asp.Net mvc crud\Views\Students\Index.cshtml"
         if (TempData["AlertMessage"] != null)
        {


#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"alert-alignings\">\r\n\r\n\r\n                <div class=\"alert alert-success alert-dismissible fade show alert-aligning\" role=\"alert\" style=\"\r\n    left: 900px;\r\n    bottom: 31px;\r\n\">\r\n                    <strong>success!</strong> ");
#nullable restore
#line 49 "D:\Asp.net mvccrudupdate\Asp.netcrudchanges\Asp.netmvfinalupres\Asp.Net mvc crud\Views\Students\Index.cshtml"
                                         Write(TempData["AlertMessage"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\r\n                        <span aria-hidden=\"true\">×</span>\r\n                    </button>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 55 "D:\Asp.net mvccrudupdate\Asp.netcrudchanges\Asp.netmvfinalupres\Asp.Net mvc crud\Views\Students\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 59 "D:\Asp.net mvccrudupdate\Asp.netcrudchanges\Asp.netmvfinalupres\Asp.Net mvc crud\Views\Students\Index.cshtml"
         using (
Html.BeginForm("Index", "Students", FormMethod.Post))
        {


#line default
#line hidden
#nullable disable
                WriteLiteral(@"            <strong class=""control-label"">Search by:</strong>
            <input class=""textboxforsearch"" id=""search"" type=""text"" name=""search"" placeholder=""Name,Gender,country,age""  />
            <button type=""submit""><i class=""fa fa-search"" style=""color:blue;width:70px""></i></button>");
#nullable restore
#line 65 "D:\Asp.net mvccrudupdate\Asp.netcrudchanges\Asp.netmvfinalupres\Asp.Net mvc crud\Views\Students\Index.cshtml"
                                                                                                     }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n    </div>\r\n    <div class=\"table-container\">\r\n        <table class=\"table \">\r\n            <thead class=\"thead-light\">\r\n                <tr>\r\n                    <th>\r\n                        ");
#nullable restore
#line 75 "D:\Asp.net mvccrudupdate\Asp.netcrudchanges\Asp.netmvfinalupres\Asp.Net mvc crud\Views\Students\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 78 "D:\Asp.net mvccrudupdate\Asp.netcrudchanges\Asp.netmvfinalupres\Asp.Net mvc crud\Views\Students\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Age));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 81 "D:\Asp.net mvccrudupdate\Asp.netcrudchanges\Asp.netmvfinalupres\Asp.Net mvc crud\Views\Students\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.DepartmentId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n\r\n                    <th>\r\n                        ");
#nullable restore
#line 85 "D:\Asp.net mvccrudupdate\Asp.netcrudchanges\Asp.netmvfinalupres\Asp.Net mvc crud\Views\Students\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 88 "D:\Asp.net mvccrudupdate\Asp.netcrudchanges\Asp.netmvfinalupres\Asp.Net mvc crud\Views\Students\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.country));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 91 "D:\Asp.net mvccrudupdate\Asp.netcrudchanges\Asp.netmvfinalupres\Asp.Net mvc crud\Views\Students\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 94 "D:\Asp.net mvccrudupdate\Asp.netcrudchanges\Asp.netmvfinalupres\Asp.Net mvc crud\Views\Students\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 97 "D:\Asp.net mvccrudupdate\Asp.netcrudchanges\Asp.netmvfinalupres\Asp.Net mvc crud\Views\Students\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.EnrollmentDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        Action\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n");
#nullable restore
#line 104 "D:\Asp.net mvccrudupdate\Asp.netcrudchanges\Asp.netmvfinalupres\Asp.Net mvc crud\Views\Students\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>\r\n\r\n                        ");
#nullable restore
#line 109 "D:\Asp.net mvccrudupdate\Asp.netcrudchanges\Asp.netmvfinalupres\Asp.Net mvc crud\Views\Students\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 112 "D:\Asp.net mvccrudupdate\Asp.netcrudchanges\Asp.netmvfinalupres\Asp.Net mvc crud\Views\Students\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Age));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 115 "D:\Asp.net mvccrudupdate\Asp.netcrudchanges\Asp.netmvfinalupres\Asp.Net mvc crud\Views\Students\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.DepartmentId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n\r\n                        ");
#nullable restore
#line 119 "D:\Asp.net mvccrudupdate\Asp.netcrudchanges\Asp.netmvfinalupres\Asp.Net mvc crud\Views\Students\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Phone));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n\r\n                    <td>\r\n                        ");
#nullable restore
#line 123 "D:\Asp.net mvccrudupdate\Asp.netcrudchanges\Asp.netmvfinalupres\Asp.Net mvc crud\Views\Students\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.country));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 126 "D:\Asp.net mvccrudupdate\Asp.netcrudchanges\Asp.netmvfinalupres\Asp.Net mvc crud\Views\Students\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 129 "D:\Asp.net mvccrudupdate\Asp.netcrudchanges\Asp.netmvfinalupres\Asp.Net mvc crud\Views\Students\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Gender));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n\r\n                        ");
#nullable restore
#line 133 "D:\Asp.net mvccrudupdate\Asp.netcrudchanges\Asp.netmvfinalupres\Asp.Net mvc crud\Views\Students\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.EnrollmentDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n\r\n                    <td class=\"btns\">\r\n                        \r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 4470, "\"", 4528, 1);
#nullable restore
#line 138 "D:\Asp.net mvccrudupdate\Asp.netcrudchanges\Asp.netmvfinalupres\Asp.Net mvc crud\Views\Students\Index.cshtml"
WriteAttributeValue("", 4477, Url.Action("Details","Students",new { id=item.Id}), 4477, 51, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-sm btn-primary\"><i class=\"fa fa-eye\"></i></a>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 4618, "\"", 4673, 1);
#nullable restore
#line 139 "D:\Asp.net mvccrudupdate\Asp.netcrudchanges\Asp.netmvfinalupres\Asp.Net mvc crud\Views\Students\Index.cshtml"
WriteAttributeValue("", 4625, Url.Action("Edit","Students",new { id=item.Id}), 4625, 48, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-sm btn-info\"><i class=\"fa fa-pencil-square\"></i></a>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 4770, "\"", 4827, 1);
#nullable restore
#line 140 "D:\Asp.net mvccrudupdate\Asp.netcrudchanges\Asp.netmvfinalupres\Asp.Net mvc crud\Views\Students\Index.cshtml"
WriteAttributeValue("", 4777, Url.Action("Delete","Students",new { id=item.Id}), 4777, 50, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-sm btn-danger\"><i class=\"fa fa-trash-o\"></i></a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 143 "D:\Asp.net mvccrudupdate\Asp.netcrudchanges\Asp.netmvfinalupres\Asp.Net mvc crud\Views\Students\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </table>\r\n        </div>\r\n        <div class=\"pagination\">\r\n\r\n            ");
#nullable restore
#line 149 "D:\Asp.net mvccrudupdate\Asp.netcrudchanges\Asp.netmvfinalupres\Asp.Net mvc crud\Views\Students\Index.cshtml"
       Write(await Html.PartialAsync("_Pagination", 5));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n        </div>\r\n        <script>\r\n            $(document).ready(function () {\r\n                $(\"#register\").hide();\r\n                $(\"#login\").hide();\r\n              \r\n            });\r\n        </script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Asp.net_student.Models.Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591
