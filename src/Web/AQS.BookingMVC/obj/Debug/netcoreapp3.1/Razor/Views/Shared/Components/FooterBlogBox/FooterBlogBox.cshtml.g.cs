#pragma checksum "C:\Users\ThinkPro\source\repos\AQBooking_Solutions\src\Web\AQS.BookingMVC\Views\Shared\Components\FooterBlogBox\FooterBlogBox.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "826ebc3dd683ba89c6c44d2d297b8849d8e5804c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_FooterBlogBox_FooterBlogBox), @"mvc.1.0.view", @"/Views/Shared/Components/FooterBlogBox/FooterBlogBox.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"826ebc3dd683ba89c6c44d2d297b8849d8e5804c", @"/Views/Shared/Components/FooterBlogBox/FooterBlogBox.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32b11aa5c51b4073fa08706fd43711dcae89213e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_FooterBlogBox_FooterBlogBox : AQS.BookingMVC.Infrastructure.Mvc.AQSRazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ThinkPro\source\repos\AQBooking_Solutions\src\Web\AQS.BookingMVC\Views\Shared\Components\FooterBlogBox\FooterBlogBox.cshtml"
 if (WorkContext.IsComingSoon)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <section class=\"banner-mid-coming have-bg\"");
            BeginWriteAttribute("style", " style=\"", 115, "\"", 191, 3);
            WriteAttributeValue("", 123, "background-image:url(", 123, 21, true);
#nullable restore
#line 4 "C:\Users\ThinkPro\source\repos\AQBooking_Solutions\src\Web\AQS.BookingMVC\Views\Shared\Components\FooterBlogBox\FooterBlogBox.cshtml"
WriteAttributeValue("", 144, Url.Content("~/images/banner-mid-coming.png"), 144, 46, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 190, ")", 190, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <div class=\"content\">\r\n            <h4 class=\"sub-title\" style=\"text-transform: uppercase;\" data-aos=\"fade-up\" data-aos-duration=\"600\" data-aos-offset=\"-1000\">");
#nullable restore
#line 6 "C:\Users\ThinkPro\source\repos\AQBooking_Solutions\src\Web\AQS.BookingMVC\Views\Shared\Components\FooterBlogBox\FooterBlogBox.cshtml"
                                                                                                                                   Write(R("TRAVELBLOG"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n            <h3 class=\"title\" data-aos=\"fade-up\" data-aos-duration=\"800\" data-aos-delay=\"200\" data-aos-offset=\"-1000\">");
#nullable restore
#line 7 "C:\Users\ThinkPro\source\repos\AQBooking_Solutions\src\Web\AQS.BookingMVC\Views\Shared\Components\FooterBlogBox\FooterBlogBox.cshtml"
                                                                                                                 Write(R("EXPERIENCE"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <p class=\"text\" data-aos=\"fade-up\" data-aos-duration=\"1000\" data-aos-delay=\"400\" data-aos-offset=\"-1000\">");
#nullable restore
#line 8 "C:\Users\ThinkPro\source\repos\AQBooking_Solutions\src\Web\AQS.BookingMVC\Views\Shared\Components\FooterBlogBox\FooterBlogBox.cshtml"
                                                                                                                Write(R("ATTRACTIVE"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n    </section>\r\n");
#nullable restore
#line 11 "C:\Users\ThinkPro\source\repos\AQBooking_Solutions\src\Web\AQS.BookingMVC\Views\Shared\Components\FooterBlogBox\FooterBlogBox.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <section class=""home-block-6 have-bg"" style=""background-image:url(/images/home/block-6.jpg)"">
        <div class=""content"">
            <h3 class=""sub-title"" data-aos=""fade-up"" data-aos-duration=""600"" data-aos-offset=""-1000"">reward program</h3>
            <h2 class=""title"" data-aos=""fade-up"" data-aos-duration=""800"" data-aos-delay=""200"" data-aos-offset=""-1000"">A lifestyle reward program that goes beyond hotels and offers. </h2>
            <p class=""text"" data-aos=""fade-up"" data-aos-duration=""1000"" data-aos-delay=""400"" data-aos-offset=""-1000"">Join for FREE and get up to 10% extra off your next booking.</p><a class=""button"" href=""#"" data-aos=""fade-up"" data-aos-duration=""1200"" data-aos-delay=""600"" data-aos-offset=""-1000"">
                join for free<svg width=""36"" height=""25"" viewBox=""0 0 36 25"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"">
                    <path d=""M35.7804 12.3587L24.5377 1.1161C24.3225 0.902344 24.0026 0.837207 23.7208 0.953568C23.4405 1.06923 23.2583 1.34299 23.2583 1.64598");
            WriteLiteral(@"V3.14497C23.2583 3.34404 23.3373 3.53439 23.4779 3.67492L31.1926 11.3896H0.772971C0.358679 11.3897 0.0234375 11.7249 0.0234375 12.1392V13.6382C0.0234375 14.0525 0.358679 14.3877 0.772971 14.3877H31.1926L23.4779 22.1024C23.3373 22.2429 23.2583 22.4332 23.2583 22.6324V24.1314C23.2583 24.4344 23.4406 24.7081 23.7208 24.8238C23.8138 24.8625 23.9111 24.8809 24.0077 24.8809C24.2025 24.8809 24.3942 24.8048 24.5377 24.6613L35.7804 13.4186C36.0732 13.1258 36.0732 12.6515 35.7804 12.3587Z"" fill=""white"" />
                </svg>
            </a>
        </div>
    </section>
");
#nullable restore
#line 25 "C:\Users\ThinkPro\source\repos\AQBooking_Solutions\src\Web\AQS.BookingMVC\Views\Shared\Components\FooterBlogBox\FooterBlogBox.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IWorkContext WorkContext { get; private set; }
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