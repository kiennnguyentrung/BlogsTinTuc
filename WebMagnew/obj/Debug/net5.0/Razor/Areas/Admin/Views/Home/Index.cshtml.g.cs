#pragma checksum "C:\Users\kynng\OneDrive\Máy tính\WebMagnew\WebMagnew\Areas\Admin\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62782732420129e31862f735c466fd6a3b84effb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\kynng\OneDrive\Máy tính\WebMagnew\WebMagnew\Areas\Admin\Views\_ViewImports.cshtml"
using WebMagnew;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kynng\OneDrive\Máy tính\WebMagnew\WebMagnew\Areas\Admin\Views\_ViewImports.cshtml"
using WebMagnew.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62782732420129e31862f735c466fd6a3b84effb", @"/Areas/Admin/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f76969ee5dfbf6ecf8d271c963e084a0c9a5d98", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/AdminAssets/img/icon1.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("wd-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/AdminAssets/img/icon2.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\kynng\OneDrive\Máy tính\WebMagnew\WebMagnew\Areas\Admin\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Admin";
    Layout = "~/Areas/Admin/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""slim-pageheader"">
    <ol class=""breadcrumb slim-breadcrumb"">
        <li class=""breadcrumb-item""><a href=""#"">Home</a></li>
        <li class=""breadcrumb-item active"" aria-current=""page"">Dashboard</li>
    </ol>
    <h6 class=""slim-pagetitle"">Dashboard 01</h6>
</div><!-- slim-pageheader -->

<div class=""dash-headline"">
    <div class=""dash-headline-left"">
        <div class=""dash-headline-item-one"">
            <div id=""chartArea1"" class=""dash-chartist""></div>
            <div class=""dash-item-overlay"">
                <h1>0.0345 <span class=""tx-24"">BTC</span></h1>
                <p class=""earning-label"">Bitcoin Earnings</p>
                <p class=""earning-desc"">Etiam ultricies nisi vel augue. Curabitur ullamcorper ultricies nisi. Nam eget dui. Etiam rhoncus...</p>
                <a href=""#"" class=""statement-link"">View Statements <i class=""fa fa-angle-right mg-l-5""></i></a>
            </div>
        </div><!-- dash-headline-item-one -->
    </div><!-- dash-headline-left -");
            WriteLiteral(@"->

    <div class=""dash-headline-right"">
        <div class=""dash-headline-right-top"">
            <div class=""dash-headline-item-two"">
                <div id=""chartMultiBar1"" class=""chart-rickshaw""></div>
                <div class=""dash-item-overlay"">
                    <h4>0.0873 <span class=""tx-20"">ETH</span></h4>
                    <p class=""item-label"">Ethereum Wallet</p>
                    <p class=""item-desc"">Curabitur ullamcorper ultricies nisi. Nam eget dui. Etiam rhoncus...</p>
                    <a href=""#"" class=""report-link"">View Report <i class=""fa fa-angle-right mg-l-5""></i></a>
                </div>
            </div><!-- dash-headline-item-two -->
        </div><!-- dash-headline-right-top -->
        <div class=""dash-headline-right-bottom"">
            <div class=""dash-headline-right-bottom-left"">
                <div class=""dash-headline-item-three"">
                    <span id=""sparkline3"" class=""sparkline wd-100p"">1,4,4,7,5,9,10,5,4,4,7,5,9,10</span>
           ");
            WriteLiteral(@"         <div>
                        <h1>29,931</h1>
                        <p class=""item-label"">Male Visitors</p>
                        <p class=""item-desc"">Curabitur ullamcorper ultricies nisi. Nam eget dui. Etiam rhoncus...</p>
                    </div>
                </div><!-- dash-headline-item-three -->
            </div><!-- dash-headline-right-bottom-left -->
            <div class=""dash-headline-right-bottom-right"">
                <div class=""dash-headline-item-three"">
                    <span id=""sparkline4"" class=""sparkline wd-100p"">1,4,4,7,5,7,4,3,4,4,6,5,9,7</span>
                    <div>
                        <h1>45,231</h1>
                        <p class=""item-label"">Female Visitors</p>
                        <p class=""item-desc"">Curabitur ullamcorper ultricies nisi. Nam eget dui. Etiam rhoncus...</p>
                    </div>
                </div><!-- dash-headline-item-three -->
            </div><!-- dash-headline-right-bottom-right -->
        </div><!--");
            WriteLiteral(@" dash-headline-right-bottom -->
    </div><!-- wd-50p -->
</div><!-- d-flex ht-100v -->

<div class=""card card-dash-one mg-t-20"">
    <div class=""row no-gutters"">
        <div class=""col-lg-3"">
            <i class=""icon ion-ios-analytics-outline""></i>
            <div class=""dash-content"">
                <label class=""tx-primary"">Impressions</label>
                <h2>822,490</h2>
            </div><!-- dash-content -->
        </div><!-- col-3 -->
        <div class=""col-lg-3"">
            <i class=""icon ion-ios-pie-outline""></i>
            <div class=""dash-content"">
                <label class=""tx-success"">Page Visits</label>
                <h2>465,183</h2>
            </div><!-- dash-content -->
        </div><!-- col-3 -->
        <div class=""col-lg-3"">
            <i class=""icon ion-ios-stopwatch-outline""></i>
            <div class=""dash-content"">
                <label class=""tx-purple"">Commision</label>
                <h2>781,524</h2>
            </div><!-- dash-content");
            WriteLiteral(@" -->
        </div><!-- col-3 -->
        <div class=""col-lg-3"">
            <i class=""icon ion-ios-world-outline""></i>
            <div class=""dash-content"">
                <label class=""tx-danger"">Earnings</label>
                <h2>369,657</h2>
            </div><!-- dash-content -->
        </div><!-- col-3 -->
    </div><!-- row -->
</div><!-- card -->

<div class=""row row-sm mg-t-20"">
    <div class=""col-lg-6"">
        <div class=""card card-table"">
            <div class=""card-header"">
                <h6 class=""slim-card-title"">Product Purchases</h6>
            </div><!-- card-header -->
            <div class=""table-responsive"">
                <table class=""table mg-b-0 tx-13"">
                    <thead>
                        <tr class=""tx-10"">
                            <th class=""wd-10p pd-y-5"">&nbsp;</th>
                            <th class=""pd-y-5"">Item Details</th>
                            <th class=""pd-y-5 tx-right"">Sold</th>
                            <th ");
            WriteLiteral(@"class=""pd-y-5"">Gain</th>
                            <th class=""pd-y-5 tx-center"">Actions</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td class=""pd-l-20"">
                                <img src=""http://via.placeholder.com/800x533"" class=""wd-55"" alt=""Image"">
                            </td>
                            <td>
                                <a");
            BeginWriteAttribute("href", " href=\"", 5703, "\"", 5710, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""tx-inverse tx-14 tx-medium d-block"">The Dothraki Shoes</a>
                                <span class=""tx-11 d-block""><span class=""square-8 bg-danger mg-r-5 rounded-circle""></span> 20 remaining</span>
                            </td>
                            <td class=""valign-middle tx-right"">3,345</td>
                            <td class=""valign-middle""><span class=""tx-success""><i class=""icon ion-android-arrow-up mg-r-5""></i>33.34%</span> from last week</td>
                            <td class=""valign-middle tx-center"">
                                <a");
            BeginWriteAttribute("href", " href=\"", 6295, "\"", 6302, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""tx-gray-600 tx-24""><i class=""icon ion-android-more-horizontal""></i></a>
                            </td>
                        </tr>
                        <tr>
                            <td class=""pd-l-20"">
                                <img src=""http://via.placeholder.com/800x533"" class=""wd-55"" alt=""Image"">
                            </td>
                            <td>
                                <a");
            BeginWriteAttribute("href", " href=\"", 6739, "\"", 6746, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""tx-inverse tx-14 tx-medium d-block"">Westeros Sneaker</a>
                                <span class=""tx-11 d-block""><span class=""square-8 bg-success mg-r-5 rounded-circle""></span> In stock</span>
                            </td>
                            <td class=""valign-middle tx-right"">720</td>
                            <td class=""valign-middle""><span class=""tx-danger""><i class=""icon ion-android-arrow-down mg-r-5""></i>21.20%</span> from last week</td>
                            <td class=""valign-middle tx-center"">
                                <a");
            BeginWriteAttribute("href", " href=\"", 7325, "\"", 7332, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""tx-gray-600 tx-24""><i class=""icon ion-android-more-horizontal""></i></a>
                            </td>
                        </tr>
                        <tr>
                            <td class=""pd-l-20"">
                                <img src=""http://via.placeholder.com/800x533"" class=""wd-55"" alt=""Image"">
                            </td>
                            <td>
                                <a");
            BeginWriteAttribute("href", " href=\"", 7769, "\"", 7776, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""tx-inverse tx-14 tx-medium d-block"">Selonian Hand Bag</a>
                                <span class=""tx-11 d-block""><span class=""square-8 bg-success mg-r-5 rounded-circle""></span> In stock</span>
                            </td>
                            <td class=""valign-middle tx-right"">1,445</td>
                            <td class=""valign-middle""><span class=""tx-success""><i class=""icon ion-android-arrow-up mg-r-5""></i>23.34%</span> from last week</td>
                            <td class=""valign-middle tx-center"">
                                <a");
            BeginWriteAttribute("href", " href=\"", 8357, "\"", 8364, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""tx-gray-600 tx-24""><i class=""icon ion-android-more-horizontal""></i></a>
                            </td>
                        </tr>
                        <tr>
                            <td class=""pd-l-20"">
                                <img src=""http://via.placeholder.com/800x533"" class=""wd-55"" alt=""Image"">
                            </td>
                            <td>
                                <a");
            BeginWriteAttribute("href", " href=\"", 8801, "\"", 8808, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""tx-inverse tx-14 tx-medium d-block"">Kel Dor Sunglass</a>
                                <span class=""tx-11 d-block""><span class=""square-8 bg-warning mg-r-5 rounded-circle""></span> 45 remaining</span>
                            </td>
                            <td class=""valign-middle tx-right"">2,500</td>
                            <td class=""valign-middle""><span class=""tx-success""><i class=""icon ion-android-arrow-up mg-r-5""></i>28.78%</span> from last week</td>
                            <td class=""valign-middle tx-center"">
                                <a");
            BeginWriteAttribute("href", " href=\"", 9392, "\"", 9399, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""tx-gray-600 tx-24""><i class=""icon ion-android-more-horizontal""></i></a>
                            </td>
                        </tr>
                        <tr>
                            <td class=""pd-l-20"">
                                <img src=""http://via.placeholder.com/800x533"" class=""wd-55"" alt=""Image"">
                            </td>
                            <td>
                                <a");
            BeginWriteAttribute("href", " href=\"", 9836, "\"", 9843, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""tx-inverse tx-14 tx-medium d-block"">Kubaz Sunglass</a>
                                <span class=""tx-11 d-block""><span class=""square-8 bg-success mg-r-5 rounded-circle""></span> In stock</span>
                            </td>
                            <td class=""valign-middle tx-14 tx-right"">223</td>
                            <td class=""valign-middle""><span class=""tx-danger""><i class=""icon ion-android-arrow-down mg-r-5""></i>18.18%</span> from last week</td>
                            <td class=""valign-middle tx-center"">
                                <a");
            BeginWriteAttribute("href", " href=\"", 10426, "\"", 10433, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""tx-gray-600 tx-24""><i class=""icon ion-android-more-horizontal""></i></a>
                            </td>
                        </tr>
                    </tbody>
                </table>
            </div><!-- table-responsive -->
            <div class=""card-footer tx-12 pd-y-15 bg-transparent"">
                <a");
            BeginWriteAttribute("href", " href=\"", 10768, "\"", 10775, 0);
            EndWriteAttribute();
            WriteLiteral(@"><i class=""fa fa-angle-down mg-r-5""></i>View All Products</a>
            </div><!-- card-footer -->
        </div><!-- card -->
    </div><!-- col-6 -->
    <div class=""col-lg-6 mg-t-20 mg-lg-t-0"">
        <div class=""card card-table"">
            <div class=""card-header"">
                <h6 class=""slim-card-title"">User Transaction History</h6>
            </div><!-- card-header -->
            <div class=""table-responsive"">
                <table class=""table mg-b-0 tx-13"">
                    <thead>
                        <tr class=""tx-10"">
                            <th class=""wd-10p pd-y-5"">&nbsp;</th>
                            <th class=""pd-y-5"">User</th>
                            <th class=""pd-y-5"">Type</th>
                            <th class=""pd-y-5"">Date</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td class=""pd-l-20"">
                                <img src=""http:");
            WriteLiteral("//via.placeholder.com/500x500\" class=\"wd-36 rounded-circle\" alt=\"Image\">\r\n                            </td>\r\n                            <td>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 11977, "\"", 11984, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""tx-inverse tx-14 tx-medium d-block"">Mark K. Peters</a>
                                <span class=""tx-11 d-block"">TRANSID: 1234567890</span>
                            </td>
                            <td class=""tx-12"">
                                <span class=""square-8 bg-success mg-r-5 rounded-circle""></span> Email verified
                            </td>
                            <td>Just Now</td>
                        </tr>
                        <tr>
                            <td class=""pd-l-20"">
                                <img src=""http://via.placeholder.com/500x500"" class=""wd-36 rounded-circle"" alt=""Image"">
                            </td>
                            <td>
                                <a");
            BeginWriteAttribute("href", " href=\"", 12749, "\"", 12756, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""tx-inverse tx-14 tx-medium d-block"">Karmen F. Brown</a>
                                <span class=""tx-11 d-block"">TRANSID: 1234567890</span>
                            </td>
                            <td class=""tx-12"">
                                <span class=""square-8 bg-warning mg-r-5 rounded-circle""></span> Pending verification
                            </td>
                            <td>Apr 21, 2017 8:34am</td>
                        </tr>
                        <tr>
                            <td class=""pd-l-20"">
                                <img src=""http://via.placeholder.com/500x500"" class=""wd-36 rounded-circle"" alt=""Image"">
                            </td>
                            <td>
                                <a");
            BeginWriteAttribute("href", " href=\"", 13539, "\"", 13546, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""tx-inverse tx-14 tx-medium d-block"">Gorgonio Magalpok</a>
                                <span class=""tx-11 d-block"">TRANSID: 1234567890</span>
                            </td>
                            <td class=""tx-12"">
                                <span class=""square-8 bg-success mg-r-5 rounded-circle""></span> Purchased success
                            </td>
                            <td>Apr 10, 2017 4:40pm</td>
                        </tr>
                        <tr>
                            <td class=""pd-l-20"">
                                <img src=""http://via.placeholder.com/500x500"" class=""wd-36 rounded-circle"" alt=""Image"">
                            </td>
                            <td>
                                <a");
            BeginWriteAttribute("href", " href=\"", 14328, "\"", 14335, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""tx-inverse tx-14 tx-medium d-block"">Ariel T. Hall</a>
                                <span class=""tx-11 d-block"">TRANSID: 1234567890</span>
                            </td>
                            <td class=""tx-12"">
                                <span class=""square-8 bg-warning mg-r-5 rounded-circle""></span> Payment on hold
                            </td>
                            <td>Apr 02, 2017 6:45pm</td>
                        </tr>
                        <tr>
                            <td class=""pd-l-20"">
                                <img src=""http://via.placeholder.com/500x500"" class=""wd-36 rounded-circle"" alt=""Image"">
                            </td>
                            <td>
                                <a");
            BeginWriteAttribute("href", " href=\"", 15111, "\"", 15118, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""tx-inverse tx-14 tx-medium d-block"">John L. Goulette</a>
                                <span class=""tx-11 d-block"">TRANSID: 1234567890</span>
                            </td>
                            <td class=""tx-12"">
                                <span class=""square-8 bg-pink mg-r-5 rounded-circle""></span> Account deactivated
                            </td>
                            <td>Mar 30, 2017 10:30am</td>
                        </tr>
                    </tbody>
                </table>
            </div><!-- table-responsive -->
            <div class=""card-footer tx-12 pd-y-15 bg-transparent"">
                <a");
            BeginWriteAttribute("href", " href=\"", 15782, "\"", 15789, 0);
            EndWriteAttribute();
            WriteLiteral(@"><i class=""fa fa-angle-down mg-r-5""></i>View All Transaction History</a>
            </div><!-- card-footer -->
        </div><!-- card -->
    </div><!-- col-6 -->
</div><!-- row -->

<div class=""row row-sm mg-t-20"">
    <div class=""col-lg-4"">
        <div class=""card card-info"">
            <div class=""card-body pd-40"">
                <div class=""d-flex justify-content-center mg-b-30"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "62782732420129e31862f735c466fd6a3b84effb23931", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
                <h5 class=""tx-inverse mg-b-20"">Safe &amp; Secure</h5>
                <p>Far far away, behind the word mountains, far from the countries Vokalia and Consonantia. Even the all-powerful Pointing has no control about the blind texts.</p>
                <a");
            BeginWriteAttribute("href", " href=\"", 16571, "\"", 16578, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-primary btn-block"">Getting Started</a>
            </div><!-- card -->
        </div><!-- card -->
    </div><!-- col-4 -->
    <div class=""col-lg-4 mg-t-20 mg-lg-t-0"">
        <div class=""card card-info"">
            <div class=""card-body pd-40"">
                <div class=""d-flex justify-content-center mg-b-30"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "62782732420129e31862f735c466fd6a3b84effb25938", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
                <h5 class=""tx-inverse mg-b-20"">Instant Exchange</h5>
                <p>Far far away, behind the word mountains, far from the countries Vokalia and Consonantia. Even the all-powerful Pointing has no control about the blind texts.</p>
                <a");
            BeginWriteAttribute("href", " href=\"", 17296, "\"", 17303, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-primary btn-block"">Take a Tour</a>
            </div><!-- card-body -->
        </div><!-- card -->
    </div><!-- col-4 -->
    <div class=""col-lg-4 mg-t-20 mg-lg-t-0"">
        <div class=""card card-sales"">
            <h6 class=""slim-card-title tx-primary"">Sales Report</h6>
            <div class=""row"">
                <div class=""col"">
                    <label class=""tx-12"">Today</label>
                    <p>1,898</p>
                </div><!-- col -->
                <div class=""col"">
                    <label class=""tx-12"">This Week</label>
                    <p>32,112</p>
                </div><!-- col -->
                <div class=""col"">
                    <label class=""tx-12"">This Month</label>
                    <p>72,067</p>
                </div><!-- col -->
            </div><!-- row -->

            <div class=""progress mg-b-5"">
                <div class=""progress-bar bg-primary wd-50p"" role=""progressbar"" aria-valuenow=""50"" aria-valuemin=""0"" aria-v");
            WriteLiteral(@"aluemax=""100"">50%</div>
            </div>
            <p class=""tx-12 mg-b-0"">Maecenas tempus, tellus eget conditum rhon.</p>
        </div><!-- card -->

        <div class=""card card-impression mg-t-20"">
            <div class=""card-body pd-b-0"">
                <h6 class=""slim-card-title tx-primary"">Page Impressions</h6>
                <h2 class=""tx-lato tx-inverse"">323,360</h2>
                <p class=""tx-12""><span class=""tx-primary"">2.5%</span> change from yesterday</p>
            </div><!-- card-body -->
            <div id=""rs3"" class=""ht-50 ht-sm-70 mg-r--1""></div>
        </div><!-- card -->
    </div><!-- col-4 -->
</div><!-- row -->
");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
