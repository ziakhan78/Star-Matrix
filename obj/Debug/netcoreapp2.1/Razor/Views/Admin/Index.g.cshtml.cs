#pragma checksum "D:\WIP\StarMatrix\StarMatrix\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10d846b8f74e268eecf6787b0c3b79f1344f6ca2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Index.cshtml", typeof(AspNetCore.Views_Admin_Index))]
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
#line 1 "D:\WIP\StarMatrix\StarMatrix\Views\_ViewImports.cshtml"
using StarMatrix;

#line default
#line hidden
#line 2 "D:\WIP\StarMatrix\StarMatrix\Views\_ViewImports.cshtml"
using StarMatrix.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10d846b8f74e268eecf6787b0c3b79f1344f6ca2", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7e9e0d65130fd7e1e1d6db1636cdf53067b16e5", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<StarMatrix.Models.Admin>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\WIP\StarMatrix\StarMatrix\Views\Admin\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(140, 269, true);
            WriteLiteral(@"
<div class=""row"">
    <div class=""box col-md-12"">
        <div class=""box-inner"">
            <div class=""box-header well"" data-original-title="""">
                <h2>Admin Users</h2>
                <div style=""float:right;"">   <a class=""btn btn-success btn-sm""");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 409, "\"", 446, 1);
#line 13 "D:\WIP\StarMatrix\StarMatrix\Views\Admin\Index.cshtml"
WriteAttributeValue("", 416, Url.Action("Create", "Admin"), 416, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(447, 127, true);
            WriteLiteral("><i class=\"glyphicon glyphicon-plus-sign\"></i> Add New</a></div>\r\n            </div>\r\n            <div class=\"box-content\">\r\n\r\n");
            EndContext();
            BeginContext(680, 206, true);
            WriteLiteral("                <table class=\"table\">\r\n                    <thead>\r\n                        <tr>\r\n                            <th>Sr.</th>\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(887, 44, false);
#line 25 "D:\WIP\StarMatrix\StarMatrix\Views\Admin\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Username));

#line default
#line hidden
            EndContext();
            BeginContext(931, 103, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(1035, 41, false);
#line 28 "D:\WIP\StarMatrix\StarMatrix\Views\Admin\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1076, 103, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(1180, 44, false);
#line 31 "D:\WIP\StarMatrix\StarMatrix\Views\Admin\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Password));

#line default
#line hidden
            EndContext();
            BeginContext(1224, 103, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(1328, 41, false);
#line 34 "D:\WIP\StarMatrix\StarMatrix\Views\Admin\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Roles));

#line default
#line hidden
            EndContext();
            BeginContext(1369, 103, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(1473, 42, false);
#line 37 "D:\WIP\StarMatrix\StarMatrix\Views\Admin\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1515, 37, true);
            WriteLiteral("\r\n                            </th>\r\n");
            EndContext();
            BeginContext(1854, 135, true);
            WriteLiteral("                            <th>Action</th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
            EndContext();
#line 49 "D:\WIP\StarMatrix\StarMatrix\Views\Admin\Index.cshtml"
                          int rowno = 0;

#line default
#line hidden
            BeginContext(2032, 24, true);
            WriteLiteral("                        ");
            EndContext();
#line 50 "D:\WIP\StarMatrix\StarMatrix\Views\Admin\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
            BeginContext(2113, 119, true);
            WriteLiteral("                            <tr>\r\n                                <td width=\"15\">\r\n                                    ");
            EndContext();
            BeginContext(2234, 10, false);
#line 54 "D:\WIP\StarMatrix\StarMatrix\Views\Admin\Index.cshtml"
                                Write(rowno += 1);

#line default
#line hidden
            EndContext();
            BeginContext(2245, 116, true);
            WriteLiteral(".\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(2362, 43, false);
#line 57 "D:\WIP\StarMatrix\StarMatrix\Views\Admin\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Username));

#line default
#line hidden
            EndContext();
            BeginContext(2405, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(2521, 40, false);
#line 60 "D:\WIP\StarMatrix\StarMatrix\Views\Admin\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(2561, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(2677, 43, false);
#line 63 "D:\WIP\StarMatrix\StarMatrix\Views\Admin\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Password));

#line default
#line hidden
            EndContext();
            BeginContext(2720, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(2836, 40, false);
#line 66 "D:\WIP\StarMatrix\StarMatrix\Views\Admin\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Roles));

#line default
#line hidden
            EndContext();
            BeginContext(2876, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(2992, 41, false);
#line 69 "D:\WIP\StarMatrix\StarMatrix\Views\Admin\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
            EndContext();
            BeginContext(3033, 41, true);
            WriteLiteral("\r\n                                </td>\r\n");
            EndContext();
            BeginContext(3318, 107, true);
            WriteLiteral("                                <td>\r\n                                    <a class=\"btn btn-primary btn-sm\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3425, "\"", 3481, 1);
#line 78 "D:\WIP\StarMatrix\StarMatrix\Views\Admin\Index.cshtml"
WriteAttributeValue("", 3432, Url.Action("Edit", "Admin", new { id = item.Id}), 3432, 49, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3482, 188, true);
            WriteLiteral("><i class=\"glyphicon glyphicon-edit\"></i> Edit</a>\r\n                                    <a class=\"btn btn-danger btn-sm\" onclick=\"return confirm(\'Are sure you want to delete this item?\');\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3670, "\"", 3738, 1);
#line 79 "D:\WIP\StarMatrix\StarMatrix\Views\Admin\Index.cshtml"
WriteAttributeValue("", 3677, Url.Action("DeleteConfirmed", "Admin", new { id = item.Id }), 3677, 61, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3739, 129, true);
            WriteLiteral("><i class=\"glyphicon glyphicon-trash\"></i> Delete</a>\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 82 "D:\WIP\StarMatrix\StarMatrix\Views\Admin\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(3895, 114, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<StarMatrix.Models.Admin>> Html { get; private set; }
    }
}
#pragma warning restore 1591