#pragma checksum "C:\Users\gusta\Downloads\Unipet 3.0\Unipet 3.0\Unipet\Unipet\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ebe9d00f6caf640a6c624538ee4aa40441972f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ebe9d00f6caf640a6c624538ee4aa40441972f8", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7dbceafeedd50f3044c7180098c8420caf110e46", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn app-btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("target", new global::Microsoft.AspNetCore.Html.HtmlString("_blank"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\gusta\Downloads\Unipet 3.0\Unipet 3.0\Unipet\Unipet\Views\Admin\Index.cshtml"
  
    ViewData["Title"] = "Área Administrativa";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""app-wrapper"">
    <div class=""app-content pt-3 p-md-3 p-lg-4"">
        <div class=""container-xl"">
            <h1 class=""app-page-title"">Visão Geral</h1>

            <!--card Boas Vindas-->
            <div class=""app-card alert alert-dismissible shadow-sm mb-4 border-left-decoration"" role=""alert"">
                <div class=""inner"">
                    <div class=""app-card-body p-3 p-lg-4"">
                        <h3 class=""mb-3"">Portal Unipet</h3>
                        <div class=""row gx-5 gy-3"">
                            <div class=""col-12 col-lg-9"">
                                <div>
                                    <p>Seja bem-vindo administrador! Através do portal Unipet você poderá:</p>
                                    <ul>
                                        <li>Administrar os perfis do site;</li>
                                        <li>Inserir/editar/excluir os Planos cadastrados no site;</li>
                                        <li>Acompanhar");
            WriteLiteral(@" os contratos fechados e seu status;</li>
                                        <li>Inserir/editar/excluir áreas de cobertura;</li>
                                        <li>Gerir o Blog do site, incluindo/editando/excluindo publicações;</li>
                                        <li>Visualizar e responder os contatos enviados através do site;</li>
                                        <li>Analisar e Aprovar os relatos de clientes no site.</li>
                                    </ul>
                                </div>
                            </div>
                            <div class=""col-12 col-lg-3"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ebe9d00f6caf640a6c624538ee4aa40441972f86407", async() => {
                WriteLiteral("\r\n                                    <i class=\"fas fa-paw\" style=\"margin-right: 8px\"></i> Unipet\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                        </div>
                        <button type=""button"" class=""btn-close"" data-bs-dismiss=""alert"" aria-label=""Close""></button>
                    </div>
                </div>
            </div>

            <!--card Estatísticas do Sistemas-->
            <div class=""row g-4 mb-4"">
                <!--contratos fechados-->
                <div class=""col-6 col-lg-3"">
                    <div class=""app-card app-card-stat shadow-sm h-100"">
                        <div class=""app-card-body p-3 p-lg-4"">
                            <h4 class=""stats-type mb-1""> Contratos fechados </h4>
                            <div class=""stats-figure""> 5 </div>
                        </div>
                    </div>
                </div>

                <!--perfis cadastrados-->
                <div class=""col-6 col-lg-3"">
                    <div class=""app-card app-card-stat shadow-sm h-100"">
                        <div class=""app-card-bod");
            WriteLiteral(@"y p-3 p-lg-4"">
                            <h4 class=""stats-type mb-1""> Perfis cadastrados </h4>
                            <div class=""stats-figure""> 15 </div>
                        </div>
                    </div>
                </div>

                <!--planos oferecidos-->
                <div class=""col-6 col-lg-3"">
                    <div class=""app-card app-card-stat shadow-sm h-100"">
                        <div class=""app-card-body p-3 p-lg-4"">
                            <h4 class=""stats-type mb-1""> Planos oferecidos </h4>
                            <div class=""stats-figure""> 13 </div>
                        </div>
                    </div>
                </div>

                <!--relatos-->
                <div class=""col-6 col-lg-3"">
                    <div class=""app-card app-card-stat shadow-sm h-100"">
                        <div class=""app-card-body p-3 p-lg-4"">
                            <h4 class=""stats-type mb-1""> Relatos </h4>
                         ");
            WriteLiteral("   <div class=\"stats-figure\"> 3 </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
