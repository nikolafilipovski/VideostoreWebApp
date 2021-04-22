#pragma checksum "C:\Users\Matej & Marko\Desktop\Code Academy\VideostoreWebApp\Videostore\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "492ce6f943ba0ee3c429adaa31244d80cb5f40eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Matej & Marko\Desktop\Code Academy\VideostoreWebApp\Videostore\Views\_ViewImports.cshtml"
using Videostore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Matej & Marko\Desktop\Code Academy\VideostoreWebApp\Videostore\Views\_ViewImports.cshtml"
using Videostore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"492ce6f943ba0ee3c429adaa31244d80cb5f40eb", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afa4673e56c8e84078352aff3a5d3b5b648b6ec6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Videostore.Entities.Movie>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary btn-block text-light text-decoration-none"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Watchlist", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/homePageStyle.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Matej & Marko\Desktop\Code Academy\VideostoreWebApp\Videostore\Views\Home\Index.cshtml"
   ViewData["Title"] = "Videostore"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n<!-- Search section -->\n<div class=\"row\">\n    <div class=\"col-sm-12 col-md-12\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "492ce6f943ba0ee3c429adaa31244d80cb5f40eb5950", async() => {
                WriteLiteral(@"
            <div class=""search-main"">
                <button class=""btn search-btn-icon"" id=""mGlass"">
                    <i class=""fas fa-search"" id=""icon""></i>
                </button>
                <input type=""text"" class=""form-control search-box-style"" id=""movieSearch"" />
                <button class=""btn btn-success search-btn"" id=""searchBtn"">Search</button>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n</div>\n\n<!-- Movies Section -->\n<div class=\"row\">\n    <div class=\"col-sm-12 col-md-12\">\n        <h2 class=\"text-center mt-5\">All Movies</h2>\n\n    </div>\n</div>\n\n");
#nullable restore
#line 30 "C:\Users\Matej & Marko\Desktop\Code Academy\VideostoreWebApp\Videostore\Views\Home\Index.cshtml"
 foreach (var movie in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card h-100 mx-auto\" style=\"max-width: 350px;\">\n            <div class=\"image\">\n                <img");
            BeginWriteAttribute("src", " src=\"", 934, "\"", 940, 0);
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 941, "\"", 947, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\"");
            BeginWriteAttribute("style", " style=\"", 969, "\"", 977, 0);
            EndWriteAttribute();
            WriteLiteral(" />\n            </div>\n            <div class=\"card-body\">\n                <div class=\"text-center d-flex flex-column justify-content-center\" style=\"height:120px\">\n                    <h5 class=\"card-title w-100\"><a class=\"text-dark\"");
            BeginWriteAttribute("href", " href=\"", 1211, "\"", 1218, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 38 "C:\Users\Matej & Marko\Desktop\Code Academy\VideostoreWebApp\Videostore\Views\Home\Index.cshtml"
                                                                         Write(Html.DisplayFor(modelItem => movie.title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h5>\n                    <h6");
            BeginWriteAttribute("class", " class=\"", 1295, "\"", 1303, 0);
            EndWriteAttribute();
            WriteLiteral("><em>by <a class=\"text-dark\"");
            BeginWriteAttribute("href", " href=\"", 1332, "\"", 1339, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 39 "C:\Users\Matej & Marko\Desktop\Code Academy\VideostoreWebApp\Videostore\Views\Home\Index.cshtml"
                                                                Write(Html.DisplayFor(modelItem => movie.studioName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></em></h6>\n                </div>\n                <hr />\n                <p class=\"card-text\">Rating: ");
#nullable restore
#line 42 "C:\Users\Matej & Marko\Desktop\Code Academy\VideostoreWebApp\Videostore\Views\Home\Index.cshtml"
                                        Write(Html.DisplayFor(modelItem => movie.rating));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                <p class=\"card-text\">Genre: ");
#nullable restore
#line 43 "C:\Users\Matej & Marko\Desktop\Code Academy\VideostoreWebApp\Videostore\Views\Home\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => movie.genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                <p class=\"card-text\">Description: ");
#nullable restore
#line 44 "C:\Users\Matej & Marko\Desktop\Code Academy\VideostoreWebApp\Videostore\Views\Home\Index.cshtml"
                                             Write(Html.DisplayFor(modelItem => movie.description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    <button class=\"btn btn-secondary btn-block\"><i class=\"fas fa-plus-circle\"></i> Add to Watchlist</button>\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "492ce6f943ba0ee3c429adaa31244d80cb5f40eb11436", async() => {
                WriteLiteral("<i class=\"fas fa-plus-circle\"></i> Add to Watchlist");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n            </div>\n\n        </div>\n");
#nullable restore
#line 51 "C:\Users\Matej & Marko\Desktop\Code Academy\VideostoreWebApp\Videostore\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n\n\n\n\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "492ce6f943ba0ee3c429adaa31244d80cb5f40eb13280", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Videostore.Entities.Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591
