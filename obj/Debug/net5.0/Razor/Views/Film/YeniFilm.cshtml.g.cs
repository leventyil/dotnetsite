#pragma checksum "C:\Projects\DOTNET\moviebase\Views\Film\YeniFilm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e223928ceef32defdd1d7afdd4112aaf07babd39"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Film_YeniFilm), @"mvc.1.0.view", @"/Views/Film/YeniFilm.cshtml")]
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
#line 1 "C:\Projects\DOTNET\moviebase\Views\_ViewImports.cshtml"
using moviesite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\DOTNET\moviebase\Views\_ViewImports.cshtml"
using moviesite.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Projects\DOTNET\moviebase\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e223928ceef32defdd1d7afdd4112aaf07babd39", @"/Views/Film/YeniFilm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"828a53029db0d138b14fd8aaf0572a561cefcaf0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Film_YeniFilm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<moviesite.Models.Film>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-group"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Projects\DOTNET\moviebase\Views\Film\YeniFilm.cshtml"
  
    ViewData["Title"] = "Add New Movie";
    Layout = "~/Views/Shared/_Sidebar.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br/>\r\n\r\n<div class=\"col-4\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e223928ceef32defdd1d7afdd4112aaf07babd394299", async() => {
                WriteLiteral("\r\n        <label>Movie Title</label>\r\n        ");
#nullable restore
#line 12 "C:\Projects\DOTNET\moviebase\Views\Film\YeniFilm.cshtml"
   Write(Html.TextBoxFor(x => x.FilmName, new { @class = "form-control", placeholder = "Movie Title" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
#nullable restore
#line 13 "C:\Projects\DOTNET\moviebase\Views\Film\YeniFilm.cshtml"
   Write(Html.ValidationMessageFor(x => x.FilmName, "", new { @style = "color:red" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <br />\r\n        <label>Year</label>\r\n        ");
#nullable restore
#line 16 "C:\Projects\DOTNET\moviebase\Views\Film\YeniFilm.cshtml"
   Write(Html.TextBoxFor(x => x.FilmYear, new { @class = "form-control", placeholder = "Year" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
#nullable restore
#line 17 "C:\Projects\DOTNET\moviebase\Views\Film\YeniFilm.cshtml"
   Write(Html.ValidationMessageFor(x => x.FilmYear, "", new { @style = "color:red" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <br />\r\n        <label>Length (minutes)</label>\r\n        ");
#nullable restore
#line 20 "C:\Projects\DOTNET\moviebase\Views\Film\YeniFilm.cshtml"
   Write(Html.TextBoxFor(x => x.FilmLength, new { @class = "form-control", placeholder = "Length (minutes)" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
#nullable restore
#line 21 "C:\Projects\DOTNET\moviebase\Views\Film\YeniFilm.cshtml"
   Write(Html.ValidationMessageFor(x => x.FilmLength, "", new { @style = "color:red" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <br />\r\n        <label>IMDb Score</label>\r\n        ");
#nullable restore
#line 24 "C:\Projects\DOTNET\moviebase\Views\Film\YeniFilm.cshtml"
   Write(Html.TextBoxFor(x => x.FilmScore, new { @class = "form-control", placeholder = "IMDb Score" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
#nullable restore
#line 25 "C:\Projects\DOTNET\moviebase\Views\Film\YeniFilm.cshtml"
   Write(Html.ValidationMessageFor(x => x.FilmScore, "", new { @style = "color:red" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <br />\r\n        <label>Metascore Score</label>\r\n        ");
#nullable restore
#line 28 "C:\Projects\DOTNET\moviebase\Views\Film\YeniFilm.cshtml"
   Write(Html.TextBoxFor(x => x.FilmScoreTwo, new { @class = "form-control", placeholder = "Metascore Score" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
#nullable restore
#line 29 "C:\Projects\DOTNET\moviebase\Views\Film\YeniFilm.cshtml"
   Write(Html.ValidationMessageFor(x => x.FilmScoreTwo, "", new { @style = "color:red" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <br />\r\n        <button class=\"btn btn-info\">Add Entry</button>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<moviesite.Models.Film> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
