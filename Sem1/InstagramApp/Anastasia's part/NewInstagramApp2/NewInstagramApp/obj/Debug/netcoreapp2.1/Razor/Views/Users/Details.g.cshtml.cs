#pragma checksum "C:\Users\asyag\Desktop\Instagram\NewInstagramApp2\NewInstagramApp\Views\Users\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e79a73c3d96852ec4ee07c64f43438a5ebe1763"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Details), @"mvc.1.0.view", @"/Views/Users/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Users/Details.cshtml", typeof(AspNetCore.Views_Users_Details))]
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
#line 1 "C:\Users\asyag\Desktop\Instagram\NewInstagramApp2\NewInstagramApp\Views\_ViewImports.cshtml"
using NewInstagramApp;

#line default
#line hidden
#line 2 "C:\Users\asyag\Desktop\Instagram\NewInstagramApp2\NewInstagramApp\Views\_ViewImports.cshtml"
using NewInstagramApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e79a73c3d96852ec4ee07c64f43438a5ebe1763", @"/Views/Users/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e4d68c9abab2bf8169f9a6ccb8febda4fd46530", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NewInstagramApp.Models.User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(36, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\asyag\Desktop\Instagram\NewInstagramApp2\NewInstagramApp\Views\Users\Details.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(65, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(94, 102, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73aea3ac6b444897a12e3f891fbd48ee", async() => {
                BeginContext(100, 89, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Details</title>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(196, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(198, 913, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f89bf4978878496c93b0530e5f030fa4", async() => {
                BeginContext(204, 100, true);
                WriteLiteral("\r\n\r\n<div>\r\n    <h4>User</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(305, 44, false);
#line 21 "C:\Users\asyag\Desktop\Instagram\NewInstagramApp2\NewInstagramApp\Views\Users\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
                EndContext();
                BeginContext(349, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(393, 40, false);
#line 24 "C:\Users\asyag\Desktop\Instagram\NewInstagramApp2\NewInstagramApp\Views\Users\Details.cshtml"
       Write(Html.DisplayFor(model => model.UserName));

#line default
#line hidden
                EndContext();
                BeginContext(433, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(477, 45, false);
#line 27 "C:\Users\asyag\Desktop\Instagram\NewInstagramApp2\NewInstagramApp\Views\Users\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
                EndContext();
                BeginContext(522, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(566, 41, false);
#line 30 "C:\Users\asyag\Desktop\Instagram\NewInstagramApp2\NewInstagramApp\Views\Users\Details.cshtml"
       Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
                EndContext();
                BeginContext(607, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(651, 44, false);
#line 33 "C:\Users\asyag\Desktop\Instagram\NewInstagramApp2\NewInstagramApp\Views\Users\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Password));

#line default
#line hidden
                EndContext();
                BeginContext(695, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(739, 40, false);
#line 36 "C:\Users\asyag\Desktop\Instagram\NewInstagramApp2\NewInstagramApp\Views\Users\Details.cshtml"
       Write(Html.DisplayFor(model => model.Password));

#line default
#line hidden
                EndContext();
                BeginContext(779, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(823, 42, false);
#line 39 "C:\Users\asyag\Desktop\Instagram\NewInstagramApp2\NewInstagramApp\Views\Users\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
                EndContext();
                BeginContext(865, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(909, 38, false);
#line 42 "C:\Users\asyag\Desktop\Instagram\NewInstagramApp2\NewInstagramApp\Views\Users\Details.cshtml"
       Write(Html.DisplayFor(model => model.Status));

#line default
#line hidden
                EndContext();
                BeginContext(947, 47, true);
                WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
                EndContext();
                BeginContext(994, 54, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "741b3bf187484f879ed4c25f97966e30", async() => {
                    BeginContext(1040, 4, true);
                    WriteLiteral("Edit");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 47 "C:\Users\asyag\Desktop\Instagram\NewInstagramApp2\NewInstagramApp\Views\Users\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
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
                EndContext();
                BeginContext(1048, 8, true);
                WriteLiteral(" |\r\n    ");
                EndContext();
                BeginContext(1056, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb567c9468b04a74b19326f0eec89eeb", async() => {
                    BeginContext(1078, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1094, 10, true);
                WriteLiteral("\r\n</div>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(1111, 11, true);
            WriteLiteral("\r\n</html>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NewInstagramApp.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
