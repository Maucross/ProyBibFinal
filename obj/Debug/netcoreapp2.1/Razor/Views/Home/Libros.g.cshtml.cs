#pragma checksum "C:\Users\mau_a\Desktop\ProyBibFinalCopia\Views\Home\Libros.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87a0ee571aeaccc80162fe32038baa0f35d72a17"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Libros), @"mvc.1.0.view", @"/Views/Home/Libros.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Libros.cshtml", typeof(AspNetCore.Views_Home_Libros))]
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
#line 1 "C:\Users\mau_a\Desktop\ProyBibFinalCopia\Views\_ViewImports.cshtml"
using BIBLIOTECA;

#line default
#line hidden
#line 2 "C:\Users\mau_a\Desktop\ProyBibFinalCopia\Views\_ViewImports.cshtml"
using BIBLIOTECA.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87a0ee571aeaccc80162fe32038baa0f35d72a17", @"/Views/Home/Libros.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fb59b2b12801b84398ce2148826e2cb8425e430", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Libros : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Libro>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Libros", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "GET", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Libro", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\mau_a\Desktop\ProyBibFinalCopia\Views\Home\Libros.cshtml"
  
    var libros = Model;

#line default
#line hidden
            BeginContext(52, 32, true);
            WriteLiteral("\r\n<h1>Listado de Libros</h1>\r\n\r\n");
            EndContext();
            BeginContext(84, 203, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8df74f942bd249989727941b4c9622fb", async() => {
                BeginContext(123, 59, true);
                WriteLiteral("\r\n    <input type=\"text\" name=\"buscar\" class=\"form-control\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 182, "\"", 205, 1);
#line 9 "C:\Users\mau_a\Desktop\ProyBibFinalCopia\Views\Home\Libros.cshtml"
WriteAttributeValue("", 190, ViewBag.buscar, 190, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(206, 74, true);
                WriteLiteral("><br>\r\n    <button type=\"submit\" class=\"btn btn-primary\">Buscar</button>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(287, 253, true);
            WriteLiteral("\r\n<br>\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>Codigo de Libro</th>\r\n        <th>ISBN</th>\r\n        <th>Categoria</th>\r\n        <th>Titulo</th>\r\n        <th>Autor</th>\r\n        <th>Editorial</th>\r\n        <th>Año de publicacion</th>\r\n    </tr>\r\n\r\n");
            EndContext();
#line 24 "C:\Users\mau_a\Desktop\ProyBibFinalCopia\Views\Home\Libros.cshtml"
     foreach (var e in libros)
    {

#line default
#line hidden
            BeginContext(579, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(610, 39, false);
#line 27 "C:\Users\mau_a\Desktop\ProyBibFinalCopia\Views\Home\Libros.cshtml"
           Write(Html.DisplayFor(ModelItem => e.cod_lib));

#line default
#line hidden
            EndContext();
            BeginContext(649, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(673, 36, false);
#line 28 "C:\Users\mau_a\Desktop\ProyBibFinalCopia\Views\Home\Libros.cshtml"
           Write(Html.DisplayFor(ModelItem => e.ISBN));

#line default
#line hidden
            EndContext();
            BeginContext(709, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(733, 48, false);
#line 29 "C:\Users\mau_a\Desktop\ProyBibFinalCopia\Views\Home\Libros.cshtml"
           Write(Html.DisplayFor(ModelItem => e.Categoria.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(781, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(805, 38, false);
#line 30 "C:\Users\mau_a\Desktop\ProyBibFinalCopia\Views\Home\Libros.cshtml"
           Write(Html.DisplayFor(ModelItem => e.titulo));

#line default
#line hidden
            EndContext();
            BeginContext(843, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(867, 37, false);
#line 31 "C:\Users\mau_a\Desktop\ProyBibFinalCopia\Views\Home\Libros.cshtml"
           Write(Html.DisplayFor(ModelItem => e.autor));

#line default
#line hidden
            EndContext();
            BeginContext(904, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(928, 41, false);
#line 32 "C:\Users\mau_a\Desktop\ProyBibFinalCopia\Views\Home\Libros.cshtml"
           Write(Html.DisplayFor(ModelItem => e.editorial));

#line default
#line hidden
            EndContext();
            BeginContext(969, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(993, 39, false);
#line 33 "C:\Users\mau_a\Desktop\ProyBibFinalCopia\Views\Home\Libros.cshtml"
           Write(Html.DisplayFor(ModelItem => e.año_pub));

#line default
#line hidden
            EndContext();
            BeginContext(1032, 45, true);
            WriteLiteral("</td>\r\n            <td>    \r\n                ");
            EndContext();
            BeginContext(1077, 128, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b04b3b64b3649bbac9265c063de65f5", async() => {
                BeginContext(1192, 9, true);
                WriteLiteral("Modificar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 35 "C:\Users\mau_a\Desktop\ProyBibFinalCopia\Views\Home\Libros.cshtml"
                                                                                                           WriteLiteral(e.cod_lib);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1205, 38, true);
            WriteLiteral(" |\r\n                \r\n                ");
            EndContext();
            BeginContext(1243, 129, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e931586626164919ad9e97a9338e94a0", async() => {
                BeginContext(1360, 8, true);
                WriteLiteral("Eliminar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 37 "C:\Users\mau_a\Desktop\ProyBibFinalCopia\Views\Home\Libros.cshtml"
                                                                                                             WriteLiteral(e.cod_lib);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1372, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 40 "C:\Users\mau_a\Desktop\ProyBibFinalCopia\Views\Home\Libros.cshtml"
    }

#line default
#line hidden
            BeginContext(1415, 194, true);
            WriteLiteral("</table>\r\n<div class=\"row\">\r\n    <div style=\"text-align:right\" class=\"col-md-12\">\r\n        <a  class=\"btn btn-primary\" href=\"RegistrarLibro\">Regresar</a>\r\n         \r\n    </div>\r\n</div>\r\n\r\n    \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Libro>> Html { get; private set; }
    }
}
#pragma warning restore 1591
