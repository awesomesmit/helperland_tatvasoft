#pragma checksum "E:\TATVASOFT\Project-Helperland\Helperland\Helperland\Helperland\Views\Home\CustomerDashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b63980d490da56873e3d702d84b9a9acba1eb7b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CustomerDashboard), @"mvc.1.0.view", @"/Views/Home/CustomerDashboard.cshtml")]
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
#line 1 "E:\TATVASOFT\Project-Helperland\Helperland\Helperland\Helperland\Views\_ViewImports.cshtml"
using Helperland;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\TATVASOFT\Project-Helperland\Helperland\Helperland\Helperland\Views\_ViewImports.cshtml"
using Helperland.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\TATVASOFT\Project-Helperland\Helperland\Helperland\Helperland\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b63980d490da56873e3d702d84b9a9acba1eb7b1", @"/Views/Home/CustomerDashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38e0af9faa8b6532b4ecb207049a7eed256a025b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CustomerDashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Helperland.Models.ServiceRequest>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/servicehistory.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/Shared/_PublicHeader.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link sidebar-only navlink-servicehistory"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("servicehistory-tab"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CustomerServiceHistory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("tab"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-controls", new global::Microsoft.AspNetCore.Html.HtmlString("servicehistory"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-selected", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link sidebar-only navlink-favpros"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("favpros-tab"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CustomerFavouritePros", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-controls", new global::Microsoft.AspNetCore.Html.HtmlString("favpros"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-selected", new global::Microsoft.AspNetCore.Html.HtmlString("false"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/calendar2.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_15 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_16 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/layer-712.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\TATVASOFT\Project-Helperland\Helperland\Helperland\Helperland\Views\Home\CustomerDashboard.cshtml"
  
    ViewData["Title"] = "Customer Dashboard";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b63980d490da56873e3d702d84b9a9acba1eb7b19972", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b63980d490da56873e3d702d84b9a9acba1eb7b111208", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"


<!-- Modals -->

<div class=""modal fade"" id=""ServiceHistoryDashModal"" tabindex=""-1"" role=""dialog""
     aria-labelledby=""ServiceHistoryDashModal"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered modal-lg mx-auto"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLongTitle""><b>Service Details</b></h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">

            </div>
        </div>
    </div>
</div>

<!-- Reschedule Service Modal -->
<div class=""modal fade"" id=""ServiceHistoryRescheduleModal"" tabindex=""-1"" role=""dialog""
     aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered modal-sm mx-auto"" role=""document"">
        <di");
            WriteLiteral(@"v class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLongTitle""><b>Reschedule Service Request</b></h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <div class=""row"">
                    <div class=""col-12 mb-2"">
                        Select New Date and Time
                    </div>
                    <div class=""col-6"">
                        <input type=""date"" class=""w-100 form-control"">
                    </div>
                    <div class=""col-6"">
                        <input type=""time"" class=""form-control time"" id=""rescheduletime"" />
                    </div>
                    <div class=""col-12 text-center mt-2 reschedule-update"">
                        <button>Update</button>
                    </");
            WriteLiteral(@"div>
                </div>
            </div>
        </div>
    </div>
</div>

<!-- Cancel Service Modal -->
<div class=""modal fade"" id=""ServiceHistoryCancelModal"" tabindex=""-1"" role=""dialog""
     aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered modal-sm mx-auto"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLongTitle""><b>Cancel Service Request</b></h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <div class=""row"">
                    <div class=""col-12 mb-2"">
                        Why do yo want to cancel the service request?
                    </div>
                    <div class=""col-12"">
                       ");
            WriteLiteral(@" <textarea name=""cancel-reason"" id=""cancel-request-reason"" cols=""43"" rows=""4""></textarea>
                    </div>
                    <div class=""col-12 text-center mt-2 reschedule-cancel"">
                        <button id=""cancel-servicerequest"">Cancel Now</button>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>


<div class=""welcome-tab text-center"">
    <h1 class=""greet align-middle"">Welcome, <b>");
#nullable restore
#line 93 "E:\TATVASOFT\Project-Helperland\Helperland\Helperland\Helperland\Views\Home\CustomerDashboard.cshtml"
                                          Write(HttpContextAccessor.HttpContext.Session.GetString("UserName_Session"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"!</b></h1>
</div>

<div class=""wrapper container-fluid"">
    <aside>
        <ul class=""nav nav-tabs flex-column"" id=""myTab"" role=""tablist"">
            <li class=""nav-item"">
                <a class=""nav-link sidebar-only navlink-dashboard active"" id=""dashboard-tab"" data-toggle=""tab""
                   href=""#dashboard"" role=""tab"" aria-controls=""dashboard"" aria-selected=""false"">Dashboard</a>
            </li>
            <li class=""nav-item"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b63980d490da56873e3d702d84b9a9acba1eb7b116950", async() => {
                WriteLiteral("\r\n                    Service\r\n                    History\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </li>
            <li class=""nav-item"">
                <a class=""nav-link sidebar-only navlink-serviceschedule"" id=""serviceschedule-tab"" data-toggle=""tab""
                   href=""#serviceschedule"" role=""tab"" aria-controls=""serviceschedule"" aria-selected=""false"">
                    Service
                    Schedule
                </a>
            </li>
            <li class=""nav-item"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b63980d490da56873e3d702d84b9a9acba1eb7b119046", async() => {
                WriteLiteral("Favourite Pros");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </li>
            <li class=""nav-item"">
                <a class=""nav-link sidebar-only navlink-invoices"" id=""invoices-tab"" data-toggle=""tab""
                   href=""#invoices"" role=""tab"" aria-controls=""invoices"" aria-selected=""false"">Invoices</a>
            </li>


            <li class=""nav-item"">
                <a class=""nav-link sidebar-only navlink-notifications"" id=""notifications-tab"" data-toggle=""tab""
                   href=""#notifications"" role=""tab"" aria-controls=""notifications""
                   aria-selected=""false"">Notifications</a>
            </li>

            <li class=""nav-item d-none"">
                <a class=""nav-link sidebar-only navlink-mysettings"" id=""mysettings-tab""
                   role=""tab"" aria-controls=""mysettings""
                   aria-selected=""false""></a>
            </li>
        </ul>
    </aside>

    <div class=""table-content"">

        <div class=""tab-content"" id=""myTabContent"">

            <!-- Dashboard Tab -->
          ");
            WriteLiteral("  <div class=\"tab-pane fade show active\" id=\"dashboard\" role=\"tabpanel\" aria-labelledby=\"dashboard-tab\">\r\n                <div class=\"d-flex dashboard-head\">\r\n                    <h2>Dashboard</h2>\r\n                    <Button");
            BeginWriteAttribute("onclick", " onclick=\"", 6513, "\"", 6573, 3);
            WriteAttributeValue("", 6523, "location.href=\'", 6523, 15, true);
#nullable restore
#line 150 "E:\TATVASOFT\Project-Helperland\Helperland\Helperland\Helperland\Views\Home\CustomerDashboard.cshtml"
WriteAttributeValue("", 6538, Url.Action("BookService", "Home"), 6538, 34, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6572, "\'", 6572, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">Add New Service Request</Button>
                </div>
                <table id=""mysorttable1"" class=""table mb-0"" cellspacing=""0"" width=""100%"">
                    <thead>
                        <tr>
                            <th class=""th-sm service-id-dash"">Service Id</th>
                            <th class=""th-sm"">Service Date</th>
                            <th class=""th-sm price-head-dash text-center"">Service Provider</th>
                            <th class=""th-sm status-payment-dash text-center"">Payment</th>
                            <th class=""th-sm text-center"">Actions</th>
                        </tr>
                    </thead>
                    <tbody>

");
#nullable restore
#line 164 "E:\TATVASOFT\Project-Helperland\Helperland\Helperland\Helperland\Views\Home\CustomerDashboard.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td class=\"SRDashModal\" data-target=\"#ServiceHistoryDashModal\" data-toggle=\"modall\"");
            BeginWriteAttribute("SRid", " SRid=\"", 7510, "\"", 7539, 1);
#nullable restore
#line 167 "E:\TATVASOFT\Project-Helperland\Helperland\Helperland\Helperland\Views\Home\CustomerDashboard.cshtml"
WriteAttributeValue("", 7517, item.ServiceRequestId, 7517, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"cursor: pointer;\">\r\n                                    ");
#nullable restore
#line 168 "E:\TATVASOFT\Project-Helperland\Helperland\Helperland\Helperland\Views\Home\CustomerDashboard.cshtml"
                               Write(item.ServiceId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b63980d490da56873e3d702d84b9a9acba1eb7b124562", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_14);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_15);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    <b>");
#nullable restore
#line 172 "E:\TATVASOFT\Project-Helperland\Helperland\Helperland\Helperland\Views\Home\CustomerDashboard.cshtml"
                                  Write(item.ServiceStartDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                                    <div>\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b63980d490da56873e3d702d84b9a9acba1eb7b126090", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_16);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_15);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                        12:00 - 18:00
                                    </div>
                                </td>
                                <td>
                                    <div class=""service-provider-datatab"">

                                    </div>
                                </td>
                                <td>
                                    <div class=""price ml-xl-0 ml-2"">");
#nullable restore
#line 184 "E:\TATVASOFT\Project-Helperland\Helperland\Helperland\Helperland\Views\Home\CustomerDashboard.cshtml"
                                                               Write(item.TotalCost);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" <span>€</span></div>
                                </td>
                                <td class=""text-center align-middle d-flex justify-content-center align-items-center"">
                                    <button class=""res-dash-btn mr-1"" data-target=""#ServiceHistoryRescheduleModal""
                                            data-toggle=""modal"">
                                        Reschedule
                                    </button>
                                    <button class=""cl-dash-btn CancelServiceRequest"" data-target=""#ServiceHistoryCancelModal""");
            BeginWriteAttribute("SRid", " SRid=\"", 9016, "\"", 9045, 1);
#nullable restore
#line 191 "E:\TATVASOFT\Project-Helperland\Helperland\Helperland\Helperland\Views\Home\CustomerDashboard.cshtml"
WriteAttributeValue("", 9023, item.ServiceRequestId, 9023, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                                            data-toggle=\"modal\">\r\n                                        Cancel\r\n                                    </button>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 197 "E:\TATVASOFT\Project-Helperland\Helperland\Helperland\Helperland\Views\Home\CustomerDashboard.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                    </tbody>
                </table>
            </div>

            <!-- Service Schedule Tab -->
            <div class=""tab-pane fade"" id=""serviceschedule"" role=""tabpanel"" aria-labelledby=""serviceschedule-tab"">
                Service
                Schedule
            </div>

            <!-- invoices Tab -->
            <div class=""tab-pane fade"" id=""invoices"" role=""tabpanel"" aria-labelledby=""invoices-tab"">
                Invoices
            </div>

            <!-- Notification -->
            <div class=""tab-pane fade"" id=""notifications"" role=""tabpanel"" aria-labelledby=""notifications-tab"">
                Notifications
            </div>

        </div>
    </div>
</div>

<div style=""flex-grow:1""></div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $('#mysorttable1').DataTable({
                ""aaSorting"": [],
                columnDefs: [{
                    orderable: false,
                    targets: [1, 2, 4]
                }]
            });
        });
    </script>

    <script>
        $("".SRDashModal"").click(function () {

            $.ajax({
                url: '");
#nullable restore
#line 243 "E:\TATVASOFT\Project-Helperland\Helperland\Helperland\Helperland\Views\Home\CustomerDashboard.cshtml"
                 Write(Url.Action("SRDashModal", "Home"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                type: 'GET',
                contentType: 'application/html; charset=utf-8',
                dataType: 'html',
                data: {
                    id: parseInt($(this).attr(""SRid""))
                },
                success: function (res) {
                    $(""#ServiceHistoryDashModal .modal-body"").html(res);
                    $(""#ServiceHistoryDashModal"").modal();
                },
                error: function (err) {
                    console.log(err);
                    console.log(""Error"");
                }
            });

        });

        var srid;
        $(document).on(""click"","".CancelServiceRequest"",function () {
            srid = parseInt($(this).attr(""SRid""));
            console.log(srid);
        });

        $(""#cancel-servicerequest"").click(function () {
            var comment = $(""#cancel-request-reason"").val();
                console.log(comment);

            $.ajax({
                url: '");
#nullable restore
#line 273 "E:\TATVASOFT\Project-Helperland\Helperland\Helperland\Helperland\Views\Home\CustomerDashboard.cshtml"
                 Write(Url.Action("CustomerDashboardCancelRequest", "Home"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                type: 'post',
                contentType: 'application/json; charset=utf-8',
                dataType: 'json',
                data: JSON.stringify({
                    ServiceRequestId: srid,
                    Comments: $(""#cancel-request-reason"").val()
                }),
                success: function (res) {
                    console.log(res);
                    $(""#ServiceHistoryCancelModal"").modal(""hide"");
                    alert(""Your Service Request has been Cancelled."");
                    location.reload();
                },
                error: function (err) {
                    console.log(err);
                    console.log(""Error"");
                }
            });

        });
    </script>

");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Http.IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Helperland.Models.ServiceRequest>> Html { get; private set; }
    }
}
#pragma warning restore 1591
