#pragma checksum "C:\Users\gusta\Downloads\Unipet 3.0\Unipet 3.0\Unipet\Unipet\Views\Blogs\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bded99989f311cc647cbb523eca7055778acb9d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blogs_Details), @"mvc.1.0.view", @"/Views/Blogs/Details.cshtml")]
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
#line 1 "C:\Users\gusta\Downloads\Unipet 3.0\Unipet 3.0\Unipet\Unipet\Views\_ViewImports.cshtml"
using Unipet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gusta\Downloads\Unipet 3.0\Unipet 3.0\Unipet\Unipet\Views\_ViewImports.cshtml"
using Unipet.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bded99989f311cc647cbb523eca7055778acb9d3", @"/Views/Blogs/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7dbceafeedd50f3044c7180098c8420caf110e46", @"/Views/_ViewImports.cshtml")]
    public class Views_Blogs_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Unipet.Models.Blog>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("padding-left: 20px; float: right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\gusta\Downloads\Unipet 3.0\Unipet 3.0\Unipet\Unipet\Views\Blogs\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""app-wrapper"">
    <div class=""app-content pt-3 p-md-3 p-lg-4"">
        <div class=""container-xl"">
            <div class=""app-card alert alert-dismissible shadow-sm mb-4"" role=""alert"">
                <div class=""inner"">
                    <div class=""app-card-body p-3 p-lg-4"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bded99989f311cc647cbb523eca7055778acb9d34367", async() => {
                WriteLiteral(" <i class=\"fas fa-reply\"></i> Voltar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        <h4 class=""mb-3"">Detalhes da publicação</h4>
                        <div class=""row gx-5 gy-3"">
                            <div class=""col-12 col-lg-12"">
                                <div class=""col-md-12"">
                                    <dl class=""row mt-3 mb-5"">
                                        <dt class=""col-sm-2"">
                                            ");
#nullable restore
#line 20 "C:\Users\gusta\Downloads\Unipet 3.0\Unipet 3.0\Unipet\Unipet\Views\Blogs\Details.cshtml"
                                       Write(Html.DisplayNameFor(model => model.Titulo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </dt>\r\n                                        <dd class=\"col-sm-10\">\r\n                                            ");
#nullable restore
#line 23 "C:\Users\gusta\Downloads\Unipet 3.0\Unipet 3.0\Unipet\Unipet\Views\Blogs\Details.cshtml"
                                       Write(Html.DisplayFor(model => model.Titulo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </dd>\r\n                                        <dt class=\"col-sm-2\">\r\n                                            ");
#nullable restore
#line 26 "C:\Users\gusta\Downloads\Unipet 3.0\Unipet 3.0\Unipet\Unipet\Views\Blogs\Details.cshtml"
                                       Write(Html.DisplayNameFor(model => model.Texto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </dt>\r\n                                        <dd class=\"col-sm-10\">\r\n                                            ");
#nullable restore
#line 29 "C:\Users\gusta\Downloads\Unipet 3.0\Unipet 3.0\Unipet\Unipet\Views\Blogs\Details.cshtml"
                                       Write(Html.DisplayFor(model => model.Texto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </dd>\r\n                                        <dt class=\"col-sm-2\">\r\n                                            ");
#nullable restore
#line 32 "C:\Users\gusta\Downloads\Unipet 3.0\Unipet 3.0\Unipet\Unipet\Views\Blogs\Details.cshtml"
                                       Write(Html.DisplayNameFor(model => model.DataPublicacao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </dt>\r\n                                        <dd class=\"col-sm-10\">\r\n                                            ");
#nullable restore
#line 35 "C:\Users\gusta\Downloads\Unipet 3.0\Unipet 3.0\Unipet\Unipet\Views\Blogs\Details.cshtml"
                                       Write(Html.DisplayFor(model => model.DataPublicacao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </dd>\r\n                                        <dt class=\"col-sm-2\">\r\n                                            ");
#nullable restore
#line 38 "C:\Users\gusta\Downloads\Unipet 3.0\Unipet 3.0\Unipet\Unipet\Views\Blogs\Details.cshtml"
                                       Write(Html.DisplayNameFor(model => model.Foto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </dt>\r\n                                        <dd class=\"col-sm-10\">\r\n                                            ");
#nullable restore
#line 41 "C:\Users\gusta\Downloads\Unipet 3.0\Unipet 3.0\Unipet\Unipet\Views\Blogs\Details.cshtml"
                                       Write(Html.DisplayFor(model => model.Foto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </dd>\r\n                                        <dt class=\"col-sm-1 mt-3\">\r\n                                            ");
#nullable restore
#line 44 "C:\Users\gusta\Downloads\Unipet 3.0\Unipet 3.0\Unipet\Unipet\Views\Blogs\Details.cshtml"
                                       Write(Html.DisplayNameFor(model => model.ExibirHome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </dt>\r\n                                        <dd class=\"col-sm-10 mt-3\">\r\n                                            ");
#nullable restore
#line 47 "C:\Users\gusta\Downloads\Unipet 3.0\Unipet 3.0\Unipet\Unipet\Views\Blogs\Details.cshtml"
                                       Write(Html.DisplayFor(model => model.ExibirHome));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </dd>
                                    </dl>
                                </div>
                            </div>
                        </div>

                    </div>
                </div>
            </div>

        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Unipet.Models.Blog> Html { get; private set; }
    }
}
#pragma warning restore 1591
