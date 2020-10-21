#pragma checksum "C:\Users\Peter\source\repos\ps-6---student-application-halfpast12\URC\Views\Student\Application.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70c54b3fdead708b1752105e66b99505a614c8d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Application), @"mvc.1.0.view", @"/Views/Student/Application.cshtml")]
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
#line 1 "C:\Users\Peter\source\repos\ps-6---student-application-halfpast12\URC\Views\_ViewImports.cshtml"
using URC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Peter\source\repos\ps-6---student-application-halfpast12\URC\Views\_ViewImports.cshtml"
using URC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70c54b3fdead708b1752105e66b99505a614c8d8", @"/Views/Student/Application.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fcea820b63b567f6937a79c413a93a4819856ae", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Application : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!--
  Author:    Peter Forsling
  Partner:   Noah Jackson
  Date:      14 September 2020
  Course:    CS 4540, University of Utah, School of Computing
  Copyright: CS 4540 and Peter Forsling/Noah Jackson - This work may not be copied for use in Academic Coursework.

  I, Peter Forsling/Noah Jackson, certify that I wrote this code from scratch and did not copy it in part or whole from
  another source.  Any references used in the completion of the assignment are cited in my README file.

  File Contents

    This file contains the HTML code to display the application page.
-->

<div id=""redbox-application"">
    <div class=""bg-white"" id=""white-banner-application"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70c54b3fdead708b1752105e66b99505a614c8d83990", async() => {
                WriteLiteral(@"
            <div class=""form-group form-margin"">
                <label for=""FirstNameInput"">First Name</label>
                <input type=""text"" class=""form-control"" id=""formGroupExampleInput"" placeholder=""First Name"">
            </div>
            <div class=""form-group form-margin"">
                <label for=""LastNameInput"">Last Name</label>
                <input type=""text"" class=""form-control"" id=""formGroupExampleInput2"" placeholder=""Last Name"">
            </div>
            <div class=""form-group form-margin"">
                <label for=""EmailInput"">Email</label>
                <input type=""email"" class=""form-control"" id=""formGroupExampleInput"" placeholder=""someone@example.com"">
            </div>
            <div class=""form-group form-margin"">
                <label for=""PhoneInput"">Phone Number</label>
                <input type=""text"" class=""form-control"" id=""formGroupExampleInput2"" placeholder=""XXX-XXX-XXXX""> <!--Cannot find an input type for phone number format. Maybe Javasc");
                WriteLiteral(@"ript will fix this?-->
            </div>
            <div class=""form-group form-margin"">
                <label for=""ResumeFileInput"">Resume</label>
                <input type=""file"" class=""form-control-file"" id=""resumeFileInput"" accept=""application/pdf"">
            </div>
            <div class=""form-group form-margin"">
                <label for=""CoverLetterInput"">Cover Letter (optional)</label>
                <textarea class=""form-control"" id=""exampleFormControlTextarea1"" rows=""5""></textarea>
            </div>
            <button type=""submit"" id=""submit-button"" class=""btn btn-primary form-margin"">Submit Application</button>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    </div>\r\n</div>");
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
