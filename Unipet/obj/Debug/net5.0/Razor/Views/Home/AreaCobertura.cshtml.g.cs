#pragma checksum "C:\Users\gusta\Downloads\Unipet 3.0\Unipet 3.0\Unipet\Unipet\Views\Home\AreaCobertura.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "abbf98c4051320309a235c7d42ee67446cb14cba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AreaCobertura), @"mvc.1.0.view", @"/Views/Home/AreaCobertura.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abbf98c4051320309a235c7d42ee67446cb14cba", @"/Views/Home/AreaCobertura.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7dbceafeedd50f3044c7180098c8420caf110e46", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AreaCobertura : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Unipet.Models.AreaCobertura>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("filtrosForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("row justify-content-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_AreasGrid", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\gusta\Downloads\Unipet 3.0\Unipet 3.0\Unipet\Unipet\Views\Home\AreaCobertura.cshtml"
  
    ViewData["Title"] = "AreaCobertura";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!-- divisao -->\r\n<div class=\"slider-wrapper\">\r\n    <section class=\"slider-section\">\r\n        <div class=\"slider-active slick-style\">\r\n            <div class=\"img-interna\"");
            BeginWriteAttribute("style", " style=\"", 269, "\"", 333, 3);
            WriteAttributeValue("", 277, "background-image:url(", 277, 21, true);
#nullable restore
#line 9 "C:\Users\gusta\Downloads\Unipet 3.0\Unipet 3.0\Unipet\Unipet\Views\Home\AreaCobertura.cshtml"
WriteAttributeValue("", 298, Url.Content("~/img/divisao.jpg"), 298, 33, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 331, ");", 331, 2, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n        </div>\r\n    </section>\r\n</div>\r\n\t</header>\r\n\r\n<!--======================== filtros ========================== -->\r\n<section id=\"filtros\" class=\"service-section mt-55\">\r\n    <div class=\"container\">\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "abbf98c4051320309a235c7d42ee67446cb14cba5638", async() => {
                WriteLiteral(@"
            <div class=""col-lg-8"">
                <label for=""inputCidade"" class=""form-label"">Cidade</label>
                <div class=""input-group"">
                    <input class=""form-control"" type=""search"" id=""inputCidade"" name=""inputCidade"" placeholder=""Todas"">
                    <span class=""input-group-append"">
                        <button class=""btn btn-outline-success border"" type=""button"" onclick=""submitFiltros()"">
                            <i class=""fa fa-search""></i>
                        </button>
                    </span>
                </div>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</section>\r\n\r\n<div id=\"partialView\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "abbf98c4051320309a235c7d42ee67446cb14cba7743", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 36 "C:\Users\gusta\Downloads\Unipet 3.0\Unipet 3.0\Unipet\Unipet\Views\Home\AreaCobertura.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 40 "C:\Users\gusta\Downloads\Unipet 3.0\Unipet 3.0\Unipet\Unipet\Views\Home\AreaCobertura.cshtml"
       await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    <script src=""https://cdnjs.cloudflare.com/ajax/libs/sweetalert/2.1.2/sweetalert.min.js""></script>

    <script type=""text/javascript"">

        $(""#filtrosForm"").submit(function (evt) {
            evt.preventDefault();
            submitFiltros();
        });

        function submitFiltros() {
            var data = $(""#filtrosForm"").serialize();
            $.ajax({
                type: 'GET',
                url: '/Home/_AreasGrid',
                contentType: 'application/x-www-form-urlencoded; charset=UTF-8', // when we use .serialize() this generates the data in query string format. this needs the default contentType (default content type is: contentType: 'application/x-www-form-urlencoded; charset=UTF-8') so it is optional, you can remove it
                data: data,
                success: function (result) {
                    $(""#partialView"").html(result);
                },
                error: function () {
                    alert('Failed to receive the Data');");
                WriteLiteral("\n                    console.log(\'Failed \');\r\n                }\r\n            })\r\n        }\r\n\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Unipet.Models.AreaCobertura>> Html { get; private set; }
    }
}
#pragma warning restore 1591
