#pragma checksum "C:\Users\ThinkPro\source\repos\AQBooking_Solutions\src\Web\AQS.BookingMVC\Views\User\_RegisterModal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47f600cd4ee4be947c276a646a34236e385e1d31"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User__RegisterModal), @"mvc.1.0.view", @"/Views/User/_RegisterModal.cshtml")]
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
#line 2 "C:\Users\ThinkPro\source\repos\AQBooking_Solutions\src\Web\AQS.BookingMVC\Views\_ViewImports.cshtml"
using AQS.BookingMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ThinkPro\source\repos\AQBooking_Solutions\src\Web\AQS.BookingMVC\Views\_ViewImports.cshtml"
using AQS.BookingMVC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ThinkPro\source\repos\AQBooking_Solutions\src\Web\AQS.BookingMVC\Views\_ViewImports.cshtml"
using AQS.BookingMVC.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ThinkPro\source\repos\AQBooking_Solutions\src\Web\AQS.BookingMVC\Views\_ViewImports.cshtml"
using AQS.BookingMVC.Infrastructure.Enum;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ThinkPro\source\repos\AQBooking_Solutions\src\Web\AQS.BookingMVC\Views\_ViewImports.cshtml"
using AQS.BookingMVC.Infrastructure.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\ThinkPro\source\repos\AQBooking_Solutions\src\Web\AQS.BookingMVC\Views\User\_RegisterModal.cshtml"
using Identity.Core.Models.Users;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47f600cd4ee4be947c276a646a34236e385e1d31", @"/Views/User/_RegisterModal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32b11aa5c51b4073fa08706fd43711dcae89213e", @"/Views/_ViewImports.cshtml")]
    public class Views_User__RegisterModal : AQS.BookingMVC.Infrastructure.Mvc.AQSRazorPage<UserCreateModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-signin"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/reset/password/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-reset"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/signup/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-signup"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
<h1>_Register</h1>

<div class=""modal fade"" tabindex=""-1"" role=""dialog"" id=""modalRegister"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close""><span aria-hidden=""true"">&times;</span></button>
                <h4 class=""modal-title"">Modal title</h4>
            </div>
            <div class=""modal-body"">
                <div id=""logreg-forms"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47f600cd4ee4be947c276a646a34236e385e1d316546", async() => {
                WriteLiteral(@"
                        <h1 class=""h3 mb-3 font-weight-normal"" style=""text-align: center""> Sign in</h1>
                        <div class=""social-login"">
                            <button class=""btn facebook-btn social-btn"" type=""button""><span><i class=""fab fa-facebook-f""></i> Sign in with Facebook</span> </button>
                            <button class=""btn google-btn social-btn"" type=""button""><span><i class=""fab fa-google-plus-g""></i> Sign in with Google+</span> </button>
                        </div>
                        <p style=""text-align:center""> OR  </p>
                        <input type=""email"" id=""inputEmail"" class=""form-control"" placeholder=""Email address""");
                BeginWriteAttribute("required", " required=\"", 1322, "\"", 1333, 0);
                EndWriteAttribute();
                BeginWriteAttribute("autofocus", " autofocus=\"", 1334, "\"", 1346, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <input type=\"password\" id=\"inputPassword\" class=\"form-control\" placeholder=\"Password\"");
                BeginWriteAttribute("required", " required=\"", 1459, "\"", 1470, 0);
                EndWriteAttribute();
                WriteLiteral(@">

                        <button class=""btn btn-success btn-block"" type=""submit""><i class=""fas fa-sign-in-alt""></i> Sign in</button>
                        <a href=""#"" id=""forgot_pswd"">Forgot password?</a>
                        <hr>
                        <!-- <p>Don't have an account!</p>  -->
                        <button class=""btn btn-primary btn-block"" type=""button"" id=""btn-signup""><i class=""fas fa-user-plus""></i> Sign up New Account</button>
                    ");
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
            WriteLiteral("\r\n\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47f600cd4ee4be947c276a646a34236e385e1d319679", async() => {
                WriteLiteral("\r\n                        <input type=\"email\" id=\"resetEmail\" class=\"form-control\" placeholder=\"Email address\"");
                BeginWriteAttribute("required", " required=\"", 2150, "\"", 2161, 0);
                EndWriteAttribute();
                BeginWriteAttribute("autofocus", " autofocus=\"", 2162, "\"", 2174, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <button class=\"btn btn-primary btn-block\" type=\"submit\">Reset Password</button>\r\n                        <a href=\"#\" id=\"cancel_reset\"><i class=\"fas fa-angle-left\"></i> Back</a>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47f600cd4ee4be947c276a646a34236e385e1d3111745", async() => {
                WriteLiteral(@"
                        <div class=""social-login"">
                            <button class=""btn facebook-btn social-btn"" type=""button""><span><i class=""fab fa-facebook-f""></i> Sign up with Facebook</span> </button>
                        </div>
                        <div class=""social-login"">
                            <button class=""btn google-btn social-btn"" type=""button""><span><i class=""fab fa-google-plus-g""></i> Sign up with Google+</span> </button>
                        </div>

                        <p style=""text-align:center"">OR</p>

                        <input type=""text"" id=""user-name"" class=""form-control"" placeholder=""Full name""");
                BeginWriteAttribute("required", " required=\"", 3145, "\"", 3156, 0);
                EndWriteAttribute();
                BeginWriteAttribute("autofocus", " autofocus=\"", 3157, "\"", 3169, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <input type=\"email\" id=\"user-email\" class=\"form-control\" placeholder=\"Email address\" required");
                BeginWriteAttribute("autofocus", " autofocus=\"", 3290, "\"", 3302, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <input type=\"password\" id=\"user-pass\" class=\"form-control\" placeholder=\"Password\" required");
                BeginWriteAttribute("autofocus", " autofocus=\"", 3420, "\"", 3432, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <input type=\"password\" id=\"user-repeatpass\" class=\"form-control\" placeholder=\"Repeat Password\" required");
                BeginWriteAttribute("autofocus", " autofocus=\"", 3563, "\"", 3575, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n                        <button class=\"btn btn-primary btn-block\" type=\"submit\"><i class=\"fas fa-user-plus\"></i> Sign Up</button>\r\n                        <a href=\"#\" id=\"cancel_signup\"><i class=\"fas fa-angle-left\"></i> Back</a>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    <br>

                </div>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Close</button>
                <button type=""button"" class=""btn btn-primary"">Save changes</button>
            </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserCreateModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
