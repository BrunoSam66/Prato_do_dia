#pragma checksum "C:\Users\crist\OneDrive\Documentos\Source\tr2\Prato_do_Dia\lab\lab\Views\Restaurante\MostrarPratos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ffe15c9c3db27b71360f3e303b4866690131f91e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Restaurante_MostrarPratos), @"mvc.1.0.view", @"/Views/Restaurante/MostrarPratos.cshtml")]
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
#line 1 "C:\Users\crist\OneDrive\Documentos\Source\tr2\Prato_do_Dia\lab\lab\Views\_ViewImports.cshtml"
using lab;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\crist\OneDrive\Documentos\Source\tr2\Prato_do_Dia\lab\lab\Views\_ViewImports.cshtml"
using lab.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\crist\OneDrive\Documentos\Source\tr2\Prato_do_Dia\lab\lab\Views\Restaurante\MostrarPratos.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffe15c9c3db27b71360f3e303b4866690131f91e", @"/Views/Restaurante/MostrarPratos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a525c2b9f5b4e11df46e2eb0b985798acb8afdb3", @"/Views/_ViewImports.cshtml")]
    public class Views_Restaurante_MostrarPratos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<lab.Models.PratoDia>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cliente", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AvaliarPratos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\crist\OneDrive\Documentos\Source\tr2\Prato_do_Dia\lab\lab\Views\Restaurante\MostrarPratos.cshtml"
  
    var IdPrato = ViewBag.Id as int[];
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\crist\OneDrive\Documentos\Source\tr2\Prato_do_Dia\lab\lab\Views\Restaurante\MostrarPratos.cshtml"
                                    

    var IdPratos = ViewBag.fav as int[];

    var DataPratos = ViewBag.DataPratos as string[];

    int i = 0;


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<table class=""table"">
    <thead>
        <tr>
            <th>
                Nome
            </th>
            <th>
                Tipo
            </th>
            <th>
                Preço
            </th>
            <th>
                Descrição
            </th>
            <th>
                Data do Prato
            </th>
            <th>
                Foto
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 39 "C:\Users\crist\OneDrive\Documentos\Source\tr2\Prato_do_Dia\lab\lab\Views\Restaurante\MostrarPratos.cshtml"
         if (IdPrato != null)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\crist\OneDrive\Documentos\Source\tr2\Prato_do_Dia\lab\lab\Views\Restaurante\MostrarPratos.cshtml"
             foreach (var item in Model)
            {
                if (IdPrato.Contains(item.Id))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 47 "C:\Users\crist\OneDrive\Documentos\Source\tr2\Prato_do_Dia\lab\lab\Views\Restaurante\MostrarPratos.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 50 "C:\Users\crist\OneDrive\Documentos\Source\tr2\Prato_do_Dia\lab\lab\Views\Restaurante\MostrarPratos.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Tipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 53 "C:\Users\crist\OneDrive\Documentos\Source\tr2\Prato_do_Dia\lab\lab\Views\Restaurante\MostrarPratos.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Preco));

#line default
#line hidden
#nullable disable
            WriteLiteral(" €\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 56 "C:\Users\crist\OneDrive\Documentos\Source\tr2\Prato_do_Dia\lab\lab\Views\Restaurante\MostrarPratos.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 59 "C:\Users\crist\OneDrive\Documentos\Source\tr2\Prato_do_Dia\lab\lab\Views\Restaurante\MostrarPratos.cshtml"
                       Write(DataPratos[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n");
#nullable restore
#line 61 "C:\Users\crist\OneDrive\Documentos\Source\tr2\Prato_do_Dia\lab\lab\Views\Restaurante\MostrarPratos.cshtml"
                           
                            i++;
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ffe15c9c3db27b71360f3e303b4866690131f91e9271", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1719, "~/Img/", 1719, 6, true);
#nullable restore
#line 65 "C:\Users\crist\OneDrive\Documentos\Source\tr2\Prato_do_Dia\lab\lab\Views\Restaurante\MostrarPratos.cshtml"
AddHtmlAttributeValue("", 1725, Html.DisplayFor(modelItem => item.Foto), 1725, 40, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n");
#nullable restore
#line 67 "C:\Users\crist\OneDrive\Documentos\Source\tr2\Prato_do_Dia\lab\lab\Views\Restaurante\MostrarPratos.cshtml"
                         if (Context.Session.GetString("Role") == "Cliente")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>\r\n");
#nullable restore
#line 70 "C:\Users\crist\OneDrive\Documentos\Source\tr2\Prato_do_Dia\lab\lab\Views\Restaurante\MostrarPratos.cshtml"
                                 if (!IdPratos.Contains(item.Id))
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "C:\Users\crist\OneDrive\Documentos\Source\tr2\Prato_do_Dia\lab\lab\Views\Restaurante\MostrarPratos.cshtml"
                               Write(Html.ActionLink("Adicionar aos Favoritos", "AdicionarPratosFavoritos", "Cliente", new { ID = item.Id }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "C:\Users\crist\OneDrive\Documentos\Source\tr2\Prato_do_Dia\lab\lab\Views\Restaurante\MostrarPratos.cshtml"
                                                                                                                                            
                                }
                                else
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "C:\Users\crist\OneDrive\Documentos\Source\tr2\Prato_do_Dia\lab\lab\Views\Restaurante\MostrarPratos.cshtml"
                               Write(Html.ActionLink("Eliminar dos Favoritos", "EliminarPratosFavoritos", "Cliente", new { ID = item.Id }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "C:\Users\crist\OneDrive\Documentos\Source\tr2\Prato_do_Dia\lab\lab\Views\Restaurante\MostrarPratos.cshtml"
                                                                                                                                          
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\r\n");
#nullable restore
#line 79 "C:\Users\crist\OneDrive\Documentos\Source\tr2\Prato_do_Dia\lab\lab\Views\Restaurante\MostrarPratos.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\r\n");
#nullable restore
#line 81 "C:\Users\crist\OneDrive\Documentos\Source\tr2\Prato_do_Dia\lab\lab\Views\Restaurante\MostrarPratos.cshtml"
                             if (Context.Session.GetString("Role") == "Cliente")
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ffe15c9c3db27b71360f3e303b4866690131f91e13892", async() => {
                WriteLiteral("\r\n                                    <div class=\"form-group\">\r\n                                        <button style=\"font-size : 10px;height: 120%;\" type=\"submit\" name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 2975, "\"", 2991, 1);
#nullable restore
#line 85 "C:\Users\crist\OneDrive\Documentos\Source\tr2\Prato_do_Dia\lab\lab\Views\Restaurante\MostrarPratos.cshtml"
WriteAttributeValue("", 2983, item.Id, 2983, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\">Avaliar Pratos</button>\r\n                                        <span class=\"text-danger\"></span>\r\n                                    </div>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 89 "C:\Users\crist\OneDrive\Documentos\Source\tr2\Prato_do_Dia\lab\lab\Views\Restaurante\MostrarPratos.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ffe15c9c3db27b71360f3e303b4866690131f91e16862", async() => {
                WriteLiteral("\r\n                                    <div class=\"form-group\">\r\n                                        <button style=\"font-size : 10px;height: 120%;\" type=\"submit\" name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 3572, "\"", 3588, 1);
#nullable restore
#line 94 "C:\Users\crist\OneDrive\Documentos\Source\tr2\Prato_do_Dia\lab\lab\Views\Restaurante\MostrarPratos.cshtml"
WriteAttributeValue("", 3580, item.Id, 3580, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\">Ver Avaliacões dos Pratos</button>\r\n                                        <span class=\"text-danger\"></span>\r\n                                    </div>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 98 "C:\Users\crist\OneDrive\Documentos\Source\tr2\Prato_do_Dia\lab\lab\Views\Restaurante\MostrarPratos.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 102 "C:\Users\crist\OneDrive\Documentos\Source\tr2\Prato_do_Dia\lab\lab\Views\Restaurante\MostrarPratos.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 103 "C:\Users\crist\OneDrive\Documentos\Source\tr2\Prato_do_Dia\lab\lab\Views\Restaurante\MostrarPratos.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<lab.Models.PratoDia>> Html { get; private set; }
    }
}
#pragma warning restore 1591