#pragma checksum "D:\Case-Study2\Case-Study2-add-productdetai-User\Selling-Phone\Views\User\UserManagement.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0468a2de58b3527d3ceb45103af02d07d14fad96"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_UserManagement), @"mvc.1.0.view", @"/Views/User/UserManagement.cshtml")]
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
#line 1 "D:\Case-Study2\Case-Study2-add-productdetai-User\Selling-Phone\Views\_ViewImports.cshtml"
using Selling_Phone;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Case-Study2\Case-Study2-add-productdetai-User\Selling-Phone\Views\_ViewImports.cshtml"
using Selling_Phone.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Case-Study2\Case-Study2-add-productdetai-User\Selling-Phone\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0468a2de58b3527d3ceb45103af02d07d14fad96", @"/Views/User/UserManagement.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3912407a8d4a604ea5865d5d89a7542b089c1193", @"/Views/_ViewImports.cshtml")]
    public class Views_User_UserManagement : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Selling_Phone.ViewModels.UserViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "D:\Case-Study2\Case-Study2-add-productdetai-User\Selling-Phone\Views\User\UserManagement.cshtml"
  
    ViewBag.Title = "Management User";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div id=""wrapper"">

    <!-- Sidebar -->
    <ul class=""navbar-nav bg-gradient-primary sidebar sidebar-dark accordion"" id=""accordionSidebar"">

        <!-- Sidebar - Brand -->
        <a class=""sidebar-brand d-flex align-items-center justify-content-center"" href=""index.html"">
            <div class=""sidebar-brand-icon rotate-n-15"">
                <i class=""fas fa-user-secret""></i>
            </div>
            <div class=""sidebar-brand-text mx-3"">User Management</div>
        </a>

        <!-- Divider -->
        <hr class=""sidebar-divider my-0"">

        <!-- Nav Item - Dashboard -->
        <li class=""nav-item active"">
            <a class=""nav-link"" href=""index.html"">
                <i class=""fas fa-fw fa-tachometer-alt""></i>
                <span>Dashboard</span>
            </a>
        </li>

        <!-- Divider -->
        <hr class=""sidebar-divider"">

        <!-- Heading -->
        <div class=""sidebar-heading"">
            Interface
        </div>

        <!--");
            WriteLiteral(@" Nav Item - Pages Collapse Menu -->
        <li class=""nav-item"">
            <a class=""nav-link collapsed"" href=""#"" data-toggle=""collapse"" data-target=""#collapseTwo"" aria-expanded=""true"" aria-controls=""collapseTwo"">
                <i class=""fas fa-fw fa-cog""></i>
                <span>Components</span>
            </a>
            <div id=""collapseTwo"" class=""collapse"" aria-labelledby=""headingTwo"" data-parent=""#accordionSidebar"">
                <div class=""bg-white py-2 collapse-inner rounded"">
                    <h6 class=""collapse-header"">Custom Components:</h6>
                    <a class=""collapse-item"" href=""buttons.html"">Buttons</a>
                    <a class=""collapse-item"" href=""cards.html"">Cards</a>
                </div>
            </div>
        </li>

        <!-- Nav Item - Utilities Collapse Menu -->
        <li class=""nav-item"">
            <a class=""nav-link collapsed"" href=""#"" data-toggle=""collapse"" data-target=""#collapseUtilities"" aria-expanded=""true"" aria-controls=""");
            WriteLiteral(@"collapseUtilities"">
                <i class=""fas fa-fw fa-wrench""></i>
                <span>Utilities</span>
            </a>
            <div id=""collapseUtilities"" class=""collapse"" aria-labelledby=""headingUtilities"" data-parent=""#accordionSidebar"">
                <div class=""bg-white py-2 collapse-inner rounded"">
                    <h6 class=""collapse-header"">Custom Utilities:</h6>
                    <a class=""collapse-item"" href=""utilities-color.html"">Colors</a>
                    <a class=""collapse-item"" href=""utilities-border.html"">Borders</a>
                    <a class=""collapse-item"" href=""utilities-animation.html"">Animations</a>
                    <a class=""collapse-item"" href=""utilities-other.html"">Other</a>
                </div>
            </div>
        </li>

        <!-- Divider -->
        <hr class=""sidebar-divider"">

        <!-- Heading -->
        <div class=""sidebar-heading"">
            Addons
        </div>

        <!-- Nav Item - Pages Collapse Menu -->");
            WriteLiteral(@"
        <li class=""nav-item"">
            <a class=""nav-link collapsed"" href=""#"" data-toggle=""collapse"" data-target=""#collapsePages"" aria-expanded=""true"" aria-controls=""collapsePages"">
                <i class=""fas fa-fw fa-folder""></i>
                <span>Pages</span>
            </a>
            <div id=""collapsePages"" class=""collapse"" aria-labelledby=""headingPages"" data-parent=""#accordionSidebar"">
                <div class=""bg-white py-2 collapse-inner rounded"">
                    <h6 class=""collapse-header"">Login Screens:</h6>
                    <a class=""collapse-item"" href=""login.html"">Login</a>
                    <a class=""collapse-item"" href=""register.html"">Register</a>
                    <a class=""collapse-item"" href=""forgot-password.html"">Forgot Password</a>
                    <div class=""collapse-divider""></div>
                    <h6 class=""collapse-header"">Other Pages:</h6>
                    <a class=""collapse-item"" href=""404.html"">404 Page</a>
                    <a cl");
            WriteLiteral(@"ass=""collapse-item"" href=""blank.html"">Blank Page</a>
                </div>
            </div>
        </li>

        <!-- Nav Item - Charts -->
        <li class=""nav-item"">
            <a class=""nav-link"" href=""charts.html"">
                <i class=""fas fa-fw fa-chart-area""></i>
                <span>Charts</span>
            </a>
        </li>

        <!-- Nav Item - Tables -->
        <li class=""nav-item"">
            <a class=""nav-link"" href=""tables.html"">
                <i class=""fas fa-fw fa-table""></i>
                <span>Tables</span>
            </a>
        </li>

        <!-- Divider -->
        <hr class=""sidebar-divider d-none d-md-block"">

        <!-- Sidebar Toggler (Sidebar) -->
        <div class=""text-center d-none d-md-inline"">
            <button class=""rounded-circle border-0"" id=""sidebarToggle""></button>
        </div>

    </ul>
    <!-- End of Sidebar -->
    <!-- Content Wrapper -->

</div>

<div id=""content-wrapper"" class=""d-flex flex-column""");
            WriteLiteral(">\r\n\r\n    <!-- Main Content -->\r\n    <div id=\"content\">\r\n\r\n\r\n        <div class=\"container mt-4\">\r\n            <h3>\r\n                ");
#nullable restore
#line 137 "D:\Case-Study2\Case-Study2-add-productdetai-User\Selling-Phone\Views\User\UserManagement.cshtml"
           Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h3>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0468a2de58b3527d3ceb45103af02d07d14fad9611775", async() => {
                WriteLiteral("Create User");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 140 "D:\Case-Study2\Case-Study2-add-productdetai-User\Selling-Phone\Views\User\UserManagement.cshtml"
             if (signInManager.IsSignedIn(User))
            {
                if (User.IsInRole("System Admin"))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <table class=""table table-bordered table-hover mt-2"">
                        <thead class=""table-dark"">
                            <tr>
                                <th>Id</th>
                                <th>Email</th>
                                <th>City</th>
                                <th>Address</th>
                                <th>Gender</th>
                                <th>Roles</th>
                                <th>Actions</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 157 "D:\Case-Study2\Case-Study2-add-productdetai-User\Selling-Phone\Views\User\UserManagement.cshtml"
                             if (Model != null && Model.Any())
                            {
                                foreach (var user in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 163 "D:\Case-Study2\Case-Study2-add-productdetai-User\Selling-Phone\Views\User\UserManagement.cshtml"
                                       Write(user.UserId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 166 "D:\Case-Study2\Case-Study2-add-productdetai-User\Selling-Phone\Views\User\UserManagement.cshtml"
                                       Write(user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 169 "D:\Case-Study2\Case-Study2-add-productdetai-User\Selling-Phone\Views\User\UserManagement.cshtml"
                                       Write(user.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 172 "D:\Case-Study2\Case-Study2-add-productdetai-User\Selling-Phone\Views\User\UserManagement.cshtml"
                                       Write(user.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 175 "D:\Case-Study2\Case-Study2-add-productdetai-User\Selling-Phone\Views\User\UserManagement.cshtml"
                                       Write(user.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 178 "D:\Case-Study2\Case-Study2-add-productdetai-User\Selling-Phone\Views\User\UserManagement.cshtml"
                                       Write(user.RolesName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0468a2de58b3527d3ceb45103af02d07d14fad9617279", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 181 "D:\Case-Study2\Case-Study2-add-productdetai-User\Selling-Phone\Views\User\UserManagement.cshtml"
                                                                                         WriteLiteral(user.UserId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0468a2de58b3527d3ceb45103af02d07d14fad9619831", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 182 "D:\Case-Study2\Case-Study2-add-productdetai-User\Selling-Phone\Views\User\UserManagement.cshtml"
                                                                                           WriteLiteral(user.UserId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 185 "D:\Case-Study2\Case-Study2-add-productdetai-User\Selling-Phone\Views\User\UserManagement.cshtml"
                                }
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n\r\n                    </table>\r\n");
#nullable restore
#line 190 "D:\Case-Study2\Case-Study2-add-productdetai-User\Selling-Phone\Views\User\UserManagement.cshtml"
                }
                if (User.IsInRole("Admin"))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <table class=""table table-bordered table-hover mt-2"">
                        <thead class=""table-dark"">
                            <tr>
                                <th>Id</th>
                                <th>Email</th>
                                <th>City</th>
                                <th>Address</th>
                                <th>Roles</th>

                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 205 "D:\Case-Study2\Case-Study2-add-productdetai-User\Selling-Phone\Views\User\UserManagement.cshtml"
                             if (Model != null && Model.Any())
                            {
                                foreach (var user in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 211 "D:\Case-Study2\Case-Study2-add-productdetai-User\Selling-Phone\Views\User\UserManagement.cshtml"
                                       Write(user.UserId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 214 "D:\Case-Study2\Case-Study2-add-productdetai-User\Selling-Phone\Views\User\UserManagement.cshtml"
                                       Write(user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 217 "D:\Case-Study2\Case-Study2-add-productdetai-User\Selling-Phone\Views\User\UserManagement.cshtml"
                                       Write(user.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 220 "D:\Case-Study2\Case-Study2-add-productdetai-User\Selling-Phone\Views\User\UserManagement.cshtml"
                                       Write(user.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 223 "D:\Case-Study2\Case-Study2-add-productdetai-User\Selling-Phone\Views\User\UserManagement.cshtml"
                                       Write(user.RolesName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n\r\n                                    </tr>\r\n");
#nullable restore
#line 227 "D:\Case-Study2\Case-Study2-add-productdetai-User\Selling-Phone\Views\User\UserManagement.cshtml"
                                }
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n\r\n                    </table>\r\n");
#nullable restore
#line 232 "D:\Case-Study2\Case-Study2-add-productdetai-User\Selling-Phone\Views\User\UserManagement.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> signInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Selling_Phone.ViewModels.UserViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
