#pragma checksum "C:\Users\alexg\OneDrive\Escritorio\prueba-master 2 2 2\ProyectoED1\ProyectoED1\Views\Tabla\Tablas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b59859b08e07cef6e9c45982ff6d50d4e9fbac4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tabla_Tablas), @"mvc.1.0.view", @"/Views/Tabla/Tablas.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tabla/Tablas.cshtml", typeof(AspNetCore.Views_Tabla_Tablas))]
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
#line 1 "C:\Users\alexg\OneDrive\Escritorio\prueba-master 2 2 2\ProyectoED1\ProyectoED1\Views\_ViewImports.cshtml"
using ProyectoED1;

#line default
#line hidden
#line 2 "C:\Users\alexg\OneDrive\Escritorio\prueba-master 2 2 2\ProyectoED1\ProyectoED1\Views\_ViewImports.cshtml"
using ProyectoED1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b59859b08e07cef6e9c45982ff6d50d4e9fbac4", @"/Views/Tabla/Tablas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbe78bb0fb929845864c5a545fd120aafe813711", @"/Views/_ViewImports.cshtml")]
    public class Views_Tabla_Tablas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProyectoED1.Models.DefTabla>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Comando", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\alexg\OneDrive\Escritorio\prueba-master 2 2 2\ProyectoED1\ProyectoED1\Views\Tabla\Tablas.cshtml"
  
    ViewData["Title"] = "Tablas";

#line default
#line hidden
            BeginContext(88, 26, true);
            WriteLiteral("\n<h2>Tablas</h2>\n\n<p>\n    ");
            EndContext();
            BeginContext(114, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6eaf81411845488090e9aa7a16e98d6d", async() => {
                BeginContext(162, 17, true);
                WriteLiteral("Ingresar comandos");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(183, 86, true);
            WriteLiteral("\n</p>\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
            EndContext();
            BeginContext(270, 42, false);
#line 16 "C:\Users\alexg\OneDrive\Escritorio\prueba-master 2 2 2\ProyectoED1\ProyectoED1\Views\Tabla\Tablas.cshtml"
           Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(312, 80, true);
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
            EndContext();
#line 22 "C:\Users\alexg\OneDrive\Escritorio\prueba-master 2 2 2\ProyectoED1\ProyectoED1\Views\Tabla\Tablas.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(423, 46, true);
            WriteLiteral("        <tr>\n            <td>\n                ");
            EndContext();
            BeginContext(470, 41, false);
#line 25 "C:\Users\alexg\OneDrive\Escritorio\prueba-master 2 2 2\ProyectoED1\ProyectoED1\Views\Tabla\Tablas.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(511, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(564, 65, false);
#line 28 "C:\Users\alexg\OneDrive\Escritorio\prueba-master 2 2 2\ProyectoED1\ProyectoED1\Views\Tabla\Tablas.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(629, 19, true);
            WriteLiteral(" |\n                ");
            EndContext();
            BeginContext(649, 71, false);
#line 29 "C:\Users\alexg\OneDrive\Escritorio\prueba-master 2 2 2\ProyectoED1\ProyectoED1\Views\Tabla\Tablas.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(720, 19, true);
            WriteLiteral(" |\n                ");
            EndContext();
            BeginContext(740, 69, false);
#line 30 "C:\Users\alexg\OneDrive\Escritorio\prueba-master 2 2 2\ProyectoED1\ProyectoED1\Views\Tabla\Tablas.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(809, 33, true);
            WriteLiteral("\n            </td>\n        </tr>\n");
            EndContext();
#line 33 "C:\Users\alexg\OneDrive\Escritorio\prueba-master 2 2 2\ProyectoED1\ProyectoED1\Views\Tabla\Tablas.cshtml"
}

#line default
#line hidden
            BeginContext(844, 22, true);
            WriteLiteral("    </tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProyectoED1.Models.DefTabla>> Html { get; private set; }
    }
}
#pragma warning restore 1591
