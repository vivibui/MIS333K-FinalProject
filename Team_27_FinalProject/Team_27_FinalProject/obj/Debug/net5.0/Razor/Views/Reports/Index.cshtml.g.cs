#pragma checksum "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reports\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2fee35281bbdc79816d05401f56a808a22ae1bd2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Team_27_FinalProject.Views.Reports.Views_Reports_Index), @"mvc.1.0.view", @"/Views/Reports/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fee35281bbdc79816d05401f56a808a22ae1bd2", @"/Views/Reports/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13a9abd40792cc501236f5738420887c32520cf8", @"/Views/_ViewImports.cshtml")]
    public class Views_Reports_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Team_27_FinalProject.Models.Reservation>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DetailedSearch", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Reports", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reports\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Report</h1>\r\n\r\n<th>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2fee35281bbdc79816d05401f56a808a22ae1bd24359", async() => {
                WriteLiteral("Search Report");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</th>\r\n\r\n<p>Showing ");
#nullable restore
#line 13 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reports\Index.cshtml"
      Write(ViewBag.SelectedReservations);

#line default
#line hidden
#nullable disable
            WriteLiteral(" of ");
#nullable restore
#line 13 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reports\Index.cshtml"
                                       Write(ViewBag.AllReservations);

#line default
#line hidden
#nullable disable
            WriteLiteral(" reservations</p>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reports\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Property));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reports\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.RStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n");
            WriteLiteral("            <th>\r\n                ");
#nullable restore
#line 34 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reports\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.WeekdayFee));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reports\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.WeekendFee));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 40 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reports\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.StayPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 43 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reports\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IsDiscounted));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 46 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reports\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Discount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n");
            WriteLiteral("            <th>\r\n                ");
#nullable restore
#line 58 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reports\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ReservationTotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n");
#nullable restore
#line 60 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reports\Index.cshtml"
             if (User.IsInRole("Admin"))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <th>\r\n                    ");
#nullable restore
#line 63 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reports\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Commission));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n");
#nullable restore
#line 65 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reports\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <th>\r\n                ");
#nullable restore
#line 67 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reports\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.HostRevenue));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 70 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reports\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CleaningPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 73 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reports\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TotalEarning));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 76 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reports\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TotalEarning));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 82 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reports\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 86 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reports\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Property.PropertyNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 89 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reports\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.RStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n");
            WriteLiteral("                <td>\r\n                    ");
#nullable restore
#line 101 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reports\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.WeekdayFee));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 104 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reports\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.WeekendFee));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 107 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reports\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.StayPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 110 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reports\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.IsDiscounted));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 113 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reports\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Discount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n");
            WriteLiteral("                <td>\r\n                    ");
#nullable restore
#line 125 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reports\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ReservationTotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n");
#nullable restore
#line 127 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reports\Index.cshtml"
                 if (User.IsInRole("Admin"))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>\r\n                        ");
#nullable restore
#line 130 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reports\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Commission));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n");
#nullable restore
#line 132 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reports\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>\r\n                    ");
#nullable restore
#line 134 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reports\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.HostRevenue));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 137 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reports\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.CleaningPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 140 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reports\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.TotalEarning));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n\r\n                    ");
#nullable restore
#line 144 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reports\Index.cshtml"
               Write(Html.ActionLink("Details", "Details", new { id = item.ReservationID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 148 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reports\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Team_27_FinalProject.Models.Reservation>> Html { get; private set; }
    }
}
#pragma warning restore 1591