#pragma checksum "C:\Users\speed\Desktop\Coding_Dojo\c_stack\Dojo_Survey\Views\Survey\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42f171ab921cb49be2405ef2a4a0afbdd0e70242"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Survey_Index), @"mvc.1.0.view", @"/Views/Survey/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42f171ab921cb49be2405ef2a4a0afbdd0e70242", @"/Views/Survey/Index.cshtml")]
    public class Views_Survey_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "42f171ab921cb49be2405ef2a4a0afbdd0e702422720", async() => {
                WriteLiteral("\r\n        <meta charset=\'utf-8\'>\r\n        <title>Form Demo</title>\r\n    ");
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
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "42f171ab921cb49be2405ef2a4a0afbdd0e702423766", async() => {
                WriteLiteral("\r\n        <div style = \"margin: 20px; padding: 10px; border: 2px solid black\">\r\n            <form action=\"result\" method=\"post\">\r\n                <label");
                BeginWriteAttribute("for", " for=\"", 278, "\"", 284, 0);
                EndWriteAttribute();
                WriteLiteral(">Your Name:</label>\r\n                <input type=\"text\" name=\"NameInput\"><br>\r\n                <label");
                BeginWriteAttribute("for", " for=\"", 386, "\"", 392, 0);
                EndWriteAttribute();
                WriteLiteral(">Dojo Location:</label>\r\n                <select name=\"DojoInput\"");
                BeginWriteAttribute("id", " id=\"", 458, "\"", 463, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <option value=\"seattle\">Seattle</option>\r\n                    <option value=\"sanFrancisco\">San Francisco</option>\r\n                    <option value=\"austin\">Austin</option>\r\n                </select><br>\r\n                <label");
                BeginWriteAttribute("for", " for=\"", 715, "\"", 721, 0);
                EndWriteAttribute();
                WriteLiteral(">Favorite Language:</label>\r\n                <select name=\"LangInput\"");
                BeginWriteAttribute("id", " id=\"", 791, "\"", 796, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <option value=\"c#\">C#</option>\r\n                    <option value=\"python\">Python</option>\r\n                    <option value=\"react\">React</option>\r\n                </select><br>\r\n                <label");
                BeginWriteAttribute("for", " for=\"", 1023, "\"", 1029, 0);
                EndWriteAttribute();
                WriteLiteral(">Comment (optional):</label><br>\r\n                <textarea name=\"CommentInput\" style = \"width: 350px; height: 75px; padding-top: 0; padding-left: 0;\"></textarea><br>\r\n                <button>Submit</button>\r\n            </form>\r\n        </div>\r\n    ");
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
            WriteLiteral("\r\n</html>");
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