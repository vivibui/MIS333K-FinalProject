#pragma checksum "C:\Users\effen\OneDrive\Desktop\MIS 333\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reviews\PendingCreateAdminDisputeIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c52ef697024b7df2fab7b96bca7d854f6586c8a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Team_27_FinalProject.Views.Reviews.Views_Reviews_PendingCreateAdminDisputeIndex), @"mvc.1.0.view", @"/Views/Reviews/PendingCreateAdminDisputeIndex.cshtml")]
namespace Team_27_FinalProject.Views.Reviews
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
#line 5 "C:\Users\effen\OneDrive\Desktop\MIS 333\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\_ViewImports.cshtml"
using Team_27_FinalProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c52ef697024b7df2fab7b96bca7d854f6586c8a", @"/Views/Reviews/PendingCreateAdminDisputeIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13a9abd40792cc501236f5738420887c32520cf8", @"/Views/_ViewImports.cshtml")]
    public class Views_Reviews_PendingCreateAdminDisputeIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Team_27_FinalProject.Models.Review>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\effen\OneDrive\Desktop\MIS 333\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reviews\PendingCreateAdminDisputeIndex.cshtml"
   ViewData["Title"] = "VIEW PENDING DISPUTED REVIEWS"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n<h1>Pending Reviews</h1>\r\n<h4>Disputed Reviews from Hosts.</h4>\r\n<hr />\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "C:\Users\effen\OneDrive\Desktop\MIS 333\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reviews\PendingCreateAdminDisputeIndex.cshtml"
           Write(Html.DisplayNameFor(model => model.Property.Street));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\effen\OneDrive\Desktop\MIS 333\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reviews\PendingCreateAdminDisputeIndex.cshtml"
           Write(Html.DisplayNameFor(model => model.Rating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\effen\OneDrive\Desktop\MIS 333\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reviews\PendingCreateAdminDisputeIndex.cshtml"
           Write(Html.DisplayNameFor(model => model.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\effen\OneDrive\Desktop\MIS 333\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reviews\PendingCreateAdminDisputeIndex.cshtml"
           Write(Html.DisplayNameFor(model => model.IsDisputed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\effen\OneDrive\Desktop\MIS 333\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reviews\PendingCreateAdminDisputeIndex.cshtml"
           Write(Html.DisplayNameFor(model => model.DisputeReason));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 31 "C:\Users\effen\OneDrive\Desktop\MIS 333\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reviews\PendingCreateAdminDisputeIndex.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 35 "C:\Users\effen\OneDrive\Desktop\MIS 333\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reviews\PendingCreateAdminDisputeIndex.cshtml"
               Write(Html.DisplayFor(modelItem => item.Property.Street));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 38 "C:\Users\effen\OneDrive\Desktop\MIS 333\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reviews\PendingCreateAdminDisputeIndex.cshtml"
               Write(Html.DisplayFor(modelItem => item.Rating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 41 "C:\Users\effen\OneDrive\Desktop\MIS 333\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reviews\PendingCreateAdminDisputeIndex.cshtml"
               Write(Html.DisplayFor(modelItem => item.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 44 "C:\Users\effen\OneDrive\Desktop\MIS 333\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reviews\PendingCreateAdminDisputeIndex.cshtml"
               Write(Html.DisplayFor(modelItem => item.IsDisputed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 47 "C:\Users\effen\OneDrive\Desktop\MIS 333\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reviews\PendingCreateAdminDisputeIndex.cshtml"
               Write(Html.DisplayFor(modelItem => item.DisputeReason));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 50 "C:\Users\effen\OneDrive\Desktop\MIS 333\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reviews\PendingCreateAdminDisputeIndex.cshtml"
               Write(Html.ActionLink("Dispute", "PendingCreateAdminDisputeView", new { id = item.ReviewID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 53 "C:\Users\effen\OneDrive\Desktop\MIS 333\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\Reviews\PendingCreateAdminDisputeIndex.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Team_27_FinalProject.Models.Review>> Html { get; private set; }
    }
}
#pragma warning restore 1591