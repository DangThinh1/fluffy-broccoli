#pragma checksum "C:\Users\ThinkPro\Source\Repos\AQBooking_Solutions\src\Web\AQ_PGW.WebUI\Views\Home\Privacy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf67521e57dab16f79ae6c8890f8dcbfc421c450"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Privacy), @"mvc.1.0.view", @"/Views/Home/Privacy.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Privacy.cshtml", typeof(AspNetCore.Views_Home_Privacy))]
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
#line 1 "C:\Users\ThinkPro\Source\Repos\AQBooking_Solutions\src\Web\AQ_PGW.WebUI\Views\_ViewImports.cshtml"
using AQ_PGW.WebUI;

#line default
#line hidden
#line 2 "C:\Users\ThinkPro\Source\Repos\AQBooking_Solutions\src\Web\AQ_PGW.WebUI\Views\_ViewImports.cshtml"
using AQ_PGW.WebUI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf67521e57dab16f79ae6c8890f8dcbfc421c450", @"/Views/Home/Privacy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28973965709d1e119a59cb28316ec5e1b58f8f4f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Privacy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/listcard.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/card.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mb-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin: 20px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("border row"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\ThinkPro\Source\Repos\AQBooking_Solutions\src\Web\AQ_PGW.WebUI\Views\Home\Privacy.cshtml"
  
    ViewData["Title"] = "Privacy Policy";
    var currencyType = "usd1" == "usd" ? "en-us" : "en-HK";
    System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo(currencyType);
    double floating = Convert.ToDouble(10761.937554);
    var currencyAmount = floating.ToString("C", ci);

#line default
#line hidden
            BeginContext(315, 55, true);
            WriteLiteral("\r\n<div class=\"mb-4\" style=\"background-color:#eef1f3\">\r\n");
            EndContext();
            BeginContext(622, 163, true);
            WriteLiteral("    <div class=\"border mb-4\" style=\"background-color:#ffffff\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-8 ml-3\">\r\n                <h5> Đơn hàng: ");
            EndContext();
            BeginContext(787, 14, false);
#line 19 "C:\Users\ThinkPro\Source\Repos\AQBooking_Solutions\src\Web\AQ_PGW.WebUI\Views\Home\Privacy.cshtml"
                           Write(currencyAmount);

#line default
#line hidden
            EndContext();
            BeginContext(802, 176, true);
            WriteLiteral("</h5>\r\n            </div>\r\n            <div class=\"col\">\r\n                Số tiền\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div style=\"text-align:center\">\r\n        ");
            EndContext();
            BeginContext(978, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cf67521e57dab16f79ae6c8890f8dcbfc421c4506652", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1010, 118, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-12 example example3 mt-2\" id=\"example-3\" style=\"background-color:#ffffff\">\r\n        ");
            EndContext();
            BeginContext(1128, 2941, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf67521e57dab16f79ae6c8890f8dcbfc421c4507952", async() => {
                BeginContext(1153, 170, true);
                WriteLiteral("\r\n            <div class=\"col-6\">\r\n                <p class=\"h4 mb-4 text-center\"></p>\r\n\r\n                <div id=\"example3-card-number\" class=\"field empty mb-4\"></div>\r\n");
                EndContext();
                BeginContext(1432, 789, true);
                WriteLiteral(@"
                <input type=""text"" id=""nameCard"" class=""mb-4"" style=""width:100%"" placeholder=""Tên in trên thẻ"">

                <div class=""row col-12"">
                    <div id=""example3-card-expiry"" class=""field empty form-control"" style=""width:200px""></div>
                    <div id=""example3-card-cvc"" class=""field empty col-4 form-control"" style=""margin-left: auto;margin-right: -30px;""></div>
                </div>
                <div class=""row"">
                    <div class=""error col-4"" role=""alert"">
                        <span class=""message""></span>
                    </div>
                </div>


            </div>


            <div class=""col-md-6 d-flex justify-content-center align-items-center  border-left"">

                <span>");
                EndContext();
                BeginContext(2221, 63, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cf67521e57dab16f79ae6c8890f8dcbfc421c4509459", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2284, 29, true);
                WriteLiteral("</span>\r\n            </div>\r\n");
                EndContext();
                BeginContext(3688, 374, true);
                WriteLiteral(@"
            <div class=""col-12 d-flex justify-content-center align-items-center"">
                <button class=""col-lg-3 btn btn-warning my-4 ladda-button""  type=""submit"">Tiếp tục</button>
            </div>

            <button class=""btn btn-info ladda-button"" type=""submit"" id=""zoom"" data-style=""zoom-in""><span class=""ladda-label"">zoom-in</span></button>
        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4069, 26, true);
            WriteLiteral("\r\n    </div>\r\n\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(4112, 2684, true);
                WriteLiteral(@"
    <script type=""text/javascript"">

        $(""#zoom"").click(function () {
            debugger;
            //var l = Ladda.create(this);
            //l.start();
            //l.start();
            //l.stop();
            //l.toggle();
            //l.isLoading();
            //l.setProgress(0 - 1);
        })

        var elements = stripe.elements({
            fonts: [
                {
                    cssSrc: 'https://fonts.googleapis.com/css?family=Quicksand',
                },
            ],
            // Stripe's examples are localized to specific languages, but if
            // you wish to have Elements automatically detect your user's locale,
            // use `locale: 'auto'` instead.
            locale: window.__exampleLocale,
        });

        var elementStyles = {
            base: {
                //color: '#fff',
                lineHeight: '1.429',
                //fontWeight: 600,
                //fontFamily: 'Quicksand, Open Sans, Segoe UI, s");
                WriteLiteral(@"ans-serif',
                //fontSize: '16px',
                //fontSmoothing: 'antialiased',
                ':focus': {
                    color: '#424770',
                    //""box-shadow"": ""0 0 0 0.2rem rgba(0, 123, 255, 0.25)""
                },

                '::placeholder': {
                    color: '#9BACC8',
                },

                ':focus::placeholder': {
                    color: '#CFD7DF',
                },
            },
            invalid: {
                //color: '#fff',
                ':focus': {
                    color: '#FA755A',
                },
                '::placeholder': {
                    color: '#FFCCA5',
                },
            },
        };

        var elementClasses = {
            focus: 'focus',
            empty: 'empty',
            invalid: 'invalid',
        };

        var cardNumber = elements.create('cardNumber', {
            style: elementStyles,
            classes: elementClasses,
      ");
                WriteLiteral(@"      placeholder: 'Custom card number placeholder',
        });
        cardNumber.mount('#example3-card-number');

        var cardExpiry = elements.create('cardExpiry', {
            style: elementStyles,
            classes: elementClasses,
            placeholder: 'Ngày hết hạn',
        });
        cardExpiry.mount('#example3-card-expiry');

        var cardCvc = elements.create('cardCvc', {
            style: elementStyles,
            classes: elementClasses,
        });
        cardCvc.mount('#example3-card-cvc');

        registerElements([cardNumber, cardExpiry, cardCvc], 'example3');
    </script>
");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
