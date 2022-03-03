#pragma checksum "C:\Users\dchin\OneDrive\Documents\GitHub\Amazon\Amazon\Pages\CheckOut.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cfc0a6e46a524e5a42ed178597713a2fa7d135a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_CheckOut), @"mvc.1.0.razor-page", @"/Pages/CheckOut.cshtml")]
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
#line 2 "C:\Users\dchin\OneDrive\Documents\GitHub\Amazon\Amazon\Pages\_ViewImports.cshtml"
using Amazon.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cfc0a6e46a524e5a42ed178597713a2fa7d135a9", @"/Pages/CheckOut.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3fad3609c941147c8424d37e2b39e87f27e46438", @"/Pages/_ViewImports.cshtml")]
    public class Pages_CheckOut : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Remove", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h2>Your Basket</h2>

<table class=""table table-bordered table-striped"">

    <thead>
        <tr>
            <th>Item</th>
            <th>Quantity</th>
            <th>Cost</th>
            <th>Subtotal</th>
        </tr>
    </thead>

    <tbody>
");
#nullable restore
#line 20 "C:\Users\dchin\OneDrive\Documents\GitHub\Amazon\Amazon\Pages\CheckOut.cshtml"
         foreach (var i in Model.basket.Items)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\dchin\OneDrive\Documents\GitHub\Amazon\Amazon\Pages\CheckOut.cshtml"
           Write(i.Book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\dchin\OneDrive\Documents\GitHub\Amazon\Amazon\Pages\CheckOut.cshtml"
           Write(i.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\dchin\OneDrive\Documents\GitHub\Amazon\Amazon\Pages\CheckOut.cshtml"
            Write((i.Book.Price).ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\dchin\OneDrive\Documents\GitHub\Amazon\Amazon\Pages\CheckOut.cshtml"
            Write((i.Quantity * i.Book.Price).ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n            <td class=\"text-center\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cfc0a6e46a524e5a42ed178597713a2fa7d135a95238", async() => {
                WriteLiteral("\r\n                    <input type=\"hidden\" name=\"bookId\"");
                BeginWriteAttribute("value", " value=\"", 732, "\"", 754, 1);
#nullable restore
#line 30 "C:\Users\dchin\OneDrive\Documents\GitHub\Amazon\Amazon\Pages\CheckOut.cshtml"
WriteAttributeValue("", 740, i.Book.BookId, 740, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <input type=\"hidden\" name=\"returnUrl\"");
                BeginWriteAttribute("value", " value=\"", 817, "\"", 841, 1);
#nullable restore
#line 31 "C:\Users\dchin\OneDrive\Documents\GitHub\Amazon\Amazon\Pages\CheckOut.cshtml"
WriteAttributeValue("", 825, Model.ReturnUrl, 825, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <button type=\"submit\" class=\"btn btn-sm btn-danger\">Remove</button>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 36 "C:\Users\dchin\OneDrive\Documents\GitHub\Amazon\Amazon\Pages\CheckOut.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n\r\n    <tfoot>\r\n        <tr>\r\n            <td colspan=\"3\">Total:</td>\r\n            <td>");
#nullable restore
#line 42 "C:\Users\dchin\OneDrive\Documents\GitHub\Amazon\Amazon\Pages\CheckOut.cshtml"
           Write(Model.basket.CalculateTotal().ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n    </tfoot>\r\n\r\n</table>\r\n\r\n<div>\r\n    <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 1237, "\"", 1260, 1);
#nullable restore
#line 49 "C:\Users\dchin\OneDrive\Documents\GitHub\Amazon\Amazon\Pages\CheckOut.cshtml"
WriteAttributeValue("", 1244, Model.ReturnUrl, 1244, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Continue Shopping</a>\r\n    <a class=\"tbn btn-primary\">Checkout</a>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Amazon.Pages.CheckOutModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Amazon.Pages.CheckOutModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Amazon.Pages.CheckOutModel>)PageContext?.ViewData;
        public Amazon.Pages.CheckOutModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591