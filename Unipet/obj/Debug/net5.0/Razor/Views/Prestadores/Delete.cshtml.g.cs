#pragma checksum "C:\Users\gusta\Downloads\Unipet 3.0\Unipet 3.0\Unipet\Unipet\Views\Prestadores\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c47341b1c16006b4a91a6c0b8dac324056ab2db9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Prestadores_Delete), @"mvc.1.0.view", @"/Views/Prestadores/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c47341b1c16006b4a91a6c0b8dac324056ab2db9", @"/Views/Prestadores/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7dbceafeedd50f3044c7180098c8420caf110e46", @"/Views/_ViewImports.cshtml")]
    public class Views_Prestadores_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Unipet.Models.Prestador>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("padding-left: 20px; float: right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\gusta\Downloads\Unipet 3.0\Unipet 3.0\Unipet\Unipet\Views\Prestadores\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c47341b1c16006b4a91a6c0b8dac324056ab2db95444", async() => {
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

                        <div class=""row gx-5 gy-3"">
                            <div class=""col-12 col-lg-12"">
                                <div class=""col-md-12"">
                                    <h4 class=""mb-5"">Deseja deletar esse registro?</h4>

                                    <dl class=""row mt-3"">
                                        <dt class=""col-sm-2"">
                                            ");
#nullable restore
#line 23 "C:\Users\gusta\Downloads\Unipet 3.0\Unipet 3.0\Unipet\Unipet\Views\Prestadores\Delete.cshtml"
                                       Write(Html.DisplayNameFor(model => model.RazaoSocial));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </dt>\r\n                                        <dd class=\"col-sm-10\">\r\n                                            ");
#nullable restore
#line 26 "C:\Users\gusta\Downloads\Unipet 3.0\Unipet 3.0\Unipet\Unipet\Views\Prestadores\Delete.cshtml"
                                       Write(Html.DisplayFor(model => model.RazaoSocial));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </dd>\r\n                                        <dt class=\"col-sm-2\">\r\n                                            ");
#nullable restore
#line 29 "C:\Users\gusta\Downloads\Unipet 3.0\Unipet 3.0\Unipet\Unipet\Views\Prestadores\Delete.cshtml"
                                       Write(Html.DisplayNameFor(model => model.CNPJ));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </dt>\r\n                                        <dd class=\"col-sm-10\">\r\n                                            ");
#nullable restore
#line 32 "C:\Users\gusta\Downloads\Unipet 3.0\Unipet 3.0\Unipet\Unipet\Views\Prestadores\Delete.cshtml"
                                       Write(Html.DisplayFor(model => model.CNPJ));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </dd>\r\n                                        <dt class=\"col-sm-2\">\r\n                                            ");
#nullable restore
#line 35 "C:\Users\gusta\Downloads\Unipet 3.0\Unipet 3.0\Unipet\Unipet\Views\Prestadores\Delete.cshtml"
                                       Write(Html.DisplayNameFor(model => model.Fone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </dt>\r\n                                        <dd class=\"col-sm-10\">\r\n                                            ");
#nullable restore
#line 38 "C:\Users\gusta\Downloads\Unipet 3.0\Unipet 3.0\Unipet\Unipet\Views\Prestadores\Delete.cshtml"
                                       Write(Html.DisplayFor(model => model.Fone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </dd>\r\n                                        <dt class=\"col-sm-2\">\r\n                                            ");
#nullable restore
#line 41 "C:\Users\gusta\Downloads\Unipet 3.0\Unipet 3.0\Unipet\Unipet\Views\Prestadores\Delete.cshtml"
                                       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </dt>\r\n                                        <dd class=\"col-sm-10\">\r\n                                            ");
#nullable restore
#line 44 "C:\Users\gusta\Downloads\Unipet 3.0\Unipet 3.0\Unipet\Unipet\Views\Prestadores\Delete.cshtml"
                                       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </dd>\r\n                                        <dt class=\"col-sm-2\">\r\n                                            ");
#nullable restore
#line 47 "C:\Users\gusta\Downloads\Unipet 3.0\Unipet 3.0\Unipet\Unipet\Views\Prestadores\Delete.cshtml"
                                       Write(Html.DisplayNameFor(model => model.Endereco));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </dt>\r\n                                        <dd class=\"col-sm-10\">\r\n                                            ");
#nullable restore
#line 50 "C:\Users\gusta\Downloads\Unipet 3.0\Unipet 3.0\Unipet\Unipet\Views\Prestadores\Delete.cshtml"
                                       Write(Html.DisplayFor(model => model.Endereco.Logradouro));

#line default
#line hidden
#nullable disable
            WriteLiteral(",\r\n                                            ");
#nullable restore
#line 51 "C:\Users\gusta\Downloads\Unipet 3.0\Unipet 3.0\Unipet\Unipet\Views\Prestadores\Delete.cshtml"
                                       Write(Html.DisplayFor(model => model.Endereco.NumeroCasa));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n                                            Bairro: ");
#nullable restore
#line 52 "C:\Users\gusta\Downloads\Unipet 3.0\Unipet 3.0\Unipet\Unipet\Views\Prestadores\Delete.cshtml"
                                               Write(Html.DisplayFor(model => model.Endereco.Bairro));

#line default
#line hidden
#nullable disable
            WriteLiteral(" .\r\n                                            CEP: ");
#nullable restore
#line 53 "C:\Users\gusta\Downloads\Unipet 3.0\Unipet 3.0\Unipet\Unipet\Views\Prestadores\Delete.cshtml"
                                            Write(Html.DisplayFor(model => model.Endereco.CEP));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </dd>\r\n                                        <dt class=\"col-sm-2\">\r\n                                            ");
#nullable restore
#line 56 "C:\Users\gusta\Downloads\Unipet 3.0\Unipet 3.0\Unipet\Unipet\Views\Prestadores\Delete.cshtml"
                                       Write(Html.DisplayNameFor(model => model.Usuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </dt>\r\n                                        <dd class=\"col-sm-10\">\r\n                                            ");
#nullable restore
#line 59 "C:\Users\gusta\Downloads\Unipet 3.0\Unipet 3.0\Unipet\Unipet\Views\Prestadores\Delete.cshtml"
                                       Write(Html.DisplayFor(model => model.Usuario.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </dd>\r\n\r\n                                        <dt class=\"col-sm-2\">\r\n                                            ");
#nullable restore
#line 63 "C:\Users\gusta\Downloads\Unipet 3.0\Unipet 3.0\Unipet\Unipet\Views\Prestadores\Delete.cshtml"
                                       Write(Html.DisplayNameFor(model => model.Logotipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </dt>\r\n                                        <dd class=\"col-sm-10\">\r\n                                            ");
#nullable restore
#line 66 "C:\Users\gusta\Downloads\Unipet 3.0\Unipet 3.0\Unipet\Unipet\Views\Prestadores\Delete.cshtml"
                                       Write(Html.DisplayFor(model => model.Logotipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </dd>\r\n                                        <dt class=\"col-sm-1 mt-3\">\r\n                                            ");
#nullable restore
#line 69 "C:\Users\gusta\Downloads\Unipet 3.0\Unipet 3.0\Unipet\Unipet\Views\Prestadores\Delete.cshtml"
                                       Write(Html.DisplayNameFor(model => model.ExibirHome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </dt>\r\n                                        <dd class=\"col-sm-10 mt-3\">\r\n                                            ");
#nullable restore
#line 72 "C:\Users\gusta\Downloads\Unipet 3.0\Unipet 3.0\Unipet\Unipet\Views\Prestadores\Delete.cshtml"
                                       Write(Html.DisplayFor(model => model.ExibirHome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </dd>\r\n                                    </dl>\r\n\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c47341b1c16006b4a91a6c0b8dac324056ab2db915594", async() => {
                WriteLiteral("\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c47341b1c16006b4a91a6c0b8dac324056ab2db915893", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 77 "C:\Users\gusta\Downloads\Unipet 3.0\Unipet 3.0\Unipet\Unipet\Views\Prestadores\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.IdPrestador);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        <input type=\"submit\" value=\"Deletar\" class=\"btn btn-danger\" />\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Unipet.Models.Prestador> Html { get; private set; }
    }
}
#pragma warning restore 1591
