#pragma checksum "C:\Users\nicol\source\repos\SealSearch\SealSearch\Pages\AccountSuccessful.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "50ea3771977fd74020dce9a8846bb79ecac5792c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SealSearch.Pages.Pages_AccountSuccessful), @"mvc.1.0.razor-page", @"/Pages/AccountSuccessful.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50ea3771977fd74020dce9a8846bb79ecac5792c", @"/Pages/AccountSuccessful.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b185f284d73e71cdb91bd4a683a446524dac4926", @"/Pages/_ViewImports.cshtml")]
    public class Pages_AccountSuccessful : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\nicol\source\repos\SealSearch\SealSearch\Pages\AccountSuccessful.cshtml"
  
    ViewData["Title"] = "Account Creation Successful";

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
        opacity: 0.9;
    }
</style>

<div class=""card"">
    <h1>");
#nullable restore
#line 20 "C:\Users\nicol\source\repos\SealSearch\SealSearch\Pages\AccountSuccessful.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n    <p>To go to your homepage, click here: </p>\r\n    <button onclick=\"window.location.href=\'https://sealsearchcareers.azurewebsites.net/\';\">\r\n        Home\r\n    </button>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SealSearch.Pages.AccountSuccessfulModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SealSearch.Pages.AccountSuccessfulModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SealSearch.Pages.AccountSuccessfulModel>)PageContext?.ViewData;
        public SealSearch.Pages.AccountSuccessfulModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
