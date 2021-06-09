#pragma checksum "C:\Users\nicol\source\repos\SealSearch\SealSearch\Pages\Settings.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "946e76e0cd3813b08a9412f4b5a922ae795fb41b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SealSearch.Pages.Pages_Settings), @"mvc.1.0.razor-page", @"/Pages/Settings.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"946e76e0cd3813b08a9412f4b5a922ae795fb41b", @"/Pages/Settings.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b185f284d73e71cdb91bd4a683a446524dac4926", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Settings : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\nicol\source\repos\SealSearch\SealSearch\Pages\Settings.cshtml"
  
    ViewData["Title"] = "User Settings";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!--Profile Card-->\r\n<!DOCTYPE html>\r\n<!--<html>-->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "946e76e0cd3813b08a9412f4b5a922ae795fb41b3275", async() => {
                WriteLiteral(@"
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"">
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

        .title {
            color: grey;
            font-size: 18px;
        }

        button {
            border: none;
            outline: 0;
            display: inline-block;
            padding: 8px;
            color: white;
            background-color: #000;
            text-align: center;
            cursor: pointer;
            width: 100%;
            font-size: 18px;
        }

        a {
            text-decoration: none;
            font-size: 22px;
            color: black;
        }

            button:hover, a:hover {
");
                WriteLiteral(@"                opacity: 0.7;
            }



        /*Code I wrote for the profile body*/
        .settingscard {
            box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2);
            max-width: 600px;
            margin: auto;
            margin-top: 25px;
            text-align: center;
            font-family: arial;
            padding-bottom: 10px;
            font-size: 16px;
            font-family: 'Times New Roman', Times, serif;
            background-color: lightgoldenrodyellow;
            opacity: 0.9;
        }

        .end {
            padding-top: 20px;
            padding-bottom: 50px;
        }
    </style>




    <!--Cutting and pasting the head from the profile body here-->
    <meta charset=""utf-8"" />
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge;chrome=1"" />
    <meta http-equiv=""Content-Type"" content=""text/html;charset=UTF-8"" />
    <meta name=""google"" content=""notranslate"" />
    <!-- Metadata (autofilled by ""Save to HTML"") -->
    <meta");
                WriteLiteral(@" name=""author"" content=""Joe Smith"" />
    <meta name=""subject"" content=""A really good software engineer you should hire"" />
    <meta name=""keywords"" content=""coding, developing, hacking"" />
    <meta name=""date"" content=""2009-04-01"" />
    <meta name=""generator"" content=""html-resume-template"" />
    <!-- Google Fonts, Normalize, and Font Awesome -->
    <link rel=""stylesheet"" type=""text/css"" href=""https://fonts.googleapis.com/css?family=Cardo|Montserrat:300,400,500&amp;subset=latin-ext"" crossorigin=""anonymous"" />
    <link rel=""stylesheet"" type=""text/css"" href=""https://cdnjs.cloudflare.com/ajax/libs/normalize/8.0.0/normalize.min.css"" integrity=""sha256-oSrCnRYXvHG31SBifqP2PM1uje7SJUyX0nTwO2RJV54="" crossorigin=""anonymous"" />
    <!--<link rel=""stylesheet"" type=""text/css"" href=""https://use.fontawesome.com/releases/v5.1.0/css/all.css"" integrity=""sha384-lKuwvrZot6UHsBSfcMvOkWwlCMgc0TaWr+30HWe3a4ltaBwTZhyTEggF5tJv8tbt"" crossorigin=""anonymous"" />-->
    <!-- Custom Styles -->
    <link rel=""stylesheet"" ty");
                WriteLiteral(@"pe=""text/css"" href=""./paper.css"" />
    <link rel=""stylesheet"" type=""text/css"" href=""./styles.css"" />
    <link rel=""stylesheet"" type=""text/css"" href=""./typography.css"" />
    <link rel=""stylesheet"" type=""text/css"" media=""screen"" href=""./screen.css"" />
    <link rel=""stylesheet"" type=""text/css"" media=""print"" href=""./print.css"" />
    <script async defer src=""https://buttons.github.io/buttons.js""></script>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "946e76e0cd3813b08a9412f4b5a922ae795fb41b7939", async() => {
                WriteLiteral(@"
    <!--Job Search-->
    <div class=""settingscard"">
        <h6 style=""text-align: left; font-family: courier; font-size: 30px; padding-left: 5px; padding-top: 5px; font-weight: bold; color: black;"">Job Search</h6>

            <a href='https://sealsearchcareers.azurewebsites.net/Accounts/Settings/Job Criteria'><span>Job Criteria</span></a>
            <p><br /></p>
            <a href='https://sealsearchcareers.azurewebsites.net/Accounts/Settings/Manage Followed Companies'><span>Manage Followed Companies</span></a>
            <p><br /></p>
            <a href='https://sealsearchcareers.azurewebsites.net/Accounts/Settings/Applied Jobs'><span>Applied Jobs</span></a>

    </div>



    <!--Profile-->
    <div class=""settingscard"">
        <h6 style=""text-align: left; font-family: courier; font-size: 30px; padding-left: 5px; padding-top: 5px; font-weight: bold; color: black;"">Profile</h6>
        <a href='https://sealsearchcareers.azurewebsites.net/Accounts/Settings/Change Password'><span>Ch");
                WriteLiteral(@"ange Password</span></a>
        <p><br /></p>
        <a href='https://sealsearchcareers.azurewebsites.net/Accounts/Settings/Hibernate Account'><span>Hibernate Account</span></a>
        <p><br /></p>
        <a href='https://sealsearchcareers.azurewebsites.net/Accounts/Settings/Delete Account'><span>Delete Account</span></a>
    </div>

    <!--Privacy-->
    <div class=""settingscard"">
        <h6 style=""text-align: left; font-family: courier; font-size: 30px; padding-left: 5px; padding-top: 5px; font-weight: bold; color: black;"">Privacy</h6>
        <a href='https://sealsearchcareers.azurewebsites.net/Accounts/Settings/Profile Visibility'><span>Profile Visibility</span></a>
        <p><br /></p>
        <a href='https://sealsearchcareers.azurewebsites.net/Accounts/Settings/Search Results'><span>Search Results</span></a>
        <p><br /></p>
        <a href='https://sealsearchcareers.azurewebsites.net/Accounts/Settings/Blocked List'>Blocked List</a>
    </div>


    <div class=""end"">
   ");
                WriteLiteral(" </div>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<!--</html>-->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SealSearch.Pages.SettingsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SealSearch.Pages.SettingsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SealSearch.Pages.SettingsModel>)PageContext?.ViewData;
        public SealSearch.Pages.SettingsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591