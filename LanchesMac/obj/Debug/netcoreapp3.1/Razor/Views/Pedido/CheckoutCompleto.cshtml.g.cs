#pragma checksum "C:\_Cursos_Macoratti\Curso_ASPNET_Core_MVC_FAZAP\LanchesMac_RelatorioPedidos\LanchesMac_RelatorioPedidos\LanchesMac\LanchesMac\Views\Pedido\CheckoutCompleto.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55c2e39704d4f8a5e8dbe02bc20e0d82fc0137b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedido_CheckoutCompleto), @"mvc.1.0.view", @"/Views/Pedido/CheckoutCompleto.cshtml")]
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
#line 1 "C:\_Cursos_Macoratti\Curso_ASPNET_Core_MVC_FAZAP\LanchesMac_RelatorioPedidos\LanchesMac_RelatorioPedidos\LanchesMac\LanchesMac\Views\_ViewImports.cshtml"
using LanchesMac;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\_Cursos_Macoratti\Curso_ASPNET_Core_MVC_FAZAP\LanchesMac_RelatorioPedidos\LanchesMac_RelatorioPedidos\LanchesMac\LanchesMac\Views\_ViewImports.cshtml"
using LanchesMac.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\_Cursos_Macoratti\Curso_ASPNET_Core_MVC_FAZAP\LanchesMac_RelatorioPedidos\LanchesMac_RelatorioPedidos\LanchesMac\LanchesMac\Views\_ViewImports.cshtml"
using LanchesMac.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55c2e39704d4f8a5e8dbe02bc20e0d82fc0137b7", @"/Views/Pedido/CheckoutCompleto.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"133db4ed61ab83cbde0a14b5646c41c7227b114b", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedido_CheckoutCompleto : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Pedido>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container marginTop1\">\r\n\r\n    <div class=\"jumbotron\">\r\n        <h2>");
#nullable restore
#line 6 "C:\_Cursos_Macoratti\Curso_ASPNET_Core_MVC_FAZAP\LanchesMac_RelatorioPedidos\LanchesMac_RelatorioPedidos\LanchesMac\LanchesMac\Views\Pedido\CheckoutCompleto.cshtml"
       Write(ViewBag.CheckoutCompletoMensagem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    </div>\r\n    <div class=\"card\">\r\n        <div class=\"card-body\">\r\n            <p>Cliente : <strong>");
#nullable restore
#line 10 "C:\_Cursos_Macoratti\Curso_ASPNET_Core_MVC_FAZAP\LanchesMac_RelatorioPedidos\LanchesMac_RelatorioPedidos\LanchesMac\LanchesMac\Views\Pedido\CheckoutCompleto.cshtml"
                            Write(Model.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n            <p>Data do Pedido :  <strong>");
#nullable restore
#line 11 "C:\_Cursos_Macoratti\Curso_ASPNET_Core_MVC_FAZAP\LanchesMac_RelatorioPedidos\LanchesMac_RelatorioPedidos\LanchesMac\LanchesMac\Views\Pedido\CheckoutCompleto.cshtml"
                                    Write(Model.PedidoEnviado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n            <p>N??mero do Pedido   : <strong>");
#nullable restore
#line 12 "C:\_Cursos_Macoratti\Curso_ASPNET_Core_MVC_FAZAP\LanchesMac_RelatorioPedidos\LanchesMac_RelatorioPedidos\LanchesMac\LanchesMac\Views\Pedido\CheckoutCompleto.cshtml"
                                       Write(Model.PedidoId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n            <table class=\"table\">\r\n              <tr>\r\n                <th></th>\r\n                <th>Quantidade</th>\r\n                <th>Lanche</th>\r\n                <th>Pre??o</th>\r\n              </tr>\r\n");
#nullable restore
#line 20 "C:\_Cursos_Macoratti\Curso_ASPNET_Core_MVC_FAZAP\LanchesMac_RelatorioPedidos\LanchesMac_RelatorioPedidos\LanchesMac\LanchesMac\Views\Pedido\CheckoutCompleto.cshtml"
               foreach (var item in Model.PedidoItens)
               {

#line default
#line hidden
#nullable disable
            WriteLiteral("                 <tr>\r\n                   <td><img");
            BeginWriteAttribute("src", " src=\"", 735, "\"", 763, 1);
#nullable restore
#line 23 "C:\_Cursos_Macoratti\Curso_ASPNET_Core_MVC_FAZAP\LanchesMac_RelatorioPedidos\LanchesMac_RelatorioPedidos\LanchesMac\LanchesMac\Views\Pedido\CheckoutCompleto.cshtml"
WriteAttributeValue("", 741, item.Lanche.ImagemUrl, 741, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"40\" height=\"40\" /></td>\r\n                   <td>");
#nullable restore
#line 24 "C:\_Cursos_Macoratti\Curso_ASPNET_Core_MVC_FAZAP\LanchesMac_RelatorioPedidos\LanchesMac_RelatorioPedidos\LanchesMac\LanchesMac\Views\Pedido\CheckoutCompleto.cshtml"
                  Write(item.Quantidade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                   <td>");
#nullable restore
#line 25 "C:\_Cursos_Macoratti\Curso_ASPNET_Core_MVC_FAZAP\LanchesMac_RelatorioPedidos\LanchesMac_RelatorioPedidos\LanchesMac\LanchesMac\Views\Pedido\CheckoutCompleto.cshtml"
                  Write(item.Lanche.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                   <td>");
#nullable restore
#line 26 "C:\_Cursos_Macoratti\Curso_ASPNET_Core_MVC_FAZAP\LanchesMac_RelatorioPedidos\LanchesMac_RelatorioPedidos\LanchesMac\LanchesMac\Views\Pedido\CheckoutCompleto.cshtml"
                  Write(item.Lanche.Preco);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                  </tr>\r\n");
#nullable restore
#line 28 "C:\_Cursos_Macoratti\Curso_ASPNET_Core_MVC_FAZAP\LanchesMac_RelatorioPedidos\LanchesMac_RelatorioPedidos\LanchesMac\LanchesMac\Views\Pedido\CheckoutCompleto.cshtml"
               }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </table>\r\n            <h4>Valor Total do Pedido: <strong>");
#nullable restore
#line 30 "C:\_Cursos_Macoratti\Curso_ASPNET_Core_MVC_FAZAP\LanchesMac_RelatorioPedidos\LanchesMac_RelatorioPedidos\LanchesMac\LanchesMac\Views\Pedido\CheckoutCompleto.cshtml"
                                           Write(((decimal)ViewBag.TotalPedido).ToString("C2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></h4>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pedido> Html { get; private set; }
    }
}
#pragma warning restore 1591
