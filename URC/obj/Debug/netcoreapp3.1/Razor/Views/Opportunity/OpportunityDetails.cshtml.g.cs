#pragma checksum "C:\Users\Peter\source\repos\URC\URC\Views\Opportunity\OpportunityDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c970017ce067adb6a3ea5367066637699118e91d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Opportunity_OpportunityDetails), @"mvc.1.0.view", @"/Views/Opportunity/OpportunityDetails.cshtml")]
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
#line 1 "C:\Users\Peter\source\repos\URC\URC\Views\_ViewImports.cshtml"
using URC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Peter\source\repos\URC\URC\Views\_ViewImports.cshtml"
using URC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c970017ce067adb6a3ea5367066637699118e91d", @"/Views/Opportunity/OpportunityDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fcea820b63b567f6937a79c413a93a4819856ae", @"/Views/_ViewImports.cshtml")]
    public class Views_Opportunity_OpportunityDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<URC.Models.Opportunity>
    {
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

    This file contains the HTML code to display the expanded details of a particular research opportunity.
-->

");
            WriteLiteral(@"

<div>
    <table id=""photo-author-title"">
        <!--This table represents the main informational sections of the opportunity,
            inluding the title, author, and the button to apply for the research opportunity-->
        <tr>
            <td id=""photo-col"">
                <img");
            BeginWriteAttribute("src", " src=", 967, "", 1014, 1);
#nullable restore
#line 25 "C:\Users\Peter\source\repos\URC\URC\Views\Opportunity\OpportunityDetails.cshtml"
WriteAttributeValue("", 972, Html.DisplayFor(modelItem => Model.Image), 972, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""center"">
                <input type=""button"" id=""apply-button"" value=""Apply"" onclick=""window.location.href='/Student/Application';""> <!--Not sure if this is the long term solution-->
            </td>
            <td id=""author-title-col"">
                <table id=""author-title"">
                    <tr>
                        <td>
                            <h1>
                                ");
#nullable restore
#line 33 "C:\Users\Peter\source\repos\URC\URC\Views\Opportunity\OpportunityDetails.cshtml"
                           Write(Html.DisplayFor(modelItem => Model.ProjectName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </h1>\r\n                        </td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>\r\n                            Professor: ");
#nullable restore
#line 39 "C:\Users\Peter\source\repos\URC\URC\Views\Opportunity\OpportunityDetails.cshtml"
                                  Write(Html.DisplayFor(modelItem => Model.ProfessorName));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</div>

<!--The redbox div makes the red margins on each side of the page-->
<div id=""red-box"">
    <div id=""description"">
        <div id=""general-summary"">
            <h2 class=""section-head"">
                General Summary
            </h2>
            <!--The expanded summary of the opportunity.-->
            <p id=""summary-body"">
                ");
#nullable restore
#line 57 "C:\Users\Peter\source\repos\URC\URC\Views\Opportunity\OpportunityDetails.cshtml"
           Write(Html.DisplayFor(modelItem => Model.ProjectDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </p>
        </div>
        <div id=""requirements"">
            <h2 class=""section-head"">
                Desired Skills
            </h2>
            <!--The skillset items that the researcher is looking for in a research assistant-->
");
#nullable restore
#line 65 "C:\Users\Peter\source\repos\URC\URC\Views\Opportunity\OpportunityDetails.cshtml"
             for (var i = 0; i < Model.RequiredSkills.Count - 1; i++)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "C:\Users\Peter\source\repos\URC\URC\Views\Opportunity\OpportunityDetails.cshtml"
           Write(Html.DisplayFor(moduleItem => Model.RequiredSkills.ElementAt(i).Skill));

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 67 "C:\Users\Peter\source\repos\URC\URC\Views\Opportunity\OpportunityDetails.cshtml"
                                                                                                      
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "C:\Users\Peter\source\repos\URC\URC\Views\Opportunity\OpportunityDetails.cshtml"
             if (Model.RequiredSkills.Count > 0)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "C:\Users\Peter\source\repos\URC\URC\Views\Opportunity\OpportunityDetails.cshtml"
           Write(Html.DisplayFor(moduleItem => Model.RequiredSkills.ElementAt(Model.RequiredSkills.Count - 1).Skill));

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "C:\Users\Peter\source\repos\URC\URC\Views\Opportunity\OpportunityDetails.cshtml"
                                                                                                                    
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <br>\r\n        <br>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<URC.Models.Opportunity> Html { get; private set; }
    }
}
#pragma warning restore 1591
