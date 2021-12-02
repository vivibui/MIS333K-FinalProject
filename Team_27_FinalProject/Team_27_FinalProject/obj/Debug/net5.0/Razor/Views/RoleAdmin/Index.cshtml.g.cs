#pragma checksum "C:\Users\effen\OneDrive\Desktop\MIS 333\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\RoleAdmin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa6bb8a617a9195343dc96c9985249281714691f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Team_27_FinalProject.Views.RoleAdmin.Views_RoleAdmin_Index), @"mvc.1.0.view", @"/Views/RoleAdmin/Index.cshtml")]
namespace Team_27_FinalProject.Views.RoleAdmin
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
#nullable restore
#line 1 "C:\Users\effen\OneDrive\Desktop\MIS 333\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\RoleAdmin\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa6bb8a617a9195343dc96c9985249281714691f", @"/Views/RoleAdmin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13a9abd40792cc501236f5738420887c32520cf8", @"/Views/_ViewImports.cshtml")]
    public class Views_RoleAdmin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RoleEditModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\effen\OneDrive\Desktop\MIS 333\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\RoleAdmin\Index.cshtml"
  
    ViewBag.Title = "Roles";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2>Manage Roles</h2>

<div class=""panel panel-primary"">
    <div class=""panel-heading"">Roles</div>
    <table class=""table table-striped"">
        <tr>
            <th>ID</th>
            <th>Name</th>
            <th>Users</th>
            <th></th>
        </tr>
");
#nullable restore
#line 19 "C:\Users\effen\OneDrive\Desktop\MIS 333\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\RoleAdmin\Index.cshtml"
         if (Model.Count() == 0)
        { 

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td colspan=\"4\" class=\"text-center\">No roles</td>\r\n            </tr>\r\n");
#nullable restore
#line 24 "C:\Users\effen\OneDrive\Desktop\MIS 333\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\RoleAdmin\Index.cshtml"
        }
        else
        {
            foreach (RoleEditModel role in Model)
            {  

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 30 "C:\Users\effen\OneDrive\Desktop\MIS 333\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\RoleAdmin\Index.cshtml"
                   Write(role.Role.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 31 "C:\Users\effen\OneDrive\Desktop\MIS 333\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\RoleAdmin\Index.cshtml"
                   Write(role.Role.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n");
#nullable restore
#line 33 "C:\Users\effen\OneDrive\Desktop\MIS 333\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\RoleAdmin\Index.cshtml"
                         if (role.RoleMembers == null || role.RoleMembers.Count() == 0)
                        { 

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            WriteLiteral(" No Users in role\r\n");
#nullable restore
#line 36 "C:\Users\effen\OneDrive\Desktop\MIS 333\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\RoleAdmin\Index.cshtml"
                        }
                        else
                        { 

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p>");
#nullable restore
#line 39 "C:\Users\effen\OneDrive\Desktop\MIS 333\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\RoleAdmin\Index.cshtml"
                          Write(string.Join(", ", role.RoleMembers.Select(x => x.Email)));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 40 "C:\Users\effen\OneDrive\Desktop\MIS 333\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\RoleAdmin\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 43 "C:\Users\effen\OneDrive\Desktop\MIS 333\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\RoleAdmin\Index.cshtml"
                   Write(Html.ActionLink("Edit", "Edit", new { id = role.Role.Id }, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 46 "C:\Users\effen\OneDrive\Desktop\MIS 333\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\RoleAdmin\Index.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</div>\r\n");
#nullable restore
#line 50 "C:\Users\effen\OneDrive\Desktop\MIS 333\MIS333K-FinalProject\Team_27_FinalProject\Team_27_FinalProject\Views\RoleAdmin\Index.cshtml"
Write(Html.ActionLink("Create New Role", "Create", null, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RoleEditModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
