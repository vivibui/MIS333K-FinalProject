#pragma checksum "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Orders\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a94754526e9ae61966a7a6a329e1affb65156d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Team_27_FinalProject.Views.Orders.Views_Orders_Details), @"mvc.1.0.view", @"/Views/Orders/Details.cshtml")]
namespace Team_27_FinalProject.Views.Orders
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a94754526e9ae61966a7a6a329e1affb65156d3", @"/Views/Orders/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13a9abd40792cc501236f5738420887c32520cf8", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Team_27_FinalProject.Models.Order>
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
#line 3 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Orders\Details.cshtml"
   ViewData["Title"] = "Details"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Order</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n\r\n        <!-- Customer Email -->\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AppUser.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.AppUser.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <!-- Order Number -->\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 22 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OrderNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 25 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.OrderNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <!-- Order Date -->\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 30 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OrderDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 33 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.OrderDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <!-- Order Status -->\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.OStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </dd>

    </dl>
</div>

<!-- Display Order Details -->
<h5>Products on this Order</h5>
<table class=""table table-primary"">
    <tr>
        <th>Property Street</th>
        <th>Property Zip</th>
        <th>Property State</th>
        <th>Weekday Fee</th>
        <th>Weekend Fee</th>
        <th>Number of Nights</th>
        <th>Reservation Subtotal</th>
    </tr>
");
#nullable restore
#line 59 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Orders\Details.cshtml"
     foreach (Reservation rd in Model.Reservations)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 62 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Orders\Details.cshtml"
           Write(Html.DisplayFor(ModelItem => rd.Property.Street));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 63 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Orders\Details.cshtml"
           Write(Html.DisplayFor(ModelItem => rd.Property.Zip));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 64 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Orders\Details.cshtml"
           Write(Html.DisplayFor(ModelItem => rd.Property.State));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 65 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Orders\Details.cshtml"
           Write(Html.DisplayFor(ModelItem => rd.WeekdayFee));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 66 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Orders\Details.cshtml"
           Write(Html.DisplayFor(ModelItem => rd.WeekendFee));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 67 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Orders\Details.cshtml"
           Write(Html.DisplayFor(ModelItem => rd.NumberOfNights));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 68 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Orders\Details.cshtml"
           Write(Html.DisplayFor(ModelItem => rd.Subtotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 70 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Orders\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</table>

<!-- Order Summary -->
<h5>Order Summary</h5>
<table class=""table table-sm table-bordered"" style=""width:30%"">
    <tr>
        <th colspan=""2"" style=""text-align:center"">Order Summary</th>
    </tr>
    <tr>
        <td>Order subtotal:</td>
        <td>");
#nullable restore
#line 81 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.OrderSubtotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Sales tax:</td>\r\n        <td>");
#nullable restore
#line 85 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.SalesTax));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Order total:</td>\r\n        <td>");
#nullable restore
#line 89 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.OrderTotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n\r\n</table>\r\n\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a94754526e9ae61966a7a6a329e1affb65156d311402", async() => {
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
            WriteLiteral("\r\n</div>\r\n<br />\r\n<br />\r\n<br />");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Team_27_FinalProject.Models.Order> Html { get; private set; }
    }
}
#pragma warning restore 1591
