#pragma checksum "D:\WIP\StarMatrix\StarMatrix\Views\ShipLocations\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4180fee8ed9bed635d79477b2385fe26634be3f9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShipLocations_Index), @"mvc.1.0.view", @"/Views/ShipLocations/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ShipLocations/Index.cshtml", typeof(AspNetCore.Views_ShipLocations_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4180fee8ed9bed635d79477b2385fe26634be3f9", @"/Views/ShipLocations/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7e9e0d65130fd7e1e1d6db1636cdf53067b16e5", @"/Views/_ViewImports.cshtml")]
    public class Views_ShipLocations_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<StarMatrix.Models.ShipLocation>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(52, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\WIP\StarMatrix\StarMatrix\Views\ShipLocations\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(147, 272, true);
            WriteLiteral(@"
<div class=""row"">
    <div class=""box col-md-12"">
        <div class=""box-inner"">
            <div class=""box-header well"" data-original-title="""">
                <h2>Ship Locations</h2>
                <div style=""float:right;"">   <a class=""btn btn-success btn-sm""");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 419, "\"", 464, 1);
#line 13 "D:\WIP\StarMatrix\StarMatrix\Views\ShipLocations\Index.cshtml"
WriteAttributeValue("", 426, Url.Action("Create", "ShipLocations"), 426, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(465, 331, true);
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
            BeginContext(797, 40, false);
#line 21 "D:\WIP\StarMatrix\StarMatrix\Views\ShipLocations\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Tugs));

#line default
#line hidden
            EndContext();
            BeginContext(837, 103, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(941, 48, false);
#line 24 "D:\WIP\StarMatrix\StarMatrix\Views\ShipLocations\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.BollardPulls));

#line default
#line hidden
            EndContext();
            BeginContext(989, 103, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(1093, 45, false);
#line 27 "D:\WIP\StarMatrix\StarMatrix\Views\ShipLocations\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.EngineHPs));

#line default
#line hidden
            EndContext();
            BeginContext(1138, 103, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(1242, 46, false);
#line 30 "D:\WIP\StarMatrix\StarMatrix\Views\ShipLocations\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.ClassTypes));

#line default
#line hidden
            EndContext();
            BeginContext(1288, 103, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(1392, 51, false);
#line 33 "D:\WIP\StarMatrix\StarMatrix\Views\ShipLocations\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.PresentLocation));

#line default
#line hidden
            EndContext();
            BeginContext(1443, 103, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(1547, 48, false);
#line 36 "D:\WIP\StarMatrix\StarMatrix\Views\ShipLocations\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Availability));

#line default
#line hidden
            EndContext();
            BeginContext(1595, 103, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(1699, 53, false);
#line 39 "D:\WIP\StarMatrix\StarMatrix\Views\ShipLocations\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.AvailableLocation));

#line default
#line hidden
            EndContext();
            BeginContext(1752, 174, true);
            WriteLiteral("\r\n                            </th>\r\n\r\n                            <th>Action</th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
            EndContext();
#line 46 "D:\WIP\StarMatrix\StarMatrix\Views\ShipLocations\Index.cshtml"
                           int rowno = 0;

#line default
#line hidden
            BeginContext(1970, 24, true);
            WriteLiteral("                        ");
            EndContext();
#line 47 "D:\WIP\StarMatrix\StarMatrix\Views\ShipLocations\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
            BeginContext(2051, 108, true);
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(2161, 10, false);
#line 51 "D:\WIP\StarMatrix\StarMatrix\Views\ShipLocations\Index.cshtml"
                                Write(rowno += 1);

#line default
#line hidden
            EndContext();
            BeginContext(2172, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(2288, 47, false);
#line 54 "D:\WIP\StarMatrix\StarMatrix\Views\ShipLocations\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Tugs.TugName));

#line default
#line hidden
            EndContext();
            BeginContext(2335, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(2451, 63, false);
#line 57 "D:\WIP\StarMatrix\StarMatrix\Views\ShipLocations\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.BollardPulls.BollardPullName));

#line default
#line hidden
            EndContext();
            BeginContext(2514, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(2630, 57, false);
#line 60 "D:\WIP\StarMatrix\StarMatrix\Views\ShipLocations\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.EngineHPs.EngineHPName));

#line default
#line hidden
            EndContext();
            BeginContext(2687, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(2803, 59, false);
#line 63 "D:\WIP\StarMatrix\StarMatrix\Views\ShipLocations\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.ClassTypes.ClassTypeName));

#line default
#line hidden
            EndContext();
            BeginContext(2862, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(2978, 50, false);
#line 66 "D:\WIP\StarMatrix\StarMatrix\Views\ShipLocations\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.PresentLocation));

#line default
#line hidden
            EndContext();
            BeginContext(3028, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(3144, 47, false);
#line 69 "D:\WIP\StarMatrix\StarMatrix\Views\ShipLocations\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Availability));

#line default
#line hidden
            EndContext();
            BeginContext(3191, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(3307, 52, false);
#line 72 "D:\WIP\StarMatrix\StarMatrix\Views\ShipLocations\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.AvailableLocation));

#line default
#line hidden
            EndContext();
            BeginContext(3359, 150, true);
            WriteLiteral("\r\n                                </td>\r\n\r\n                                <td>\r\n                                    <a class=\"btn btn-primary btn-sm\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3509, "\"", 3573, 1);
#line 76 "D:\WIP\StarMatrix\StarMatrix\Views\ShipLocations\Index.cshtml"
WriteAttributeValue("", 3516, Url.Action("Edit", "ShipLocations", new { id = item.Id}), 3516, 57, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3574, 188, true);
            WriteLiteral("><i class=\"glyphicon glyphicon-edit\"></i> Edit</a>\r\n                                    <a class=\"btn btn-danger btn-sm\" onclick=\"return confirm(\'Are sure you want to delete this item?\');\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3762, "\"", 3838, 1);
#line 77 "D:\WIP\StarMatrix\StarMatrix\Views\ShipLocations\Index.cshtml"
WriteAttributeValue("", 3769, Url.Action("DeleteConfirmed", "ShipLocations", new { id = item.Id }), 3769, 69, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3839, 129, true);
            WriteLiteral("><i class=\"glyphicon glyphicon-trash\"></i> Delete</a>\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 80 "D:\WIP\StarMatrix\StarMatrix\Views\ShipLocations\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(3995, 110, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<StarMatrix.Models.ShipLocation>> Html { get; private set; }
    }
}
#pragma warning restore 1591
