#pragma checksum "C:\Users\lari_\Desktop\C#\ControleVeicular\Views\Home\ListagemAnuncio.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dadbb8505790146518ed68a2fdd3a303fa9460a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ListagemAnuncio), @"mvc.1.0.view", @"/Views/Home/ListagemAnuncio.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ListagemAnuncio.cshtml", typeof(AspNetCore.Views_Home_ListagemAnuncio))]
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
#line 1 "C:\Users\lari_\Desktop\C#\ControleVeicular\Views\_ViewImports.cshtml"
using ControleVeicular;

#line default
#line hidden
#line 2 "C:\Users\lari_\Desktop\C#\ControleVeicular\Views\_ViewImports.cshtml"
using ControleVeicular.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dadbb8505790146518ed68a2fdd3a303fa9460a8", @"/Views/Home/ListagemAnuncio.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a262923c3d50b30e29ab87c2e666a16c36bb1c4b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ListagemAnuncio : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<Anuncio>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "carrinho", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\lari_\Desktop\C#\ControleVeicular\Views\Home\ListagemAnuncio.cshtml"
  
    ViewData["Title"] = "ListagemAnuncios";

#line default
#line hidden
            BeginContext(76, 8, true);
            WriteLiteral("\r\n\r\n    ");
            EndContext();
            BeginContext(84, 485, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cdb0c93b7acd4f58bd5389c468257e16", async() => {
                BeginContext(90, 472, true);
                WriteLiteral(@"
        <meta charset=""utf-8"">
        <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
        <style>
            table {
                font-family: arial, sans-serif;
                border-collapse: collapse;
                width: 100%;
            }

            td, th {
                border: 1px solid #dddddd;
                text-align: left;
                padding: 6px;
            }
           
        </style>
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(569, 465, true);
            WriteLiteral(@"
<td class=""container"">
    <h3>Anúncios cadastrados</h3>
    <td class=""list-group"">
        <table>
            <tr>
                <th>Código - Descrição</th>
                <th>Modelo</th>
                <th>Marca</th>
                <th>Cor</th>
                <th>Ano</th>
                <th>Valor Compra</th>
                <th>Valor Venda</th>
                <th>Tipo Combustivel</th>
                <th>Ação</th>
            </tr>
");
            EndContext();
#line 40 "C:\Users\lari_\Desktop\C#\ControleVeicular\Views\Home\ListagemAnuncio.cshtml"
             foreach (var anuncio in Model)
            {

#line default
#line hidden
            BeginContext(1094, 87, true);
            WriteLiteral("                <tr>\r\n\r\n                        <td>\r\n                            <h4> ");
            EndContext();
            BeginContext(1182, 14, false);
#line 45 "C:\Users\lari_\Desktop\C#\ControleVeicular\Views\Home\ListagemAnuncio.cshtml"
                            Write(anuncio.Codigo);

#line default
#line hidden
            EndContext();
            BeginContext(1196, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(1200, 17, false);
#line 45 "C:\Users\lari_\Desktop\C#\ControleVeicular\Views\Home\ListagemAnuncio.cshtml"
                                              Write(anuncio.Descricao);

#line default
#line hidden
            EndContext();
            BeginContext(1217, 102, true);
            WriteLiteral(" </h4>\r\n                        </td>\r\n                        <td>\r\n                            <h4> ");
            EndContext();
            BeginContext(1320, 14, false);
#line 48 "C:\Users\lari_\Desktop\C#\ControleVeicular\Views\Home\ListagemAnuncio.cshtml"
                            Write(anuncio.Modelo);

#line default
#line hidden
            EndContext();
            BeginContext(1334, 101, true);
            WriteLiteral("</h4>\r\n                        </td>\r\n                        <td>\r\n                            <h4> ");
            EndContext();
            BeginContext(1436, 13, false);
#line 51 "C:\Users\lari_\Desktop\C#\ControleVeicular\Views\Home\ListagemAnuncio.cshtml"
                            Write(anuncio.Marca);

#line default
#line hidden
            EndContext();
            BeginContext(1449, 101, true);
            WriteLiteral("</h4>\r\n                        </td>\r\n                        <td>\r\n                            <h4> ");
            EndContext();
            BeginContext(1551, 11, false);
#line 54 "C:\Users\lari_\Desktop\C#\ControleVeicular\Views\Home\ListagemAnuncio.cshtml"
                            Write(anuncio.Cor);

#line default
#line hidden
            EndContext();
            BeginContext(1562, 101, true);
            WriteLiteral("</h4>\r\n                        </td>\r\n                        <td>\r\n                            <h4> ");
            EndContext();
            BeginContext(1664, 11, false);
#line 57 "C:\Users\lari_\Desktop\C#\ControleVeicular\Views\Home\ListagemAnuncio.cshtml"
                            Write(anuncio.Ano);

#line default
#line hidden
            EndContext();
            BeginContext(1675, 101, true);
            WriteLiteral("</h4>\r\n                        </td>\r\n                        <td>\r\n                            <h4> ");
            EndContext();
            BeginContext(1777, 19, false);
#line 60 "C:\Users\lari_\Desktop\C#\ControleVeicular\Views\Home\ListagemAnuncio.cshtml"
                            Write(anuncio.ValorCompra);

#line default
#line hidden
            EndContext();
            BeginContext(1796, 101, true);
            WriteLiteral("</h4>\r\n                        </td>\r\n                        <td>\r\n                            <h4> ");
            EndContext();
            BeginContext(1898, 18, false);
#line 63 "C:\Users\lari_\Desktop\C#\ControleVeicular\Views\Home\ListagemAnuncio.cshtml"
                            Write(anuncio.ValorVenda);

#line default
#line hidden
            EndContext();
            BeginContext(1916, 101, true);
            WriteLiteral("</h4>\r\n                        </td>\r\n                        <td>\r\n                            <h4> ");
            EndContext();
            BeginContext(2018, 23, false);
#line 66 "C:\Users\lari_\Desktop\C#\ControleVeicular\Views\Home\ListagemAnuncio.cshtml"
                            Write(anuncio.TipoCombustivel);

#line default
#line hidden
            EndContext();
            BeginContext(2041, 96, true);
            WriteLiteral("</h4>\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2137, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d6b2434920f4297a865bce27d9723af", async() => {
                BeginContext(2217, 6, true);
                WriteLiteral("Editar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-codigo", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 69 "C:\Users\lari_\Desktop\C#\ControleVeicular\Views\Home\ListagemAnuncio.cshtml"
                                                           WriteLiteral(anuncio.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["codigo"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-codigo", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["codigo"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2227, 58, true);
            WriteLiteral("\r\n                        </td>\r\n                  </tr>\r\n");
            EndContext();
#line 72 "C:\Users\lari_\Desktop\C#\ControleVeicular\Views\Home\ListagemAnuncio.cshtml"

            }

#line default
#line hidden
            BeginContext(2302, 38, true);
            WriteLiteral("         </table>\r\n    </td>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<Anuncio>> Html { get; private set; }
    }
}
#pragma warning restore 1591
