#pragma checksum "/Users/vivianbui/Desktop/MIS333K-FinalProject/Team_27_FinalProject/Team_27_FinalProject/Views/Account/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4b0e69e30a321748a23979d27be22b6c582eb34"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Team_27_FinalProject.Views.Account.Views_Account_Index), @"mvc.1.0.view", @"/Views/Account/Index.cshtml")]
namespace Team_27_FinalProject.Views.Account
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
#line 5 "/Users/vivianbui/Desktop/MIS333K-FinalProject/Team_27_FinalProject/Team_27_FinalProject/Views/_ViewImports.cshtml"
using Team_27_FinalProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4b0e69e30a321748a23979d27be22b6c582eb34", @"/Views/Account/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13a9abd40792cc501236f5738420887c32520cf8", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IndexViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n    <hr />\n");
#nullable restore
#line 4 "/Users/vivianbui/Desktop/MIS333K-FinalProject/Team_27_FinalProject/Team_27_FinalProject/Views/Account/Index.cshtml"
  
    ViewBag.Title = "Profile";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>");
#nullable restore
#line 8 "/Users/vivianbui/Desktop/MIS333K-FinalProject/Team_27_FinalProject/Team_27_FinalProject/Views/Account/Index.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</h2>\n\n<div>\n    <hr />\n    <dl class=\"dl-horizontal\">\n\n        <!-- READ-ONLY: UserName -->\n        <dt>User Name:</dt>\n        <dd>");
#nullable restore
#line 16 "/Users/vivianbui/Desktop/MIS333K-FinalProject/Team_27_FinalProject/Team_27_FinalProject/Views/Account/Index.cshtml"
       Write(Model.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n\n        <!-- READ-ONLY: Email -->\n        <dt>Email:</dt>\n        <dd>");
#nullable restore
#line 20 "/Users/vivianbui/Desktop/MIS333K-FinalProject/Team_27_FinalProject/Team_27_FinalProject/Views/Account/Index.cshtml"
       Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n\n        <!-- READ-ONLY: Street -->\n        <dt>Street:</dt>\n        <dd>");
#nullable restore
#line 24 "/Users/vivianbui/Desktop/MIS333K-FinalProject/Team_27_FinalProject/Team_27_FinalProject/Views/Account/Index.cshtml"
       Write(Model.Street);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n\n        <!-- READ-ONLY: Zip -->\n        <dt>Zip:</dt>\n        <dd>");
#nullable restore
#line 28 "/Users/vivianbui/Desktop/MIS333K-FinalProject/Team_27_FinalProject/Team_27_FinalProject/Views/Account/Index.cshtml"
       Write(Model.Zip);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n\n        <!-- READ-ONLY: Birthday -->\n        <dt>Birthday:</dt>\n        <dd>");
#nullable restore
#line 32 "/Users/vivianbui/Desktop/MIS333K-FinalProject/Team_27_FinalProject/Team_27_FinalProject/Views/Account/Index.cshtml"
       Write(Model.Birthday);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n\n        <!-- READ-ONLY: Phone -->\n        <dt>Phone:</dt>\n        <dd>");
#nullable restore
#line 36 "/Users/vivianbui/Desktop/MIS333K-FinalProject/Team_27_FinalProject/Team_27_FinalProject/Views/Account/Index.cshtml"
       Write(Model.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n\n        <!-- Change Password -->\n        <dd>\n            [");
#nullable restore
#line 40 "/Users/vivianbui/Desktop/MIS333K-FinalProject/Team_27_FinalProject/Team_27_FinalProject/Views/Account/Index.cshtml"
        Write(Html.ActionLink("Change your password", "ChangePassword"));

#line default
#line hidden
#nullable disable
            WriteLiteral("]\n\n        </dd>\n\n        <!-- Change Address -->\n        <dd>\n            [");
#nullable restore
#line 46 "/Users/vivianbui/Desktop/MIS333K-FinalProject/Team_27_FinalProject/Team_27_FinalProject/Views/Account/Index.cshtml"
        Write(Html.ActionLink("Change your address", "ChangeAddress"));

#line default
#line hidden
#nullable disable
            WriteLiteral("]\n        </dd>\n\n        <!-- Change Birthday -->\n        <dd>\n            [");
#nullable restore
#line 51 "/Users/vivianbui/Desktop/MIS333K-FinalProject/Team_27_FinalProject/Team_27_FinalProject/Views/Account/Index.cshtml"
        Write(Html.ActionLink("Change your birthday", "ChangeBirthday"));

#line default
#line hidden
#nullable disable
            WriteLiteral("]\n        </dd>\n\n        <!-- Change Phone -->\n        <dd>\n            [");
#nullable restore
#line 56 "/Users/vivianbui/Desktop/MIS333K-FinalProject/Team_27_FinalProject/Team_27_FinalProject/Views/Account/Index.cshtml"
        Write(Html.ActionLink("Change your phone", "ChangePhone"));

#line default
#line hidden
#nullable disable
            WriteLiteral("]\n        </dd>\n\n    </dl>\n\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
