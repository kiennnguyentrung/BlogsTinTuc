#pragma checksum "C:\Users\kynng\OneDrive\Máy tính\WebMagnew\WebMagnew\Views\Shared\Components\Navsub\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9019978860f8cff9d1579472773a78bf432029c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Navsub_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Navsub/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9019978860f8cff9d1579472773a78bf432029c2", @"/Views/Shared/Components/Navsub/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f40af3f0863beea5bde5638f26cf47b098d85081", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_Navsub_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Category>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\kynng\OneDrive\Máy tính\WebMagnew\WebMagnew\Views\Shared\Components\Navsub\Default.cshtml"
 if (Model != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"dropdown-menu\">\r\n        <ul class=\"list\">\r\n");
#nullable restore
#line 6 "C:\Users\kynng\OneDrive\Máy tính\WebMagnew\WebMagnew\Views\Shared\Components\Navsub\Default.cshtml"
             foreach (var item in Model)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\kynng\OneDrive\Máy tính\WebMagnew\WebMagnew\Views\Shared\Components\Navsub\Default.cshtml"
                 if(item.Levels ==2 && item.Parents == 1)
                { 

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li><a class=\"dropdown-item\"");
            BeginWriteAttribute("href", " href=\"", 287, "\"", 306, 2);
            WriteAttributeValue("", 294, "/", 294, 1, true);
#nullable restore
#line 10 "C:\Users\kynng\OneDrive\Máy tính\WebMagnew\WebMagnew\Views\Shared\Components\Navsub\Default.cshtml"
WriteAttributeValue("", 295, item.Alias, 295, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 10 "C:\Users\kynng\OneDrive\Máy tính\WebMagnew\WebMagnew\Views\Shared\Components\Navsub\Default.cshtml"
                                                            Write(item.CatName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 11 "C:\Users\kynng\OneDrive\Máy tính\WebMagnew\WebMagnew\Views\Shared\Components\Navsub\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\kynng\OneDrive\Máy tính\WebMagnew\WebMagnew\Views\Shared\Components\Navsub\Default.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n    </div>\r\n");
#nullable restore
#line 15 "C:\Users\kynng\OneDrive\Máy tính\WebMagnew\WebMagnew\Views\Shared\Components\Navsub\Default.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Category>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
