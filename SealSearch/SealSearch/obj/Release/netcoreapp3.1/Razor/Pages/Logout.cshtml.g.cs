#pragma checksum "C:\Users\nicol\source\repos\SealSearch\SealSearch\Pages\Logout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e01ebf3b3679cbbb79da284f5c6fc01abaef1a0d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SealSearch.Pages.Pages_Logout), @"mvc.1.0.razor-page", @"/Pages/Logout.cshtml")]
namespace SealSearch.Pages
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
#line 1 "C:\Users\nicol\source\repos\SealSearch\SealSearch\Pages\_ViewImports.cshtml"
using SealSearch;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e01ebf3b3679cbbb79da284f5c6fc01abaef1a0d", @"/Pages/Logout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b185f284d73e71cdb91bd4a683a446524dac4926", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Logout : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\nicol\source\repos\SealSearch\SealSearch\Pages\Logout.cshtml"
  
    ViewData["Title"] = "Logout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .card {
        box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2);
        max-width: 300px;
        margin: auto;
        text-align: center;
        font-family: 'Times New Roman', Times, serif;
        background-color: lightgoldenrodyellow;
        opacity: 0.95;
    }
</style>

<div class=""card"">
    <p style=""padding-top: 20px; font-weight: bold; font-size: 24px;"">Are you sure you want to logout?</p>

    <button onclick=""window.location.href='https://sealsearchcareers.azurewebsites.net/Logged Out';"">
        Yes
    </button>
    <button onclick=""window.location.href='https://sealsearchcareers.azurewebsites.net/';"">
        No
    </button>
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SealSearch.Pages.LogoutModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SealSearch.Pages.LogoutModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SealSearch.Pages.LogoutModel>)PageContext?.ViewData;
        public SealSearch.Pages.LogoutModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591