#pragma checksum "C:\Users\samuelbabalola\Downloads\BankSystem-master\src\Web\Api\CentralApi\Views\Payments\Process.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a89fbb3a3aa661f466773b5d42b4b83f89b71fbf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Payments_Process), @"mvc.1.0.view", @"/Views/Payments/Process.cshtml")]
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
#line 1 "C:\Users\samuelbabalola\Downloads\BankSystem-master\src\Web\Api\CentralApi\Views\_ViewImports.cshtml"
using CentralApi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\samuelbabalola\Downloads\BankSystem-master\src\Web\Api\CentralApi\Views\_ViewImports.cshtml"
using CentralApi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a89fbb3a3aa661f466773b5d42b4b83f89b71fbf", @"/Views/Payments/Process.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99b9c62fdfa090cb6d84fed6cf8dbdd8e956cea5", @"/Views/_ViewImports.cshtml")]
    public class Views_Payments_Process : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PaymentSelectBankViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card mt-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Continue", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\samuelbabalola\Downloads\BankSystem-master\src\Web\Api\CentralApi\Views\Payments\Process.cshtml"
  
    ViewData["Title"] = "Payment Gateway";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"text-center mx-auto w-75 my-4\">\n    <h3>");
#nullable restore
#line 8 "C:\Users\samuelbabalola\Downloads\BankSystem-master\src\Web\Api\CentralApi\Views\Payments\Process.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n    <hr/>\n\n    <h4>Amount: ???");
#nullable restore
#line 11 "C:\Users\samuelbabalola\Downloads\BankSystem-master\src\Web\Api\CentralApi\Views\Payments\Process.cshtml"
            Write(Model.Amount.ToString("f2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n    <h4>Description: ");
#nullable restore
#line 12 "C:\Users\samuelbabalola\Downloads\BankSystem-master\src\Web\Api\CentralApi\Views\Payments\Process.cshtml"
                Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a89fbb3a3aa661f466773b5d42b4b83f89b71fbf5437", async() => {
                WriteLiteral("\n        <div class=\"card-header\">\n            <h5>To continue, please select your bank</h5>\n        </div>\n        <div class=\"list-group list-group-flush text-left\">\n");
#nullable restore
#line 19 "C:\Users\samuelbabalola\Downloads\BankSystem-master\src\Web\Api\CentralApi\Views\Payments\Process.cshtml"
             foreach (var bank in Model.Banks)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <button type=\"submit\" class=\"list-group-item list-group-item-action\"\n                        name=\"bankId\"");
                BeginWriteAttribute("value", " value=\"", 683, "\"", 699, 1);
#nullable restore
#line 22 "C:\Users\samuelbabalola\Downloads\BankSystem-master\src\Web\Api\CentralApi\Views\Payments\Process.cshtml"
WriteAttributeValue("", 691, bank.Id, 691, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                    <div class=\"d-flex w-100 justify-content-between\">\n                        <p class=\"text-muted\">");
#nullable restore
#line 24 "C:\Users\samuelbabalola\Downloads\BankSystem-master\src\Web\Api\CentralApi\Views\Payments\Process.cshtml"
                                         Write(bank.Location);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n                        <small class=\"text-muted\">");
#nullable restore
#line 25 "C:\Users\samuelbabalola\Downloads\BankSystem-master\src\Web\Api\CentralApi\Views\Payments\Process.cshtml"
                                             Write(bank.SwiftCode);

#line default
#line hidden
#nullable disable
                WriteLiteral("</small>\n                    </div>\n                    <h5>");
#nullable restore
#line 27 "C:\Users\samuelbabalola\Downloads\BankSystem-master\src\Web\Api\CentralApi\Views\Payments\Process.cshtml"
                   Write(bank.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\n                </button>\n");
#nullable restore
#line 29 "C:\Users\samuelbabalola\Downloads\BankSystem-master\src\Web\Api\CentralApi\Views\Payments\Process.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PaymentSelectBankViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
