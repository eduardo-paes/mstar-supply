#pragma checksum "/Users/Eduardo/Projects/MStartSupply/MStartSupply/Views/Mercadoria/Detalhes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5c2a77cd958f20115b7f0c23372501b41d957eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Mercadoria_Detalhes), @"mvc.1.0.view", @"/Views/Mercadoria/Detalhes.cshtml")]
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
#line 1 "/Users/Eduardo/Projects/MStartSupply/MStartSupply/Views/_ViewImports.cshtml"
using MStartSupply;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/Eduardo/Projects/MStartSupply/MStartSupply/Views/_ViewImports.cshtml"
using MStartSupply.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5c2a77cd958f20115b7f0c23372501b41d957eb", @"/Views/Mercadoria/Detalhes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c8060a555234f04ad424724f9f11bcdd7476904", @"/Views/_ViewImports.cshtml")]
    public class Views_Mercadoria_Detalhes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MStartSupply.Models.Mercadoria>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Editar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/Eduardo/Projects/MStartSupply/MStartSupply/Views/Mercadoria/Detalhes.cshtml"
  
    ViewData["Title"] = "Detalhes";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Informações</h1>\n\n<div>\n    <h4>Mercadoria</h4>\n    <hr />\n\n    <dl class=\"row\">\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 15 "/Users/Eduardo/Projects/MStartSupply/MStartSupply/Views/Mercadoria/Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.NumeroRegistro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 18 "/Users/Eduardo/Projects/MStartSupply/MStartSupply/Views/Mercadoria/Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.NumeroRegistro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 22 "/Users/Eduardo/Projects/MStartSupply/MStartSupply/Views/Mercadoria/Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 25 "/Users/Eduardo/Projects/MStartSupply/MStartSupply/Views/Mercadoria/Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 29 "/Users/Eduardo/Projects/MStartSupply/MStartSupply/Views/Mercadoria/Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.Quantidade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 32 "/Users/Eduardo/Projects/MStartSupply/MStartSupply/Views/Mercadoria/Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.Quantidade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 36 "/Users/Eduardo/Projects/MStartSupply/MStartSupply/Views/Mercadoria/Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.Fabricante));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 39 "/Users/Eduardo/Projects/MStartSupply/MStartSupply/Views/Mercadoria/Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.Fabricante));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 43 "/Users/Eduardo/Projects/MStartSupply/MStartSupply/Views/Mercadoria/Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.Tipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 46 "/Users/Eduardo/Projects/MStartSupply/MStartSupply/Views/Mercadoria/Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.Tipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 50 "/Users/Eduardo/Projects/MStartSupply/MStartSupply/Views/Mercadoria/Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.Descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 53 "/Users/Eduardo/Projects/MStartSupply/MStartSupply/Views/Mercadoria/Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.Descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n\n    </dl>\n</div>\n<div>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a5c2a77cd958f20115b7f0c23372501b41d957eb7733", async() => {
                WriteLiteral("Editar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 59 "/Users/Eduardo/Projects/MStartSupply/MStartSupply/Views/Mercadoria/Detalhes.cshtml"
                             WriteLiteral(Model.MercadoriaID);

#line default
#line hidden
#nullable disable
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
            WriteLiteral(" |\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a5c2a77cd958f20115b7f0c23372501b41d957eb9859", async() => {
                WriteLiteral("Voltar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MStartSupply.Models.Mercadoria> Html { get; private set; }
    }
}
#pragma warning restore 1591
