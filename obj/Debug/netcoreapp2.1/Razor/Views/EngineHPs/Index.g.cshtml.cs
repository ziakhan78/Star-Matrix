#pragma checksum "D:\WIP\StarMatrix\StarMatrix\Views\EngineHPs\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c8d56f5875587434223f40dc14d5cf727786f80"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EngineHPs_Index), @"mvc.1.0.view", @"/Views/EngineHPs/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/EngineHPs/Index.cshtml", typeof(AspNetCore.Views_EngineHPs_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c8d56f5875587434223f40dc14d5cf727786f80", @"/Views/EngineHPs/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7e9e0d65130fd7e1e1d6db1636cdf53067b16e5", @"/Views/_ViewImports.cshtml")]
    public class Views_EngineHPs_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<StarMatrix.Models.EngineHP>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\WIP\StarMatrix\StarMatrix\Views\EngineHPs\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(143, 267, true);
            WriteLiteral(@"
<div class=""row"">
    <div class=""box col-md-12"">
        <div class=""box-inner"">
            <div class=""box-header well"" data-original-title="""">
                <h2>Engine HP</h2>
                <div style=""float:right;"">   <a class=""btn btn-success btn-sm""");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 410, "\"", 451, 1);
#line 13 "D:\WIP\StarMatrix\StarMatrix\Views\EngineHPs\Index.cshtml"
WriteAttributeValue("", 417, Url.Action("Create", "EngineHPs"), 417, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(452, 331, true);
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
            BeginContext(784, 48, false);
#line 21 "D:\WIP\StarMatrix\StarMatrix\Views\EngineHPs\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.EngineHPName));

#line default
#line hidden
            EndContext();
            BeginContext(832, 166, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th></th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
            EndContext();
#line 27 "D:\WIP\StarMatrix\StarMatrix\Views\EngineHPs\Index.cshtml"
                           int rowno = 0;

#line default
#line hidden
            BeginContext(1042, 24, true);
            WriteLiteral("                        ");
            EndContext();
#line 28 "D:\WIP\StarMatrix\StarMatrix\Views\EngineHPs\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
            BeginContext(1123, 108, true);
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(1233, 10, false);
#line 32 "D:\WIP\StarMatrix\StarMatrix\Views\EngineHPs\Index.cshtml"
                                Write(rowno += 1);

#line default
#line hidden
            EndContext();
            BeginContext(1244, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(1360, 47, false);
#line 35 "D:\WIP\StarMatrix\StarMatrix\Views\EngineHPs\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.EngineHPName));

#line default
#line hidden
            EndContext();
            BeginContext(1407, 148, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    <a class=\"btn btn-primary btn-sm\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1555, "\"", 1623, 1);
#line 38 "D:\WIP\StarMatrix\StarMatrix\Views\EngineHPs\Index.cshtml"
WriteAttributeValue("", 1562, Url.Action("Edit", "EngineHPs", new { id = item.EngineHPId}), 1562, 61, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1624, 188, true);
            WriteLiteral("><i class=\"glyphicon glyphicon-edit\"></i> Edit</a>\r\n                                    <a class=\"btn btn-danger btn-sm\" onclick=\"return confirm(\'Are sure you want to delete this item?\');\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1812, "\"", 1892, 1);
#line 39 "D:\WIP\StarMatrix\StarMatrix\Views\EngineHPs\Index.cshtml"
WriteAttributeValue("", 1819, Url.Action("DeleteConfirmed", "EngineHPs", new { id = item.EngineHPId }), 1819, 73, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1893, 129, true);
            WriteLiteral("><i class=\"glyphicon glyphicon-trash\"></i> Delete</a>\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 42 "D:\WIP\StarMatrix\StarMatrix\Views\EngineHPs\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(2049, 112, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<StarMatrix.Models.EngineHP>> Html { get; private set; }
    }
}
#pragma warning restore 1591