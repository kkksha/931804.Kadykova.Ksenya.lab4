#pragma checksum "C:\Users\Ksusha K\source\repos\LAB4\LAB4\Views\Mockups\SignUpPrt2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97d85c4a574baa2650862ee9e45cfa6db8300310"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Mockups_SignUpPrt2), @"mvc.1.0.view", @"/Views/Mockups/SignUpPrt2.cshtml")]
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
#line 1 "C:\Users\Ksusha K\source\repos\LAB4\LAB4\Views\_ViewImports.cshtml"
using LAB4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ksusha K\source\repos\LAB4\LAB4\Views\_ViewImports.cshtml"
using LAB4.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97d85c4a574baa2650862ee9e45cfa6db8300310", @"/Views/Mockups/SignUpPrt2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"022b06c5c068c163495c2a307508f7b6c1f5a8ef", @"/Views/_ViewImports.cshtml")]
    public class Views_Mockups_SignUpPrt2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Data>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Ksusha K\source\repos\LAB4\LAB4\Views\Mockups\SignUpPrt2.cshtml"
  
    ViewData["Title"] = "SignUp";


#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"text-left\">\n    <h1 style=\"font-size:35px; color:#333333\">Sign Up</h1>\n</div>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97d85c4a574baa2650862ee9e45cfa6db83003103776", async() => {
                WriteLiteral("\n    <b>Email </b><br>\n    <div style=\"margin-top:10px\">");
#nullable restore
#line 11 "C:\Users\Ksusha K\source\repos\LAB4\LAB4\Views\Mockups\SignUpPrt2.cshtml"
                            Write(Html.EditorFor(p => p.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 11 "C:\Users\Ksusha K\source\repos\LAB4\LAB4\Views\Mockups\SignUpPrt2.cshtml"
                                                          Write(Html.ValidationMessageFor(p => p.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div><br>\n    <b style=\"margin-top:10px\">Password </b><br>\n    <div style=\"margin-top:10px\"> ");
#nullable restore
#line 13 "C:\Users\Ksusha K\source\repos\LAB4\LAB4\Views\Mockups\SignUpPrt2.cshtml"
                             Write(Html.PasswordFor(p => p.Password));

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 13 "C:\Users\Ksusha K\source\repos\LAB4\LAB4\Views\Mockups\SignUpPrt2.cshtml"
                                                                Write(Html.ValidationMessageFor(p => p.Password));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div><br>\n    <b style=\"margin-top:10px\">Comfirm password </b><br>\n    <div style=\"margin-top:10px\"> ");
#nullable restore
#line 15 "C:\Users\Ksusha K\source\repos\LAB4\LAB4\Views\Mockups\SignUpPrt2.cshtml"
                             Write(Html.PasswordFor(p => p.ComparePassword));

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 15 "C:\Users\Ksusha K\source\repos\LAB4\LAB4\Views\Mockups\SignUpPrt2.cshtml"
                                                                       Write(Html.ValidationMessageFor(p => p.ComparePassword));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div><br>\n    <input type=\"checkbox\" name=\"Remember\" value=\"true\" /><label> Remember?</label><br />\n    <input type=\"submit\" value=\"Continue Sign Up\" class=\"btn btn-primary mt-3 pr-3 pl-3\">\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Data> Html { get; private set; }
    }
}
#pragma warning restore 1591
