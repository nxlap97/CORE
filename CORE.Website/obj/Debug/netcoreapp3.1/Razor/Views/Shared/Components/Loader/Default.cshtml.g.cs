#pragma checksum "D:\Project\CORE\CORE.Website\Views\Shared\Components\Loader\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd82a4d042a48d6743ae69e2b980a255d59a4b31"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Loader_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Loader/Default.cshtml")]
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
#line 1 "D:\Project\CORE\CORE.Website\Views\_ViewImports.cshtml"
using CORE.Website;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Project\CORE\CORE.Website\Views\_ViewImports.cshtml"
using CORE.Website.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd82a4d042a48d6743ae69e2b980a255d59a4b31", @"/Views/Shared/Components/Loader/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cad91ad0ad77c0cf959f9a5ee4e7c128fbdd667a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Loader_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""loading-content"">
    <div class=""loadingitem"">
        <img src=""/Assets/img/loading.gif"">
    </div>
    <div class=""loader-section section-left"" style="" background-image: url('/Assets/img/pattern-3.png');""></div>
    <div class=""loader-section section-right"" style="" background-image: url('/Assets/img/pattern-3.png');""></div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
