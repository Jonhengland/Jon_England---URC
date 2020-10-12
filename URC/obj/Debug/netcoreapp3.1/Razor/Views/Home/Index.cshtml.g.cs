#pragma checksum "C:\Users\Peter\source\repos\ps4-urc-continued-pf_ps4\URC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0be67578c667e718693e501bf2e885a860a3f90"
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
#line 1 "C:\Users\Peter\source\repos\ps4-urc-continued-pf_ps4\URC\Views\_ViewImports.cshtml"
using URC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Peter\source\repos\ps4-urc-continued-pf_ps4\URC\Views\_ViewImports.cshtml"
using URC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0be67578c667e718693e501bf2e885a860a3f90", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fcea820b63b567f6937a79c413a93a4819856ae", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<URC.Models.Opportunity>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-lg text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background: #cc0000; border: solid #cc0000 1px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Opportunity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn featured-button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "OpportunityDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!--
  Author:    Peter Forsling
  Partner:   Noah Jackson
  Date:      24 September 2020
  Course:    CS 4540, University of Utah, School of Computing
  Copyright: CS 4540 and Peter Forsling/Noah Jackson - This work may not be copied for use in Academic Coursework.

  I, Peter Forsling/Noah Jackson, certify that I wrote this code from scratch and did not copy it in part or whole from
  another source.  Any references used in the completion of the assignment are cited in my README file.

  File Contents

    This file contains the HTML code to display the home page.
-->

");
            WriteLiteral("\r\n<!doctype html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0be67578c667e718693e501bf2e885a860a3f906710", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\">\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 830, "\"", 840, 0);
                EndWriteAttribute();
                WriteLiteral(@">
    <meta name=""author"" content=""Mark Otto, Jacob Thornton, and Bootstrap contributors"">
    <meta name=""generator"" content=""Jekyll v4.1.1"">
    <title>Jumbotron Template · Bootstrap</title>

    <link rel=""canonical"" href=""https://getbootstrap.com/docs/4.5/examples/jumbotron/"">

    <!-- Bootstrap core CSS -->
    <link href=""/docs/4.5/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-JcKb8q3iqJ61gNV9KGb8thSsNjpSL0n8PARn9HuZOnIxN0hoP+VmmDGMN5t9UJ0Z"" crossorigin=""anonymous"">

    <!-- Favicons -->
    <link rel=""apple-touch-icon"" href=""/docs/4.5/assets/img/favicons/apple-touch-icon.png"" sizes=""180x180"">
    <link rel=""icon"" href=""/docs/4.5/assets/img/favicons/favicon-32x32.png"" sizes=""32x32"" type=""image/png"">
    <link rel=""icon"" href=""/docs/4.5/assets/img/favicons/favicon-16x16.png"" sizes=""16x16"" type=""image/png"">
    <link rel=""manifest"" href=""/docs/4.5/assets/img/favicons/manifest.json"">
    <link rel=""mask-icon"" href=""/docs/4.5/assets/img/favicons/safari-pinned-tab.svg"" color");
                WriteLiteral(@"=""#563d7c"">
    <link rel=""icon"" href=""/docs/4.5/assets/img/favicons/favicon.ico"">
    <meta name=""msapplication-config"" content=""/docs/4.5/assets/img/favicons/browserconfig.xml"">
    <meta name=""theme-color"" content=""#563d7c"">

    <!-- Custom styles for this template -->
    <link href=""jumbotron.css"" rel=""stylesheet"">
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0be67578c667e718693e501bf2e885a860a3f909451", async() => {
                WriteLiteral(@"

    <div id=""redbox"">
        <main role=""main"">

            <!-- Main jumbotron for a primary marketing message or call to action !!!SOURCED FROM CANVAS EXAMPLE!!! -->
            <div class=""jumbotron bg-white"" id=""width1k"">
                <div class=""container"">
                    <h1 class=""display-3"">University of Utah Undergraduate Research Coordinator</h1>
                    <p>Welcome the central hub for finding new research opportunities within the School of Computing.</p>
                    <p>
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0be67578c667e718693e501bf2e885a860a3f9010270", async() => {
                    WriteLiteral("\r\n                            View Opportunities &raquo;\r\n                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </p>
                </div>
            </div>

            <!--Featured Posts. See URC/Controllers/HomeController.cs Index method for more details on what a featured post is.-->
            <h1 id=""featured-post-header"">Featured Posts</h1>
            <div class=""container"" id=""featured-posts"">
                <div class=""row"" id=""featured-row"">
                    <div class=""col-md-4 bg-white"" style=""border: solid #cc0000 5px; border-radius: 10px;"">
                        <img class=""featured-col-img""");
                BeginWriteAttribute("src", " src=", 3564, "", 3624, 1);
#nullable restore
#line 69 "C:\Users\Peter\source\repos\ps4-urc-continued-pf_ps4\URC\Views\Home\Index.cshtml"
WriteAttributeValue("", 3569, Html.DisplayFor(modelItem => Model.ElementAt(0).Image), 3569, 55, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <h4>");
#nullable restore
#line 70 "C:\Users\Peter\source\repos\ps4-urc-continued-pf_ps4\URC\Views\Home\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => Model.ElementAt(0).ProjectName));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n                        <p>");
#nullable restore
#line 71 "C:\Users\Peter\source\repos\ps4-urc-continued-pf_ps4\URC\Views\Home\Index.cshtml"
                      Write(Html.DisplayFor(modelItem => Model.ElementAt(0).ProjectDescription));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                        <p>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0be67578c667e718693e501bf2e885a860a3f9013910", async() => {
                    WriteLiteral("View details &raquo;");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 72 "C:\Users\Peter\source\repos\ps4-urc-continued-pf_ps4\URC\Views\Home\Index.cshtml"
                                                                                                                         WriteLiteral(Model.ElementAt(0).OpportunityID);

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
                WriteLiteral("</p>\r\n                    </div>\r\n                    <div class=\"col-md-4 bg-white\" style=\"border: solid #cc0000 5px; border-radius: 10px;\">\r\n                        <img class=\"featured-col-img\"");
                BeginWriteAttribute("src", " src=", 4212, "", 4272, 1);
#nullable restore
#line 75 "C:\Users\Peter\source\repos\ps4-urc-continued-pf_ps4\URC\Views\Home\Index.cshtml"
WriteAttributeValue("", 4217, Html.DisplayFor(modelItem => Model.ElementAt(1).Image), 4217, 55, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <h4>");
#nullable restore
#line 76 "C:\Users\Peter\source\repos\ps4-urc-continued-pf_ps4\URC\Views\Home\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => Model.ElementAt(1).ProjectName));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n                        <p>");
#nullable restore
#line 77 "C:\Users\Peter\source\repos\ps4-urc-continued-pf_ps4\URC\Views\Home\Index.cshtml"
                      Write(Html.DisplayFor(modelItem => Model.ElementAt(1).ProjectDescription));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                        <p>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0be67578c667e718693e501bf2e885a860a3f9017886", async() => {
                    WriteLiteral("View details &raquo;");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 78 "C:\Users\Peter\source\repos\ps4-urc-continued-pf_ps4\URC\Views\Home\Index.cshtml"
                                                                                                                         WriteLiteral(Model.ElementAt(1).OpportunityID);

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
                WriteLiteral("</p>\r\n                    </div>\r\n                    <div class=\"col-md-4 bg-white\" style=\"border: solid #cc0000 5px; border-radius: 10px;\">\r\n                        <img class=\"featured-col-img\"");
                BeginWriteAttribute("src", " src=", 4860, "", 4920, 1);
#nullable restore
#line 81 "C:\Users\Peter\source\repos\ps4-urc-continued-pf_ps4\URC\Views\Home\Index.cshtml"
WriteAttributeValue("", 4865, Html.DisplayFor(modelItem => Model.ElementAt(2).Image), 4865, 55, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <h4>");
#nullable restore
#line 82 "C:\Users\Peter\source\repos\ps4-urc-continued-pf_ps4\URC\Views\Home\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => Model.ElementAt(2).ProjectName));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n                        <p>");
#nullable restore
#line 83 "C:\Users\Peter\source\repos\ps4-urc-continued-pf_ps4\URC\Views\Home\Index.cshtml"
                      Write(Html.DisplayFor(modelItem => Model.ElementAt(2).ProjectDescription));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                        <p>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0be67578c667e718693e501bf2e885a860a3f9021862", async() => {
                    WriteLiteral("View details &raquo;");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 84 "C:\Users\Peter\source\repos\ps4-urc-continued-pf_ps4\URC\Views\Home\Index.cshtml"
                                                                                                                         WriteLiteral(Model.ElementAt(2).OpportunityID);

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
                WriteLiteral(@"</p>
                    </div>
                </div>

                <hr>

            </div> <!-- /container -->

        </main>


        <script src=""https://code.jquery.com/jquery-3.5.1.slim.min.js"" integrity=""sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj"" crossorigin=""anonymous""></script>
        <script>window.jQuery || document.write('<script src=""/docs/4.5/assets/js/vendor/jquery.slim.min.js""><\/script>')</script>
        <script src=""/docs/4.5/dist/js/bootstrap.bundle.min.js"" integrity=""sha384-LtrjvnR4Twt/qOuYxE721u19sVFLVSA4hf/rRt6PrZTmiPltdZcI7q7PXQBYTKyf"" crossorigin=""anonymous""></script>

    </div>
");
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
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<URC.Models.Opportunity>> Html { get; private set; }
    }
}
#pragma warning restore 1591
