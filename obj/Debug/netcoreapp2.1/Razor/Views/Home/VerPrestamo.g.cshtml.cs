#pragma checksum "C:\Users\mau_a\Desktop\ProyBibFinalCopia\Views\Home\VerPrestamo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d9fc7023de213dc01965f894d6fa9786da8b234"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_VerPrestamo), @"mvc.1.0.view", @"/Views/Home/VerPrestamo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/VerPrestamo.cshtml", typeof(AspNetCore.Views_Home_VerPrestamo))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d9fc7023de213dc01965f894d6fa9786da8b234", @"/Views/Home/VerPrestamo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fb59b2b12801b84398ce2148826e2cb8425e430", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_VerPrestamo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Prestamo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Prestamos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "GET", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\mau_a\Desktop\ProyBibFinalCopia\Views\Home\VerPrestamo.cshtml"
  
    var prestamos = Model;

#line default
#line hidden
            BeginContext(58, 35, true);
            WriteLiteral("\r\n<h1>Listado de Prestamos</h1>\r\n\r\n");
            EndContext();
            BeginContext(93, 206, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1324dcf033334f1894dc725d8fc2f5bb", async() => {
                BeginContext(135, 59, true);
                WriteLiteral("\r\n    <input type=\"text\" name=\"buscar\" class=\"form-control\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 194, "\"", 217, 1);
#line 9 "C:\Users\mau_a\Desktop\ProyBibFinalCopia\Views\Home\VerPrestamo.cshtml"
WriteAttributeValue("", 202, ViewBag.buscar, 202, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(218, 74, true);
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
            BeginContext(299, 214, true);
            WriteLiteral("\r\n<br>\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>Codigo de Prestamo</th>\r\n        <th>Libro</th>\r\n        <th>Estudiante</th>\r\n        <th>Modalidad</th>\r\n        <th>fecha_reserva</th>\r\n        \r\n    </tr>\r\n\r\n");
            EndContext();
#line 23 "C:\Users\mau_a\Desktop\ProyBibFinalCopia\Views\Home\VerPrestamo.cshtml"
     foreach (var p in prestamos)
    {

#line default
#line hidden
            BeginContext(555, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(586, 41, false);
#line 26 "C:\Users\mau_a\Desktop\ProyBibFinalCopia\Views\Home\VerPrestamo.cshtml"
           Write(Html.DisplayFor(ModelItem => p.cod_prest));

#line default
#line hidden
            EndContext();
            BeginContext(627, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(651, 44, false);
#line 27 "C:\Users\mau_a\Desktop\ProyBibFinalCopia\Views\Home\VerPrestamo.cshtml"
           Write(Html.DisplayFor(ModelItem => p.Libro.titulo));

#line default
#line hidden
            EndContext();
            BeginContext(695, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(719, 47, false);
#line 28 "C:\Users\mau_a\Desktop\ProyBibFinalCopia\Views\Home\VerPrestamo.cshtml"
           Write(Html.DisplayFor(ModelItem => p.Estudiante.nomb));

#line default
#line hidden
            EndContext();
            BeginContext(766, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(790, 48, false);
#line 29 "C:\Users\mau_a\Desktop\ProyBibFinalCopia\Views\Home\VerPrestamo.cshtml"
           Write(Html.DisplayFor(ModelItem => p.Modalidad.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(838, 30, true);
            WriteLiteral("</td>       \r\n            <td>");
            EndContext();
            BeginContext(869, 45, false);
#line 30 "C:\Users\mau_a\Desktop\ProyBibFinalCopia\Views\Home\VerPrestamo.cshtml"
           Write(Html.DisplayFor(ModelItem => p.fecha_reserva));

#line default
#line hidden
            EndContext();
            BeginContext(914, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 32 "C:\Users\mau_a\Desktop\ProyBibFinalCopia\Views\Home\VerPrestamo.cshtml"
    }

#line default
#line hidden
            BeginContext(943, 194, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Prestamo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
