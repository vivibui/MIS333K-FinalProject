#pragma checksum "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Properties\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6409a471a9dcfc025b14b09e9dd7bba145a59933"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Team_27_FinalProject.Views.Properties.Views_Properties_Index), @"mvc.1.0.view", @"/Views/Properties/Index.cshtml")]
namespace Team_27_FinalProject.Views.Properties
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6409a471a9dcfc025b14b09e9dd7bba145a59933", @"/Views/Properties/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13a9abd40792cc501236f5738420887c32520cf8", @"/Views/_ViewImports.cshtml")]
    public class Views_Properties_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Team_27_FinalProject.Models.Property>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Properties\Index.cshtml"
  
    ViewData["Title"] = "List of Active Properties";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<!-- Only Host can access this -->\r\n");
#nullable restore
#line 10 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Properties\Index.cshtml"
 if (User.Identity.IsAuthenticated)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Properties\Index.cshtml"
     if (User.IsInRole("Host"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6409a471a9dcfc025b14b09e9dd7bba145a599334607", async() => {
                WriteLiteral("Create New");
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
            WriteLiteral("\r\n    </p>\r\n");
#nullable restore
#line 17 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Properties\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Properties\Index.cshtml"
     
 }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 24 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Properties\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Street));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 27 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Properties\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 30 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Properties\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.State));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 33 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Properties\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Zip));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 36 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Properties\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Bedrooms));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 39 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Properties\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Bathrooms));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 42 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Properties\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PetsAllowed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 45 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Properties\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.GuestsAllowed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 48 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Properties\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ParkingFree));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 51 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Properties\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.WeekDayPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 54 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Properties\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.WeekendPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 57 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Properties\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DiscountMinNights));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 60 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Properties\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DiscountRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 63 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Properties\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CleaningFee));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 69 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Properties\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 72 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Properties\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Street));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 75 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Properties\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 78 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Properties\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.State));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 81 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Properties\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Zip));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 84 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Properties\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Bedrooms));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 87 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Properties\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Bathrooms));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 90 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Properties\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PetsAllowed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 93 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Properties\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.GuestsAllowed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 96 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Properties\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ParkingFree));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 99 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Properties\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.WeekDayPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 102 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Properties\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.WeekendPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 105 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Properties\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DiscountMinNights));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 108 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Properties\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DiscountRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 111 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Properties\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CleaningFee));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6409a471a9dcfc025b14b09e9dd7bba145a5993316893", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 114 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Properties\Index.cshtml"
                                          WriteLiteral(item.PropertyID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 117 "C:\Users\mumgo\Documents\GitHub\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Properties\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Team_27_FinalProject.Models.Property>> Html { get; private set; }
    }
}
#pragma warning restore 1591
