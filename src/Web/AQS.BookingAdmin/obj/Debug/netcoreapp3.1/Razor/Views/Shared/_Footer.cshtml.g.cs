#pragma checksum "C:\Users\ThinkPro\Source\Repos\AQBooking_Solutions\src\Web\AQS.BookingAdmin\Views\Shared\_Footer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1425942955d92defc4d0eacaf7b6e4ca8c08d92c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Footer), @"mvc.1.0.view", @"/Views/Shared/_Footer.cshtml")]
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
#line 1 "C:\Users\ThinkPro\Source\Repos\AQBooking_Solutions\src\Web\AQS.BookingAdmin\Views\_ViewImports.cshtml"
using AQS.BookingAdmin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ThinkPro\Source\Repos\AQBooking_Solutions\src\Web\AQS.BookingAdmin\Views\_ViewImports.cshtml"
using AQS.BookingAdmin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ThinkPro\Source\Repos\AQBooking_Solutions\src\Web\AQS.BookingAdmin\Views\_ViewImports.cshtml"
using AQS.BookingAdmin.Infrastructure.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ThinkPro\Source\Repos\AQBooking_Solutions\src\Web\AQS.BookingAdmin\Views\_ViewImports.cshtml"
using AQS.BookingAdmin.Models.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ThinkPro\Source\Repos\AQBooking_Solutions\src\Web\AQS.BookingAdmin\Views\_ViewImports.cshtml"
using AQS.BookingAdmin.Infrastructure.AQPagination;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1425942955d92defc4d0eacaf7b6e4ca8c08d92c", @"/Views/Shared/_Footer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbc538716caba8d61ece7bb69ee98231840614e7", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Footer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<footer class=\"main-footer\">\r\n    <strong>Copyright &copy; ");
#nullable restore
#line 2 "C:\Users\ThinkPro\Source\Repos\AQBooking_Solutions\src\Web\AQS.BookingAdmin\Views\Shared\_Footer.cshtml"
                        Write(DateTime.Now.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <a href=\"http://aqbookig.com\">AQ Booking</a>.</strong>\r\n    All rights reserved.\r\n    <div class=\"float-right d-none d-sm-inline-block\">\r\n        <b>Version</b> 1.0.0\r\n    </div>\r\n</footer>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public AQS.BookingAdmin.Interfaces.User.IWorkContext WorkContext { get; private set; }
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
