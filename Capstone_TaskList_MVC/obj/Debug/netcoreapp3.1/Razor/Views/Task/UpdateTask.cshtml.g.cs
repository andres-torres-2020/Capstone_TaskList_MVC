#pragma checksum "C:\Users\andy\Documents\_MY\MyDocuments\MyCode\GRAND CIRCUS\andres_torres\repos\Capstone_TaskList_MVC\Capstone_TaskList_MVC\Views\Task\UpdateTask.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58196c205337d5700d9151292cd341d75ba17cf9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Task_UpdateTask), @"mvc.1.0.view", @"/Views/Task/UpdateTask.cshtml")]
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
#line 1 "C:\Users\andy\Documents\_MY\MyDocuments\MyCode\GRAND CIRCUS\andres_torres\repos\Capstone_TaskList_MVC\Capstone_TaskList_MVC\Views\_ViewImports.cshtml"
using Capstone_TaskList_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\andy\Documents\_MY\MyDocuments\MyCode\GRAND CIRCUS\andres_torres\repos\Capstone_TaskList_MVC\Capstone_TaskList_MVC\Views\_ViewImports.cshtml"
using Capstone_TaskList_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58196c205337d5700d9151292cd341d75ba17cf9", @"/Views/Task/UpdateTask.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3b232df9a78eb15ace3019b251352e3a245daf1", @"/Views/_ViewImports.cshtml")]
    public class Views_Task_UpdateTask : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Capstone_TaskList_MVC.Models.Task>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Task/UpdateTask"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h2>Update Task</h2>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58196c205337d5700d9151292cd341d75ba17cf94562", async() => {
                WriteLiteral("\r\n        <input type=\"hidden\" name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 178, "\"", 195, 1);
#nullable restore
#line 7 "C:\Users\andy\Documents\_MY\MyDocuments\MyCode\GRAND CIRCUS\andres_torres\repos\Capstone_TaskList_MVC\Capstone_TaskList_MVC\Views\Task\UpdateTask.cshtml"
WriteAttributeValue("", 186, Model.Id, 186, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <input type=\"text\" name=\"TaskDescription\"");
                BeginWriteAttribute("value", " value=\"", 250, "\"", 280, 1);
#nullable restore
#line 8 "C:\Users\andy\Documents\_MY\MyDocuments\MyCode\GRAND CIRCUS\andres_torres\repos\Capstone_TaskList_MVC\Capstone_TaskList_MVC\Views\Task\UpdateTask.cshtml"
WriteAttributeValue("", 258, Model.TaskDescription, 258, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /><br />\r\n        <input type=\"date\" name=\"DueDate\"");
                BeginWriteAttribute("value", " value=\"", 333, "\"", 378, 1);
#nullable restore
#line 9 "C:\Users\andy\Documents\_MY\MyDocuments\MyCode\GRAND CIRCUS\andres_torres\repos\Capstone_TaskList_MVC\Capstone_TaskList_MVC\Views\Task\UpdateTask.cshtml"
WriteAttributeValue("", 341, Model.DueDate.ToString("yyyy-MM-dd"), 341, 37, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /><br />\r\n        <p>\r\n            Completed :\r\n");
#nullable restore
#line 12 "C:\Users\andy\Documents\_MY\MyDocuments\MyCode\GRAND CIRCUS\andres_torres\repos\Capstone_TaskList_MVC\Capstone_TaskList_MVC\Views\Task\UpdateTask.cshtml"
               
                string checkedCompleted = Model.CompletedStatus ? "checked" : "";
                string checkedIncomplete = Model.CompletedStatus == false ? "checked" : "";
            

#line default
#line hidden
#nullable disable
                WriteLiteral("            <label>Yes <input type=\"radio\" name=\"CompletedStatus\" value=\"true\" ");
#nullable restore
#line 16 "C:\Users\andy\Documents\_MY\MyDocuments\MyCode\GRAND CIRCUS\andres_torres\repos\Capstone_TaskList_MVC\Capstone_TaskList_MVC\Views\Task\UpdateTask.cshtml"
                                                                          Write(checkedCompleted);

#line default
#line hidden
#nullable disable
                WriteLiteral(" /></label>\r\n            <label>No <input type=\"radio\" name=\"CompletedStatus\" value=\"false\" ");
#nullable restore
#line 17 "C:\Users\andy\Documents\_MY\MyDocuments\MyCode\GRAND CIRCUS\andres_torres\repos\Capstone_TaskList_MVC\Capstone_TaskList_MVC\Views\Task\UpdateTask.cshtml"
                                                                          Write(checkedIncomplete);

#line default
#line hidden
#nullable disable
                WriteLiteral(" /></label>\r\n        </p>\r\n        <input type=\"submit\" value=\"Update Task\" />\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Capstone_TaskList_MVC.Models.Task> Html { get; private set; }
    }
}
#pragma warning restore 1591
