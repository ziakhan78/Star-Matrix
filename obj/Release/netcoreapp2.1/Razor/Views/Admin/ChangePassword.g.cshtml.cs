#pragma checksum "D:\WIP\StarMatrix\StarMatrix\Views\Admin\ChangePassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "933a654f47a7955b05bee1cbd3086d5a9546e3e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ChangePassword), @"mvc.1.0.view", @"/Views/Admin/ChangePassword.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/ChangePassword.cshtml", typeof(AspNetCore.Views_Admin_ChangePassword))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"933a654f47a7955b05bee1cbd3086d5a9546e3e2", @"/Views/Admin/ChangePassword.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7e9e0d65130fd7e1e1d6db1636cdf53067b16e5", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ChangePassword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<StarMatrix.Models.Admin>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\WIP\StarMatrix\StarMatrix\Views\Admin\ChangePassword.cshtml"
  
    ViewBag.Title = "Change Password";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(146, 301, true);
            WriteLiteral(@"
<div class=""row"">
    <div class=""box col-md-12"">
        <div class=""box-inner"">
            <div class=""box-header well"" data-original-title="""">
                <h2><i class=""glyphicon glyphicon-star-empty""></i> Change Password</h2>
            </div>
            <div class=""box-content"">
");
            EndContext();
#line 15 "D:\WIP\StarMatrix\StarMatrix\Views\Admin\ChangePassword.cshtml"
                 using (Html.BeginForm("Changepassword", "Admin", FormMethod.Post))
                {
                    

#line default
#line hidden
            BeginContext(573, 96, true);
            WriteLiteral("                <div class=\"form-horizontal\" style=\"padding-left:20px;\">\r\n\r\n                    ");
            EndContext();
            BeginContext(670, 64, false);
#line 20 "D:\WIP\StarMatrix\StarMatrix\Views\Admin\ChangePassword.cshtml"
               Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(734, 1501, true);
            WriteLiteral(@"

                    <div class=""form-group"">
                        <div >
                            <input type=""text"" id=""Username"" name=""Username"" placeholder=""Username"" class=""custom_css"" />
                        </div>
                    </div>

                    <div class=""form-group"">
                        <div >
                            <input type=""password"" id=""Password"" name=""Password"" class=""custom_css"" placeholder=""Old Password"">
                        </div>
                    </div>

                    <div class=""form-group"">
                        <div >
                            <input type=""password"" id=""NewPassword"" name=""NewPassword"" class=""custom_css"" placeholder=""New Password"">
                        </div>
                    </div>


                    <div class=""form-group"">
                        <div >
                            <input type=""password"" id=""ConfirmPassword"" name=""ConfirmPassword"" class=""custom_css"" placeholder=""Confir");
            WriteLiteral(@"m Password"">
                        </div>
                    </div>


                    <div class=""form-group"">
                        <div >
                            <button type=""submit"" class=""btn btn-primary"">Change Password</button>
                        </div>
                    </div>


                    <div class=""form-group"">
                        <div>
                            <span style=""padding-top:10px;"" class=""text-danger"">");
            EndContext();
            BeginContext(2236, 24, false);
#line 57 "D:\WIP\StarMatrix\StarMatrix\Views\Admin\ChangePassword.cshtml"
                                                                           Write(Html.Raw(ViewBag.Status));

#line default
#line hidden
            EndContext();
            BeginContext(2260, 153, true);
            WriteLiteral("</span>\r\n                        </div>\r\n                        <div>\r\n                            <span style=\"padding-top:10px;\" class=\"text-success\">");
            EndContext();
            BeginContext(2414, 25, false);
#line 60 "D:\WIP\StarMatrix\StarMatrix\Views\Admin\ChangePassword.cshtml"
                                                                            Write(Html.Raw(ViewBag.Message));

#line default
#line hidden
            EndContext();
            BeginContext(2439, 113, true);
            WriteLiteral("</span>\r\n                        </div>\r\n                    </div>                  \r\n\r\n                </div>\r\n");
            EndContext();
#line 65 "D:\WIP\StarMatrix\StarMatrix\Views\Admin\ChangePassword.cshtml"
}

#line default
#line hidden
            BeginContext(2555, 72, true);
            WriteLiteral("            </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n");
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
