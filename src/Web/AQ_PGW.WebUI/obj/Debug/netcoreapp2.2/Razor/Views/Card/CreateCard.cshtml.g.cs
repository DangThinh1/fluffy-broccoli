#pragma checksum "C:\Users\ThinkPro\Source\Repos\AQBooking_Solutions\src\Web\AQ_PGW.WebUI\Views\Card\CreateCard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc7bda35e45bc06cfd17172df5275857632737bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Card_CreateCard), @"mvc.1.0.view", @"/Views/Card/CreateCard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Card/CreateCard.cshtml", typeof(AspNetCore.Views_Card_CreateCard))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc7bda35e45bc06cfd17172df5275857632737bd", @"/Views/Card/CreateCard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28973965709d1e119a59cb28316ec5e1b58f8f4f", @"/Views/_ViewImports.cshtml")]
    public class Views_Card_CreateCard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-group"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\ThinkPro\Source\Repos\AQBooking_Solutions\src\Web\AQ_PGW.WebUI\Views\Card\CreateCard.cshtml"
  
    ViewData["Title"] = "CreateCard";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(95, 104, true);
            WriteLiteral("\r\n<h1>CreateCard</h1>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-4 example3\" id=\"example-3\">\r\n        ");
            EndContext();
            BeginContext(199, 5181, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc7bda35e45bc06cfd17172df5275857632737bd4214", async() => {
                BeginContext(224, 237, true);
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <label for=\"InputNumber\">Card number</label>\r\n                <div id=\"example3-card-number\" class=\"field empty mb-4\" style=\"border: 1px solid #ced4da;\">\r\n\r\n                </div>\r\n");
                EndContext();
                BeginContext(593, 1392, true);
                WriteLiteral(@"            </div>

            <div class=""form-group"">
                <div class=""row"">
                    <div class=""col align-self-start""><label>Expiration date</label></div>
                    <div class=""col align-self-end""><label>Security code</label></div>
                </div>

                <div class=""form-row"">
                    <div class=""col align-self-start"">
                        <div id=""example3-card-expiry"" class=""field empty form-control"" style=""border: 1px solid #ced4da;""></div>

                    </div>
                    <div class=""col align-self-end"">
                        <div id=""example3-card-cvc"" class=""field empty form-control"" style=""border: 1px solid #ced4da;""></div>

                    </div>
                </div>
                <div class=""error"" role=""alert"">
                    <span class=""message"" style=""color:#db4343""></span>
                </div>
            </div>
            <div class=""form-group"">
                <div clas");
                WriteLiteral(@"s=""form-row"">
                    <label class=""col-md-6"">Card holder name</label>
                    <label class=""col-md-4"">Last name</label>
                </div>
                <div class=""form-row"">
                    <div class=""col"">
                        <input class=""form-control"" id=""example3-FisrtName"" pattern=""[a-z][\s ]+{1,15}"" required />
");
                EndContext();
                BeginContext(2271, 183, true);
                WriteLiteral("                    </div>\r\n                    <div class=\"col\">\r\n                        <input class=\"form-control\" id=\"example3-LastName\" pattern=\"[a-z][\\s ]+{1,15}\" required />\r\n");
                EndContext();
                BeginContext(2651, 349, true);
                WriteLiteral(@"                    </div>
                </div>
            </div>


            <label class=""control-label"" for=""Currency"">Billing address</label>
            <div class=""form-group"">
                <label class=""control-label"" for=""Currency"">Address line 1</label>
                <input class=""form-control"" id=""example3-address"" />
");
                EndContext();
                BeginContext(3205, 224, true);
                WriteLiteral("            </div>\r\n            <div class=\"form-group\">\r\n                <label class=\"control-label\" for=\"Currency\">Address line 2 (Optional)</label>\r\n                <input class=\"form-control\" id=\"example3-address2\" />\r\n");
                EndContext();
                BeginContext(3634, 201, true);
                WriteLiteral("            </div>\r\n\r\n            <div class=\"form-group\">\r\n                <label class=\"control-label\" for=\"Currency\">City</label>\r\n                <input class=\"form-control\" id=\"example3-city\" />\r\n");
                EndContext();
                BeginContext(4024, 214, true);
                WriteLiteral("            </div>\r\n\r\n\r\n            <div class=\"form-group\">\r\n                <label class=\"control-label\" for=\"Currency\">Province/State</label>\r\n                <input class=\"form-control\" id=\"example3-state\" />\r\n");
                EndContext();
                BeginContext(4443, 230, true);
                WriteLiteral("            </div>\r\n\r\n            <div class=\"form-group\">\r\n                <label class=\"control-label\" for=\"Currency\">Country/Region</label>\r\n                <select class=\"form-control\" id=\"example3-address-country\"></select>\r\n");
                EndContext();
                BeginContext(4757, 209, true);
                WriteLiteral("            </div>\r\n\r\n            <div class=\"form-group\">\r\n                <label class=\"control-label\" for=\"Currency\">Post/Zip code</label>\r\n                <input class=\"form-control\" id=\"example3-zip\" />\r\n");
                EndContext();
                BeginContext(5169, 204, true);
                WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <button type=\"submit\" class=\"btn btn-primary ladda-button\" id=\"btnCreateCard\">Create Card</button>\r\n            </div>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5380, 24, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(5421, 600, true);
                WriteLiteral(@"
    <script>
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
            //var date = {};
            //string tokenCard, string cusID
            function CallCard(tokenCard, cusID) {
                cusID = ""cus_Eue2iFwuOLZHmJ"";
                //debugger;
                $.ajax({
                    url: '");
                EndContext();
                BeginContext(6022, 37, false);
#line 128 "C:\Users\ThinkPro\Source\Repos\AQBooking_Solutions\src\Web\AQ_PGW.WebUI\Views\Card\CreateCard.cshtml"
                     Write(Url.Action("CreateTokenCard", "Card"));

#line default
#line hidden
                EndContext();
                BeginContext(6059, 4972, true);
                WriteLiteral(@"',
                    type: ""POST"",
                    data: { tokenCard: tokenCard, cusID: cusID},
                    success: function (data) {
                        var res = data
                        console.log(""res"", res);
                        alert(data);
                    },
                    error: function () {
                        console.log(""Error"");
                    }
                })
            }
            //$('#btnCreateCard').click(function () {
            //    debugger;
            //    //var cardnumber = $(""input[name=cardnumber]"").value
            //    //var expmonth = $(""input[name=exp-date]"").value.split(""/"")[0]
            //    //var expyear = $(""input[name=exp-date]"").value.split(""/"")[1]
            //    //var cvcname = $(""input[name=cvc]"").value
            //    var nameCard = $(""#name"").value
            //    var addressCard1 = $(""#address1"").value
            //    var addressCard2 = $(""#address2"").value
            //    var ");
                WriteLiteral(@"cityCard = $(""#city"").value
            //    var provinceCard = $(""#province"").value
            //    var countryCard = $(""#country"").value
            //    var CodeCard = $(""#postCode"").value

            //    date = {
            //        CardNumber: cardnumber,
            //        Exp_Month: expmonth,
            //        Exp_Year: expyear,
            //        CVC: cvcname,
            //        Name: nameCard,
            //        Address1: addressCard1,
            //        Address2: addressCard2,
            //        City: cityCard,
            //        Province: provinceCard,
            //        Country: countryCard,
            //        ZipCode: CodeCard
            //    }
            //    //CallCard();
            //})
            var hostLocal = window.location.href;
            var file = hostLocal.slice(0, hostLocal.indexOf(window.location.pathname));
            $.getJSON(file + '/jsonData/countries.json',
                function (data) {
              ");
                WriteLiteral(@"      var html = '';
                    var len = data.length;
                    for (var i = 0; i < len; i++) {
                        if (data[i].code == ""SG"") {
                            html += '<option value=""' + data[i].code + '"" selected>' + data[i].name + '</option>'
                        } else {
                            html += '<option value=""' + data[i].code + '"">' + data[i].name + '</option>';
                        }
                    }
                    $('#example3-address-country').append(html);
                });

            var elements = stripe.elements({
                fonts: [
                    {
                        cssSrc: 'https://fonts.googleapis.com/css?family=Quicksand',
                    },
                ],
                // Stripe's examples are localized to specific languages, but if
                // you wish to have Elements automatically detect your user's locale,
                // use `locale: 'auto'` instead.
             ");
                WriteLiteral(@"   locale: window.__exampleLocale,
            });

            var elementStyles = {
                base: {
                    lineHeight: '1.429',
                    ':focus': {
                        color: '#424770',
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

            var cardNumber = elements.create('cardNumbe");
                WriteLiteral(@"r', {
                style: elementStyles,
                classes: elementClasses,
                placeholder: 'Card number',
            });
            cardNumber.mount('#example3-card-number');

            var cardExpiry = elements.create('cardExpiry', {
                style: elementStyles,
                classes: elementClasses,
                placeholder: 'MM/YY',
            });
            cardExpiry.mount('#example3-card-expiry');

            var cardCvc = elements.create('cardCvc', {
                style: elementStyles,
                classes: elementClasses,
            });
            cardCvc.mount('#example3-card-cvc');

            registerElements([cardNumber, cardExpiry, cardCvc], 'example3', (result) => {
                console.log(result);
                CallCard(result.token.id);
            });
    </script>
");
                EndContext();
            }
            );
            BeginContext(11034, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
