#pragma checksum "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reports\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6fe3f07d1fb2d1a59b5ae07f21864e2aaadbbc15"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Team_27_FinalProject.Views.Reports.Views_Reports_Details), @"mvc.1.0.view", @"/Views/Reports/Details.cshtml")]
namespace Team_27_FinalProject.Views.Reports
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
#line 5 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\_ViewImports.cshtml"
using Team_27_FinalProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fe3f07d1fb2d1a59b5ae07f21864e2aaadbbc15", @"/Views/Reports/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13a9abd40792cc501236f5738420887c32520cf8", @"/Views/_ViewImports.cshtml")]
    public class Views_Reports_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Team_27_FinalProject.Models.Reservation>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reports\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Report Detail</h1>\r\n\r\n<div>\r\n    <h4>Reservation</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reports\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Property.PropertyNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reports\Details.cshtml"
       Write(Html.DisplayFor(model => model.Property.PropertyNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reports\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ReservationID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reports\Details.cshtml"
       Write(Html.DisplayFor(model => model.ReservationID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reports\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reports\Details.cshtml"
       Write(Html.DisplayFor(model => model.RStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reports\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CheckinDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reports\Details.cshtml"
       Write(Html.DisplayFor(model => model.CheckinDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reports\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CheckoutDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reports\Details.cshtml"
       Write(Html.DisplayFor(model => model.CheckoutDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reports\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NumberOfGuests));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reports\Details.cshtml"
       Write(Html.DisplayFor(model => model.NumberOfGuests));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reports\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CleaningPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reports\Details.cshtml"
       Write(Html.DisplayFor(model => model.CleaningPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reports\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.WeekdayFee));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 59 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reports\Details.cshtml"
       Write(Html.DisplayFor(model => model.WeekdayFee));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 62 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reports\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.WeekendFee));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 65 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reports\Details.cshtml"
       Write(Html.DisplayFor(model => model.WeekendFee));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 68 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reports\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.StayPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 71 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reports\Details.cshtml"
       Write(Html.DisplayFor(model => model.StayPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 74 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reports\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsDiscounted));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 77 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reports\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsDiscounted));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 80 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reports\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Discount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 83 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reports\Details.cshtml"
       Write(Html.DisplayFor(model => model.Discount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 86 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reports\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NumberOfNights));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 89 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reports\Details.cshtml"
       Write(Html.DisplayFor(model => model.NumberOfNights));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 92 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reports\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Subtotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 95 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reports\Details.cshtml"
       Write(Html.DisplayFor(model => model.Subtotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 98 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reports\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SalesTax));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 101 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reports\Details.cshtml"
       Write(Html.DisplayFor(model => model.SalesTax));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 104 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reports\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ReservationTotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 107 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reports\Details.cshtml"
       Write(Html.DisplayFor(model => model.ReservationTotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 110 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reports\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Commission));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 113 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reports\Details.cshtml"
       Write(Html.DisplayFor(model => model.Commission));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 116 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reports\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.HostRevenue));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 119 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reports\Details.cshtml"
       Write(Html.DisplayFor(model => model.HostRevenue));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 122 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reports\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TotalEarning));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 125 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reports\Details.cshtml"
       Write(Html.DisplayFor(model => model.TotalEarning));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fe3f07d1fb2d1a59b5ae07f21864e2aaadbbc1517761", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Team_27_FinalProject.Models.Reservation> Html { get; private set; }
    }
}
#pragma warning restore 1591
