#pragma checksum "C:\Users\kynng\OneDrive\Máy tính\WebMagnew\WebMagnew\Views\Posts\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0af0818f3a69aa1e94d56f5de8def668bd63e21d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Posts_Details), @"mvc.1.0.view", @"/Views/Posts/Details.cshtml")]
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
#line 1 "C:\Users\kynng\OneDrive\Máy tính\WebMagnew\WebMagnew\Views\_ViewImports.cshtml"
using WebMagnew;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kynng\OneDrive\Máy tính\WebMagnew\WebMagnew\Views\_ViewImports.cshtml"
using WebMagnew.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0af0818f3a69aa1e94d56f5de8def668bd63e21d", @"/Views/Posts/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f40af3f0863beea5bde5638f26cf47b098d85081", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Posts_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebMagnew.Models.Post>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\kynng\OneDrive\Máy tính\WebMagnew\WebMagnew\Views\Posts\Details.cshtml"
  
    ViewData["Title"] = Model.Tilte;
    Layout = "~/Views/Shared/_Layout.cshtml";
    string url = $"/{Model.Alias}.html";
    List<Post> BaiVietLienQuan = ViewBag.BaiVietLienQuan;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- section main content -->
<section class=""main-content mt-3"">
    <div class=""container-xl"">

        <nav aria-label=""breadcrumb"">
            <ol class=""breadcrumb"">
                <li class=""breadcrumb-item""><a href=""#"">Home</a></li>
                <li class=""breadcrumb-item""><a");
            BeginWriteAttribute("href", " href=\"", 522, "\"", 546, 2);
            WriteAttributeValue("", 529, "/", 529, 1, true);
#nullable restore
#line 17 "C:\Users\kynng\OneDrive\Máy tính\WebMagnew\WebMagnew\Views\Posts\Details.cshtml"
WriteAttributeValue("", 530, Model.Cat.Alias, 530, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 17 "C:\Users\kynng\OneDrive\Máy tính\WebMagnew\WebMagnew\Views\Posts\Details.cshtml"
                                                                   Write(Model.Cat.CatName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                <li class=\"breadcrumb-item active\" aria-current=\"page\">");
#nullable restore
#line 18 "C:\Users\kynng\OneDrive\Máy tính\WebMagnew\WebMagnew\Views\Posts\Details.cshtml"
                                                                  Write(Model.Tilte);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
            </ol>
        </nav>

        <div class=""row gy-4"">

            <div class=""col-lg-8"">
                <!-- post single -->
                <div class=""post post-single"">
                    <!-- post header -->
                    <div class=""post-header"">
                        <h1 class=""title mt-0 mb-3"">");
#nullable restore
#line 29 "C:\Users\kynng\OneDrive\Máy tính\WebMagnew\WebMagnew\Views\Posts\Details.cshtml"
                                               Write(Model.Tilte);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                        <ul class=\"meta list-inline mb-0\">\r\n                            <li class=\"list-inline-item\"><a");
            BeginWriteAttribute("href", " href=\"", 1139, "\"", 1150, 1);
#nullable restore
#line 31 "C:\Users\kynng\OneDrive\Máy tính\WebMagnew\WebMagnew\Views\Posts\Details.cshtml"
WriteAttributeValue("", 1146, url, 1146, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img src=\"images/other/author-sm.png\" class=\"author\"");
            BeginWriteAttribute("alt", " alt=\"", 1204, "\"", 1223, 1);
#nullable restore
#line 31 "C:\Users\kynng\OneDrive\Máy tính\WebMagnew\WebMagnew\Views\Posts\Details.cshtml"
WriteAttributeValue("", 1210, Model.Author, 1210, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />");
#nullable restore
#line 31 "C:\Users\kynng\OneDrive\Máy tính\WebMagnew\WebMagnew\Views\Posts\Details.cshtml"
                                                                                                                                              Write(Model.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                            <li class=\"list-inline-item\"><a");
            BeginWriteAttribute("href", " href=\"", 1310, "\"", 1334, 2);
            WriteAttributeValue("", 1317, "/", 1317, 1, true);
#nullable restore
#line 32 "C:\Users\kynng\OneDrive\Máy tính\WebMagnew\WebMagnew\Views\Posts\Details.cshtml"
WriteAttributeValue("", 1318, Model.Cat.Alias, 1318, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 32 "C:\Users\kynng\OneDrive\Máy tính\WebMagnew\WebMagnew\Views\Posts\Details.cshtml"
                                                                                Write(Model.Cat.CatName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                            <li class=\"list-inline-item\">");
#nullable restore
#line 33 "C:\Users\kynng\OneDrive\Máy tính\WebMagnew\WebMagnew\Views\Posts\Details.cshtml"
                                                    Write(Model.CreateAt.Value.ToString("dd MMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        </ul>\r\n                    </div>\r\n                    <!-- featured image -->\r\n                    <div class=\"featured-image\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 1656, "\"", 1687, 2);
            WriteAttributeValue("", 1662, "images/posts/", 1662, 13, true);
#nullable restore
#line 38 "C:\Users\kynng\OneDrive\Máy tính\WebMagnew\WebMagnew\Views\Posts\Details.cshtml"
WriteAttributeValue("", 1675, Model.Thumb, 1675, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1688, "\"", 1706, 1);
#nullable restore
#line 38 "C:\Users\kynng\OneDrive\Máy tính\WebMagnew\WebMagnew\Views\Posts\Details.cshtml"
WriteAttributeValue("", 1694, Model.Tilte, 1694, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    </div>\r\n                    <!-- post content -->\r\n                    <div class=\"post-content clearfix\">\r\n                        ");
#nullable restore
#line 42 "C:\Users\kynng\OneDrive\Máy tính\WebMagnew\WebMagnew\Views\Posts\Details.cshtml"
                   Write(Html.Raw(Model.Contents));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                    <!-- post bottom section -->
                    <div class=""post-bottom"">
                        <div class=""row d-flex align-items-center"">
                            <div class=""col-md-6 col-12 text-center text-md-start"">
                                <!-- tags -->
                                <a");
            BeginWriteAttribute("href", " href=\"", 2251, "\"", 2275, 2);
            WriteAttributeValue("", 2258, "/", 2258, 1, true);
#nullable restore
#line 49 "C:\Users\kynng\OneDrive\Máy tính\WebMagnew\WebMagnew\Views\Posts\Details.cshtml"
WriteAttributeValue("", 2259, Model.Cat.Alias, 2259, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"tag\">");
#nullable restore
#line 49 "C:\Users\kynng\OneDrive\Máy tính\WebMagnew\WebMagnew\Views\Posts\Details.cshtml"
                                                                   Write(Model.Cat.CatName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
            WriteLiteral(@"                            </div>
                            <div class=""col-md-6 col-12"">
                                <!-- social icons -->
                                <ul class=""social-icons list-unstyled list-inline mb-0 float-md-end"">
                                    <li class=""list-inline-item""><a href=""#""><i class=""fab fa-facebook-f""></i></a></li>
                                    <li class=""list-inline-item""><a href=""#""><i class=""fab fa-twitter""></i></a></li>
                                    <li class=""list-inline-item""><a href=""#""><i class=""fab fa-linkedin-in""></i></a></li>
                                    <li class=""list-inline-item""><a href=""#""><i class=""fab fa-pinterest""></i></a></li>
                                    <li class=""list-inline-item""><a href=""#""><i class=""fab fa-telegram-plane""></i></a></li>
                                    <li class=""list-inline-item""><a href=""#""><i class=""far fa-envelope""></i></a></li>
                                </ul>
       ");
            WriteLiteral(@"                     </div>
                        </div>
                    </div>

                </div>

                <div class=""spacer"" data-height=""50""></div>

                <div class=""about-author padding-30 rounded"">
                    <div class=""thumb"">
                        <img");
            BeginWriteAttribute("src", " src=\"", 3784, "\"", 3815, 2);
            WriteAttributeValue("", 3790, "images/posts/", 3790, 13, true);
#nullable restore
#line 73 "C:\Users\kynng\OneDrive\Máy tính\WebMagnew\WebMagnew\Views\Posts\Details.cshtml"
WriteAttributeValue("", 3803, Model.Thumb, 3803, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3816, "\"", 3835, 1);
#nullable restore
#line 73 "C:\Users\kynng\OneDrive\Máy tính\WebMagnew\WebMagnew\Views\Posts\Details.cshtml"
WriteAttributeValue("", 3822, Model.Author, 3822, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    </div>\r\n                    <div class=\"details\">\r\n                        <h4 class=\"name\"><a href=\"#\">");
#nullable restore
#line 76 "C:\Users\kynng\OneDrive\Máy tính\WebMagnew\WebMagnew\Views\Posts\Details.cshtml"
                                                Write(Model.Account.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n\r\n                        <ul class=\"social-icons list-unstyled list-inline mb-0\">\r\n                            ");
#nullable restore
#line 79 "C:\Users\kynng\OneDrive\Máy tính\WebMagnew\WebMagnew\Views\Posts\Details.cshtml"
                       Write(await Component.InvokeAsync("Social"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </ul>
                    </div>
                </div>

                <div class=""spacer"" data-height=""50""></div>


                <div class=""section-header"">
                    <h3 class=""section-title"">Bài viết liên quan</h3>
                    <img src=""images/wave.svg"" class=""wave"" alt=""wave"" />
                </div>

                <div class=""row"">

                    <div class=""col-md-12 col-sm-6"">
                        <!-- post -->
");
#nullable restore
#line 96 "C:\Users\kynng\OneDrive\Máy tính\WebMagnew\WebMagnew\Views\Posts\Details.cshtml"
                         if (BaiVietLienQuan != null && BaiVietLienQuan.Count > 0)
                        {
                            foreach (var item in BaiVietLienQuan)
                            {
                                string _url = $"/{Model.Alias}.html";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""post post-list clearfix"">
                                    <div class=""thumb rounded"">
                                        <span class=""post-format-sm"">
                                            <i class=""icon-picture""></i>
                                        </span>
                                        <a");
            BeginWriteAttribute("href", " href=\"", 5301, "\"", 5313, 1);
#nullable restore
#line 106 "C:\Users\kynng\OneDrive\Máy tính\WebMagnew\WebMagnew\Views\Posts\Details.cshtml"
WriteAttributeValue("", 5308, _url, 5308, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <div class=\"inner\">\r\n                                                <img");
            BeginWriteAttribute("src", " src=\"", 5434, "\"", 5464, 2);
            WriteAttributeValue("", 5440, "images/posts/", 5440, 13, true);
#nullable restore
#line 108 "C:\Users\kynng\OneDrive\Máy tính\WebMagnew\WebMagnew\Views\Posts\Details.cshtml"
WriteAttributeValue("", 5453, item.Thumb, 5453, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 5465, "\"", 5482, 1);
#nullable restore
#line 108 "C:\Users\kynng\OneDrive\Máy tính\WebMagnew\WebMagnew\Views\Posts\Details.cshtml"
WriteAttributeValue("", 5471, item.Tilte, 5471, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                                            </div>
                                        </a>
                                    </div>
                                    <div class=""details"">
                                        <ul class=""meta list-inline mb-3"">
");
            WriteLiteral("                                            <li class=\"list-inline-item\">");
#nullable restore
#line 116 "C:\Users\kynng\OneDrive\Máy tính\WebMagnew\WebMagnew\Views\Posts\Details.cshtml"
                                                                    Write(item.CreateAt.Value.ToString("dd MMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                        </ul>\r\n                                        <h5 class=\"post-title\"><a");
            BeginWriteAttribute("href", " href=\"", 6290, "\"", 6302, 1);
#nullable restore
#line 118 "C:\Users\kynng\OneDrive\Máy tính\WebMagnew\WebMagnew\Views\Posts\Details.cshtml"
WriteAttributeValue("", 6297, _url, 6297, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 118 "C:\Users\kynng\OneDrive\Máy tính\WebMagnew\WebMagnew\Views\Posts\Details.cshtml"
                                                                          Write(item.Tilte);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h5>\r\n                                        <p class=\"excerpt mb-0\">");
#nullable restore
#line 119 "C:\Users\kynng\OneDrive\Máy tính\WebMagnew\WebMagnew\Views\Posts\Details.cshtml"
                                                           Write(item.Scontent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        <div class=\"post-bottom clearfix d-flex align-items-center\">\r\n");
            WriteLiteral("                                        </div>\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 134 "C:\Users\kynng\OneDrive\Máy tính\WebMagnew\WebMagnew\Views\Posts\Details.cshtml"
                            }
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"spacer\" data-height=\"50\"></div>-->\r\n               \r\n");
            WriteLiteral(@"                <!-- comment form -->
                <!--<div class=""comment-form rounded bordered padding-30"">
                    <form asp-action=""CreateComment"" asp-controller=""Posts"">
                        <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
                        <div class=""messages""></div>
                        <div class=""row"">
                            <div class=""column col-md-12"">-->
                                <!-- Comment textarea -->
                                <!--<div class=""form-group"">
                                    <textarea asp-for=""PostId"" name=""InputComment"" id=""InputComment"" class=""form-control"" rows=""4"" placeholder=""Your comment here..."" required=""required""></textarea>
                                    <span asp-validation-for=""PostId"" class=""text-danger""></span>
                                </div>
                            </div>
                        </div>
                        <button type=""submit"" name=""");
            WriteLiteral(@"submit"" id=""submit"" value=""Submit"" class=""btn btn-default"">Submit</button>--><!-- Submit Button -->
                    <!--</form>
                </div>-->
            </div>

            <div class=""col-lg-4"">

                <!-- sidebar -->
                <div class=""sidebar"">
                    <!-- widget about -->
                    <div class=""widget rounded"">
                        <div class=""widget-about data-bg-image text-center"" data-bg-image=""images/map-bg.png"">
                            <img src=""images/logo.svg"" alt=""logo"" class=""mb-4"" />
                            <p class=""mb-4"">Hello, We’re content writer who is fascinated by content fashion, celebrity and lifestyle. We helps clients bring the right content to the right people.</p>
                            <ul class=""social-icons list-unstyled list-inline mb-0"">
                                <li class=""list-inline-item""><a href=""#""><i class=""fab fa-facebook-f""></i></a></li>
                                <li c");
            WriteLiteral(@"lass=""list-inline-item""><a href=""#""><i class=""fab fa-twitter""></i></a></li>
                                <li class=""list-inline-item""><a href=""#""><i class=""fab fa-instagram""></i></a></li>
                                <li class=""list-inline-item""><a href=""#""><i class=""fab fa-pinterest""></i></a></li>
                                <li class=""list-inline-item""><a href=""#""><i class=""fab fa-medium""></i></a></li>
                                <li class=""list-inline-item""><a href=""#""><i class=""fab fa-youtube""></i></a></li>
                            </ul>
                        </div>
                    </div>

                    <!-- widget popular posts -->
                    <div class=""widget rounded"">
                        <div class=""widget-content"">
                            ");
#nullable restore
#line 188 "C:\Users\kynng\OneDrive\Máy tính\WebMagnew\WebMagnew\Views\Posts\Details.cshtml"
                       Write(await Component.InvokeAsync("Popular"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                           
                        </div>
                    </div>

                    <!-- widget categories -->
                    <div class=""widget rounded"">
                        <div class=""widget-header text-center"">
                            <h3 class=""widget-title"">Explore Topics</h3>
                            <img src=""images/wave.svg"" class=""wave"" alt=""wave"" />
                        </div>
                        <div class=""widget-content"">
                            ");
#nullable restore
#line 200 "C:\Users\kynng\OneDrive\Máy tính\WebMagnew\WebMagnew\Views\Posts\Details.cshtml"
                       Write(await Component.InvokeAsync("Categories"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>

                    </div>

                    <!-- widget newsletter -->
                    <div class=""widget rounded"">
                        <div class=""widget-header text-center"">
                            <h3 class=""widget-title"">Newsletter</h3>
                            <img src=""images/wave.svg"" class=""wave"" alt=""wave"" />
                        </div>
                        <div class=""widget-content"">
                            <span class=""newsletter-headline text-center mb-3"">Join 70,000 subscribers!</span>
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0af0818f3a69aa1e94d56f5de8def668bd63e21d24253", async() => {
                WriteLiteral(@"
                                <div class=""mb-2"">
                                    <input class=""form-control w-100 text-center"" placeholder=""Email address…"" type=""email"">
                                </div>
                                <button class=""btn btn-default btn-full"" type=""submit"">Sign Up</button>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            <span class=""newsletter-privacy text-center mt-3"">By signing up, you agree to our <a href=""#"">Privacy Policy</a></span>
                        </div>
                    </div>

                    <!-- widget post carousel -->
                    <div class=""widget rounded"">
                        <div class=""widget-header text-center"">
                            <h3 class=""widget-title"">Celebration</h3>
                            <img src=""images/wave.svg"" class=""wave"" alt=""wave"" />
                        </div>
                        <div class=""widget-content"">
                            <div class=""post-carousel-widget"">
                                <!-- post -->
                                <div class=""post post-carousel"">
                                    <div class=""thumb rounded"">
                                        <a href=""category.html"" class=""category-badge position-absolute"">How to</a>
                                        <a hre");
            WriteLiteral(@"f=""blog-single.html"">
                                            <div class=""inner"">
                                                <img src=""images/widgets/widget-carousel-1.jpg"" alt=""post-title"" />
                                            </div>
                                        </a>
                                    </div>
                                    <h5 class=""post-title mb-0 mt-4""><a href=""blog-single.html"">5 Easy Ways You Can Turn Future Into Success</a></h5>
                                    <ul class=""meta list-inline mt-2 mb-0"">
                                        <li class=""list-inline-item""><a href=""#"">Katen Doe</a></li>
                                        <li class=""list-inline-item"">29 March 2021</li>
                                    </ul>
                                </div>
                                <!-- post -->
                                <div class=""post post-carousel"">
                                    <div class=""thumb rounded"">");
            WriteLiteral(@"
                                        <a href=""category.html"" class=""category-badge position-absolute"">Trending</a>
                                        <a href=""blog-single.html"">
                                            <div class=""inner"">
                                                <img src=""images/widgets/widget-carousel-2.jpg"" alt=""post-title"" />
                                            </div>
                                        </a>
                                    </div>
                                    <h5 class=""post-title mb-0 mt-4""><a href=""blog-single.html"">Master The Art Of Nature With These 7 Tips</a></h5>
                                    <ul class=""meta list-inline mt-2 mb-0"">
                                        <li class=""list-inline-item""><a href=""#"">Katen Doe</a></li>
                                        <li class=""list-inline-item"">29 March 2021</li>
                                    </ul>
                                </div>
           ");
            WriteLiteral(@"                     <!-- post -->
                                <div class=""post post-carousel"">
                                    <div class=""thumb rounded"">
                                        <a href=""category.html"" class=""category-badge position-absolute"">How to</a>
                                        <a href=""blog-single.html"">
                                            <div class=""inner"">
                                                <img src=""images/widgets/widget-carousel-1.jpg"" alt=""post-title"" />
                                            </div>
                                        </a>
                                    </div>
                                    <h5 class=""post-title mb-0 mt-4""><a href=""blog-single.html"">5 Easy Ways You Can Turn Future Into Success</a></h5>
                                    <ul class=""meta list-inline mt-2 mb-0"">
                                        <li class=""list-inline-item""><a href=""#"">Katen Doe</a></li>
                  ");
            WriteLiteral(@"                      <li class=""list-inline-item"">29 March 2021</li>
                                    </ul>
                                </div>
                            </div>
                            <!-- carousel arrows -->
                            <div class=""slick-arrows-bot"">
                                <button type=""button"" data-role=""none"" class=""carousel-botNav-prev slick-custom-buttons"" aria-label=""Previous""><i class=""icon-arrow-left""></i></button>
                                <button type=""button"" data-role=""none"" class=""carousel-botNav-next slick-custom-buttons"" aria-label=""Next""><i class=""icon-arrow-right""></i></button>
                            </div>
                        </div>
                    </div>

                    <!-- widget advertisement -->
                    <div class=""widget no-container rounded text-md-center"">
                        <span class=""ads-title"">- Sponsored Ad -</span>
                        <a href=""#"" class=""widget-ads");
            WriteLiteral(@""">
                            <img src=""images/ads/ad-360.png"" alt=""Advertisement"" />
                        </a>
                    </div>

                    <!-- widget tags -->
                    <div class=""widget rounded"">
                        <div class=""widget-header text-center"">
                            <h3 class=""widget-title"">Tag Clouds</h3>
                            <img src=""images/wave.svg"" class=""wave"" alt=""wave"" />
                        </div>
                        <div class=""widget-content"">
                            <a href=""#"" class=""tag"">#Trending</a>
                            <a href=""#"" class=""tag"">#Video</a>
                            <a href=""#"" class=""tag"">#Featured</a>
                            <a href=""#"" class=""tag"">#Gallery</a>
                            <a href=""#"" class=""tag"">#Celebrities</a>
                        </div>
                    </div>

                </div>

            </div>

        </div>

    </div>
</sec");
            WriteLiteral("tion>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0af0818f3a69aa1e94d56f5de8def668bd63e21d32373", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 320 "C:\Users\kynng\OneDrive\Máy tính\WebMagnew\WebMagnew\Views\Posts\Details.cshtml"
                           WriteLiteral(Model.PostId);

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
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0af0818f3a69aa1e94d56f5de8def668bd63e21d34521", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebMagnew.Models.Post> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
