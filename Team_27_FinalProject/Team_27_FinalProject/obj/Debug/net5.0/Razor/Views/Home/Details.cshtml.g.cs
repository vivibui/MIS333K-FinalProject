#pragma checksum "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5cbc8e2dba6e9b68ce18319918057a1a7cbeef75"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Team_27_FinalProject.Views.Home.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
namespace Team_27_FinalProject.Views.Home
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cbc8e2dba6e9b68ce18319918057a1a7cbeef75", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13a9abd40792cc501236f5738420887c32520cf8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Team_27_FinalProject.Models.Property>
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
#line 3 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Home\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Property</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <!--TODO: Add authorization to Property Number-->\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Home\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PropertyNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Home\Details.cshtml"
       Write(Html.DisplayFor(model => model.PropertyNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Home\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Home\Details.cshtml"
       Write(Html.DisplayFor(model => model.Category.CategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Home\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Street));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Home\Details.cshtml"
       Write(Html.DisplayFor(model => model.Street));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Home\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Home\Details.cshtml"
       Write(Html.DisplayFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Home\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.State));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Home\Details.cshtml"
       Write(Html.DisplayFor(model => model.State));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Home\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Zip));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Home\Details.cshtml"
       Write(Html.DisplayFor(model => model.Zip));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Home\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Bedrooms));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Home\Details.cshtml"
       Write(Html.DisplayFor(model => model.Bedrooms));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 57 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Home\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Bathrooms));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 60 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Home\Details.cshtml"
       Write(Html.DisplayFor(model => model.Bathrooms));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 63 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Home\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PetsAllowed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 66 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Home\Details.cshtml"
       Write(Html.DisplayFor(model => model.PetsAllowed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 69 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Home\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.GuestsAllowed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 72 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Home\Details.cshtml"
       Write(Html.DisplayFor(model => model.GuestsAllowed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 75 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Home\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ParkingFree));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 78 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Home\Details.cshtml"
       Write(Html.DisplayFor(model => model.ParkingFree));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 81 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Home\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsDisabled));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 84 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Home\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsDisabled));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <!--TODO: Display daily price only-->\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 88 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Home\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.WeekDayPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 91 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Home\Details.cshtml"
       Write(Html.DisplayFor(model => model.WeekDayPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 94 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Home\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.WeekendPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 97 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Home\Details.cshtml"
       Write(Html.DisplayFor(model => model.WeekendPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <!--TODO: Add authorization to DiscountMinNights-->\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 101 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Home\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DiscountMinNights));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 104 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Home\Details.cshtml"
       Write(Html.DisplayFor(model => model.DiscountMinNights));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 107 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Home\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DiscountRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 110 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Home\Details.cshtml"
       Write(Html.DisplayFor(model => model.DiscountRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 113 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Home\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CleaningFee));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 116 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Home\Details.cshtml"
       Write(Html.DisplayFor(model => model.CleaningFee));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 119 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Home\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Ratings));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 122 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Home\Details.cshtml"
       Write(Html.DisplayFor(model => model.Ratings));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5cbc8e2dba6e9b68ce18319918057a1a7cbeef7516995", async() => {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Team_27_FinalProject.Models.Property> Html { get; private set; }
    }
}
#pragma warning restore 1591
