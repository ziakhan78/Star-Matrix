#pragma checksum "D:\WIP\StarMatrix\StarMatrix\Views\ClassTypes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e64d570c06bb08429e863d67190c58a0e3aee41b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ClassTypes_Index), @"mvc.1.0.view", @"/Views/ClassTypes/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ClassTypes/Index.cshtml", typeof(AspNetCore.Views_ClassTypes_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e64d570c06bb08429e863d67190c58a0e3aee41b", @"/Views/ClassTypes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7e9e0d65130fd7e1e1d6db1636cdf53067b16e5", @"/Views/_ViewImports.cshtml")]
    public class Views_ClassTypes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<StarMatrix.Models.ClassType>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\WIP\StarMatrix\StarMatrix\Views\ClassTypes\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(144, 263, true);
            WriteLiteral(@"
<div class=""row"">
    <div class=""box col-md-12"">
        <div class=""box-inner"">
            <div class=""box-header well"" data-original-title="""">
                <h2>Class</h2>
                <div style=""float:right;"">   <a class=""btn btn-success btn-sm""");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 407, "\"", 449, 1);
#line 13 "D:\WIP\StarMatrix\StarMatrix\Views\ClassTypes\Index.cshtml"
WriteAttributeValue("", 414, Url.Action("Create", "ClassTypes"), 414, 35, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(450, 331, true);
            WriteLiteral(@"><i class=""glyphicon glyphicon-plus-sign""></i> Add New</a></div>
            </div>
            <div class=""box-content"">
                <table class=""table"">
                    <thead>
                        <tr>
                            <th>Sr.</th>
                            <th>
                                ");
            EndContext();
            BeginContext(782, 49, false);
#line 21 "D:\WIP\StarMatrix\StarMatrix\Views\ClassTypes\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.ClassTypeName));

#line default
#line hidden
            EndContext();
            BeginContext(831, 166, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th></th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
            EndContext();
#line 27 "D:\WIP\StarMatrix\StarMatrix\Views\ClassTypes\Index.cshtml"
                           int rowno = 0;

#line default
#line hidden
            BeginContext(1041, 24, true);
            WriteLiteral("                        ");
            EndContext();
#line 28 "D:\WIP\StarMatrix\StarMatrix\Views\ClassTypes\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
            BeginContext(1122, 108, true);
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(1232, 10, false);
#line 32 "D:\WIP\StarMatrix\StarMatrix\Views\ClassTypes\Index.cshtml"
                                Write(rowno += 1);

#line default
#line hidden
            EndContext();
            BeginContext(1243, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(1359, 48, false);
#line 35 "D:\WIP\StarMatrix\StarMatrix\Views\ClassTypes\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.ClassTypeName));

#line default
#line hidden
            EndContext();
            BeginContext(1407, 148, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    <a class=\"btn btn-primary btn-sm\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1555, "\"", 1625, 1);
#line 38 "D:\WIP\StarMatrix\StarMatrix\Views\ClassTypes\Index.cshtml"
WriteAttributeValue("", 1562, Url.Action("Edit", "ClassTypes", new { id = item.ClassTypeId}), 1562, 63, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1626, 188, true);
            WriteLiteral("><i class=\"glyphicon glyphicon-edit\"></i> Edit</a>\r\n                                    <a class=\"btn btn-danger btn-sm\" onclick=\"return confirm(\'Are sure you want to delete this item?\');\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1814, "\"", 1896, 1);
#line 39 "D:\WIP\StarMatrix\StarMatrix\Views\ClassTypes\Index.cshtml"
WriteAttributeValue("", 1821, Url.Action("DeleteConfirmed", "ClassTypes", new { id = item.ClassTypeId }), 1821, 75, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1897, 129, true);
            WriteLiteral("><i class=\"glyphicon glyphicon-trash\"></i> Delete</a>\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 42 "D:\WIP\StarMatrix\StarMatrix\Views\ClassTypes\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(2053, 112, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<StarMatrix.Models.ClassType>> Html { get; private set; }
    }
}
#pragma warning restore 1591
