#pragma checksum "C:\Users\kynng\OneDrive\Máy tính\WebMagnew\WebMagnew\Views\Shared\Components\Trending\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39011a829b8d0d2acf7d6e6f55708fc671eca804"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Trending_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Trending/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39011a829b8d0d2acf7d6e6f55708fc671eca804", @"/Views/Shared/Components/Trending/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f40af3f0863beea5bde5638f26cf47b098d85081", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_Trending_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Post>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/wave.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("wave"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("wave"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\kynng\OneDrive\Máy tính\WebMagnew\WebMagnew\Views\Shared\Components\Trending\Default.cshtml"
 if (Model != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"widget rounded\">\r\n        <div class=\"widget-header text-center\">\r\n            <h3 class=\"widget-title\"> Thịnh hành</h3>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "39011a829b8d0d2acf7d6e6f55708fc671eca8044655", async() => {
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
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"widget-content\">\r\n");
#nullable restore
#line 12 "C:\Users\kynng\OneDrive\Máy tính\WebMagnew\WebMagnew\Views\Shared\Components\Trending\Default.cshtml"
                 if (Model != null && Model.Count > 0)
                {
                    foreach (var item in Model)
                    { 
                        if(item.IsHot == true && item.IsNewFeed == true)
                        {    
                        string url = $"/{item.Alias}.html";

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"post post-list-sm square before-seperator\">\r\n                            <div class=\"thumb rounded\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 832, "\"", 843, 1);
#nullable restore
#line 21 "C:\Users\kynng\OneDrive\Máy tính\WebMagnew\WebMagnew\Views\Shared\Components\Trending\Default.cshtml"
WriteAttributeValue("", 839, url, 839, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <div class=\"inner\">\r\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 948, "\"", 978, 2);
            WriteAttributeValue("", 954, "images/posts/", 954, 13, true);
#nullable restore
#line 23 "C:\Users\kynng\OneDrive\Máy tính\WebMagnew\WebMagnew\Views\Shared\Components\Trending\Default.cshtml"
WriteAttributeValue("", 967, item.Thumb, 967, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 979, "\"", 996, 1);
#nullable restore
#line 23 "C:\Users\kynng\OneDrive\Máy tính\WebMagnew\WebMagnew\Views\Shared\Components\Trending\Default.cshtml"
WriteAttributeValue("", 985, item.Tilte, 985, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                    </div>\r\n                                </a>\r\n                            </div>\r\n                            <div class=\"details clearfix\">\r\n                                <h6 class=\"post-title my-0\"><a");
            BeginWriteAttribute("href", " href=\"", 1242, "\"", 1253, 1);
#nullable restore
#line 28 "C:\Users\kynng\OneDrive\Máy tính\WebMagnew\WebMagnew\Views\Shared\Components\Trending\Default.cshtml"
WriteAttributeValue("", 1249, url, 1249, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 28 "C:\Users\kynng\OneDrive\Máy tính\WebMagnew\WebMagnew\Views\Shared\Components\Trending\Default.cshtml"
                                                                      Write(item.Tilte);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h6>\r\n                                <ul class=\"meta list-inline mt-1 mb-0\">\r\n                                    <li class=\"list-inline-item\">");
#nullable restore
#line 30 "C:\Users\kynng\OneDrive\Máy tính\WebMagnew\WebMagnew\Views\Shared\Components\Trending\Default.cshtml"
                                                            Write(item.CreateAt.Value.ToString("dd MMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                </ul>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 34 "C:\Users\kynng\OneDrive\Máy tính\WebMagnew\WebMagnew\Views\Shared\Components\Trending\Default.cshtml"
                        }
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n");
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 40 "C:\Users\kynng\OneDrive\Máy tính\WebMagnew\WebMagnew\Views\Shared\Components\Trending\Default.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Post>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
