#pragma checksum "D:\WIP\StarMatrix\StarMatrix\Views\Admin\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "507a7530c245aab889839110f835b83e3412fa1b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Login), @"mvc.1.0.view", @"/Views/Admin/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Login.cshtml", typeof(AspNetCore.Views_Admin_Login))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"507a7530c245aab889839110f835b83e3412fa1b", @"/Views/Admin/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7e9e0d65130fd7e1e1d6db1636cdf53067b16e5", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StarMatrix.Models.Admin>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("bs-css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/bootstrap-cerulean.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/charisma-app.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/bower_components/jquery/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\WIP\StarMatrix\StarMatrix\Views\Admin\Login.cshtml"
  
    ViewBag.Title = "Login";
    Layout = null;

#line default
#line hidden
            BeginContext(91, 79, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "10af7225a62b407094772358a4c97dba", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
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
            EndContext();
            BeginContext(170, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(172, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f6c24acf6fa24d5a81b22755b14ed568", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(229, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(231, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "036f68191a2e4d1788cf6b408837919b", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(294, 396, true);
            WriteLiteral(@"
<div class=""row"">
    <div class=""box col-md-12"">
        <div class=""box-inner"">

            <div class=""box-content"">

                <div class=""row"">
                    <div class=""well col-md-5 center login-box"">
                        <div class=""alert alert-info"">
                            Please login with your Username and Password.
                        </div>

");
            EndContext();
#line 22 "D:\WIP\StarMatrix\StarMatrix\Views\Admin\Login.cshtml"
                         using (Html.BeginForm("GetLogin", "Admin", FormMethod.Get))
                        {
                            

#line default
#line hidden
            BeginContext(832, 23, false);
#line 24 "D:\WIP\StarMatrix\StarMatrix\Views\Admin\Login.cshtml"
                       Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(857, 139, true);
            WriteLiteral("                            <div class=\"form-horizontal\">\r\n                                <fieldset>\r\n                                    ");
            EndContext();
            BeginContext(997, 64, false);
#line 27 "D:\WIP\StarMatrix\StarMatrix\Views\Admin\Login.cshtml"
                               Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1061, 205, true);
            WriteLiteral("\r\n                                    <div class=\"input-group input-group-lg\">\r\n                                        <span class=\"input-group-addon\"><i class=\"glyphicon glyphicon-user red\"></i></span>\r\n");
            EndContext();
            BeginContext(1375, 40, true);
            WriteLiteral("                                        ");
            EndContext();
            BeginContext(1416, 123, false);
#line 31 "D:\WIP\StarMatrix\StarMatrix\Views\Admin\Login.cshtml"
                                   Write(Html.EditorFor(model => model.Username, new { htmlAttributes = new { @class = "form-control", placeholder = "Username" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1539, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(1582, 86, false);
#line 32 "D:\WIP\StarMatrix\StarMatrix\Views\Admin\Login.cshtml"
                                   Write(Html.ValidationMessageFor(model => model.Username, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1668, 323, true);
            WriteLiteral(@"

                                    </div>
                                    <div class=""clearfix""></div><br>
                                    <div class=""input-group input-group-lg"">
                                        <span class=""input-group-addon""><i class=""glyphicon glyphicon-log-in red""></i></span>
");
            EndContext();
            BeginContext(2104, 40, true);
            WriteLiteral("                                        ");
            EndContext();
            BeginContext(2145, 123, false);
#line 39 "D:\WIP\StarMatrix\StarMatrix\Views\Admin\Login.cshtml"
                                   Write(Html.EditorFor(model => model.Password, new { htmlAttributes = new { @class = "form-control", placeholder = "Password" } }));

#line default
#line hidden
            EndContext();
            BeginContext(2268, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(2311, 86, false);
#line 40 "D:\WIP\StarMatrix\StarMatrix\Views\Admin\Login.cshtml"
                                   Write(Html.ValidationMessageFor(model => model.Password, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2397, 841, true);
            WriteLiteral(@"

                                    </div>
                                    <div class=""clearfix""></div>
                                    <div class=""input-prepend"">
                                        <label class=""remember"" for=""remember""><input type=""checkbox"" id=""remember""> Remember me</label>
                                    </div>


                                    <div class=""clearfix""></div>
                                    <p class=""center col-md-5"">
                                        <button type=""submit"" class=""btn btn-primary"">Login</button>
                                    </p>
                                    <div class=""clearfix""></div>
                                    <div>
                                        <span style=""padding-top:10px;"" class=""text-danger"">");
            EndContext();
            BeginContext(3239, 24, false);
#line 55 "D:\WIP\StarMatrix\StarMatrix\Views\Admin\Login.cshtml"
                                                                                       Write(Html.Raw(ViewBag.Status));

#line default
#line hidden
            EndContext();
            BeginContext(3263, 134, true);
            WriteLiteral("</span>\r\n                                    </div>\r\n                                </fieldset>\r\n                            </div>\r\n");
            EndContext();
#line 59 "D:\WIP\StarMatrix\StarMatrix\Views\Admin\Login.cshtml"
                        }

#line default
#line hidden
            BeginContext(3424, 153, true);
            WriteLiteral("                    </div>\r\n                    <!--/span-->\r\n                </div><!--/row-->\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StarMatrix.Models.Admin> Html { get; private set; }
    }
}
#pragma warning restore 1591
