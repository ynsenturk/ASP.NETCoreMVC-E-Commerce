#pragma checksum "C:\Users\SENTURK\Desktop\Komple ASP.NET Web Geliştirme Eğitimi\Abc\Abc.Northwind.MvcWebUI\Views\Shared\Components\CartSummary\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d903461aa0046df6e003c084762e47f527983d63"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CartSummary_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CartSummary/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/CartSummary/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_CartSummary_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d903461aa0046df6e003c084762e47f527983d63", @"/Views/Shared/Components/CartSummary/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"468c66261d855ef2dbfffb2337a5516e6fcf099d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CartSummary_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Abc.Northwind.MvcWebUI.Models.CartSummaryViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(59, 73, true);
            WriteLiteral("\r\n<ul class=\"dropdown-menu\" role=\"menu\" aria-labelledby=\"dropdownMenu\">\r\n");
            EndContext();
#line 4 "C:\Users\SENTURK\Desktop\Komple ASP.NET Web Geliştirme Eğitimi\Abc\Abc.Northwind.MvcWebUI\Views\Shared\Components\CartSummary\Default.cshtml"
     foreach (var item in Model.Cart.CartLines)
    {

#line default
#line hidden
            BeginContext(188, 38, true);
            WriteLiteral("        <li>\r\n            <a href=\"#\">");
            EndContext();
            BeginContext(227, 24, false);
#line 7 "C:\Users\SENTURK\Desktop\Komple ASP.NET Web Geliştirme Eğitimi\Abc\Abc.Northwind.MvcWebUI\Views\Shared\Components\CartSummary\Default.cshtml"
                   Write(item.Product.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(251, 21, true);
            WriteLiteral(" <span class=\"badge\">");
            EndContext();
            BeginContext(273, 13, false);
#line 7 "C:\Users\SENTURK\Desktop\Komple ASP.NET Web Geliştirme Eğitimi\Abc\Abc.Northwind.MvcWebUI\Views\Shared\Components\CartSummary\Default.cshtml"
                                                                 Write(item.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(286, 28, true);
            WriteLiteral("</span></a>\r\n        </li>\r\n");
            EndContext();
#line 9 "C:\Users\SENTURK\Desktop\Komple ASP.NET Web Geliştirme Eğitimi\Abc\Abc.Northwind.MvcWebUI\Views\Shared\Components\CartSummary\Default.cshtml"
    }

#line default
#line hidden
            BeginContext(321, 150, true);
            WriteLiteral("    <li class=\"divider\"></li>\r\n    <li>\r\n        <a href=\"#\"><span class=\"glyphicon glyphicon-align-left glyphicon-shopping-cart\" aria-hidden=\"true\" >");
            EndContext();
            BeginContext(472, 16, false);
#line 12 "C:\Users\SENTURK\Desktop\Komple ASP.NET Web Geliştirme Eğitimi\Abc\Abc.Northwind.MvcWebUI\Views\Shared\Components\CartSummary\Default.cshtml"
                                                                                                        Write(Model.Cart.Total);

#line default
#line hidden
            EndContext();
            BeginContext(488, 73, true);
            WriteLiteral("</span></a>\r\n    </li>\r\n    <li class=\"divider\"></li>\r\n    <li>\r\n        ");
            EndContext();
            BeginContext(561, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "809a6c19981d4d33bdf9c6fdc4650bd0", async() => {
                BeginContext(605, 18, true);
                WriteLiteral("Go to cart details");
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
            BeginContext(627, 18, true);
            WriteLiteral("\r\n    </li>\r\n</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Abc.Northwind.MvcWebUI.Models.CartSummaryViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
