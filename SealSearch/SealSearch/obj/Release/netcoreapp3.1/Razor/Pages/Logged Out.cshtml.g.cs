#pragma checksum "C:\Users\nicol\source\repos\SealSearch\SealSearch\Pages\Logged Out.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f6ad63b09344704b8867e997d2a75420909b040"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SealSearch.Pages.Pages_Logged_Out), @"mvc.1.0.razor-page", @"/Pages/Logged Out.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f6ad63b09344704b8867e997d2a75420909b040", @"/Pages/Logged Out.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b185f284d73e71cdb91bd4a683a446524dac4926", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Logged_Out : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\nicol\source\repos\SealSearch\SealSearch\Pages\Logged Out.cshtml"
  
    ViewData["Title"] = "Logged Out Successfully";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .card {
        box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2);
        max-width: 300px;
        margin: auto;
        text-align:center;
        font-family: 'Times New Roman', Times, serif;
        background-color: lightgoldenrodyellow;
        opacity: 0.95;
    }
</style>

<div class=""card"">
    <h1 style=""padding-bottom: 20px;"">");
#nullable restore
#line 20 "C:\Users\nicol\source\repos\SealSearch\SealSearch\Pages\Logged Out.cshtml"
                                 Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n    <p style=\"font-weight:bold\">You have been safely logged out from the site at ");
#nullable restore
#line 22 "C:\Users\nicol\source\repos\SealSearch\SealSearch\Pages\Logged Out.cshtml"
                                                                            Write(DateTime.Now);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>

    <p><br></p>

    <p>To sign back in, please click the link below:</p>
    <button onclick=""window.location.href='https://sealsearchcareers.azurewebsites.net/Sign-In';"">
        Sign-in
    </button>

    <p><br></p>
    <p>To create an account, please click the link below:</p>
    <button onclick=""window.location.href='https://sealsearchcareers.azurewebsites.net/CreateCandidate';"">
        Create Account
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SealSearch.Pages.Logged_OutModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SealSearch.Pages.Logged_OutModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SealSearch.Pages.Logged_OutModel>)PageContext?.ViewData;
        public SealSearch.Pages.Logged_OutModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
