#pragma checksum "C:\Users\olega\Desktop\WebApplication6\Views\Student\AddNumbers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96ab71356eaffc4417d5b14006cfbb2ae147d3bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_AddNumbers), @"mvc.1.0.view", @"/Views/Student/AddNumbers.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96ab71356eaffc4417d5b14006cfbb2ae147d3bf", @"/Views/Student/AddNumbers.cshtml")]
    public class Views_Student_AddNumbers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication6.Storage.Entity.cal_c>
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
#line 2 "C:\Users\olega\Desktop\WebApplication6\Views\Student\AddNumbers.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "96ab71356eaffc4417d5b14006cfbb2ae147d3bf2938", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>AddStudent</title>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "96ab71356eaffc4417d5b14006cfbb2ae147d3bf4002", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 13 "C:\Users\olega\Desktop\WebApplication6\Views\Student\AddNumbers.cshtml"
     using (Html.BeginForm("Add", "Student", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <label>Имя: </label>\r\n        <input id=\"FirstNumber\" type=\"text\" name=\"FirstNumber\" for=\"FirstNumber\" /><br /><br />\r\n");
                WriteLiteral("        <label>Фамилия: </label>\r\n        <input id=\"SecondNumber\" type=\"text\" name=\"SecondNumber\" for=\"SecondNumber\" /><br /><br />\r\n");
                WriteLiteral("        <label>Староста: </label>\r\n        <input id=\"GroupLeader\" type=\"text\" name=\"GroupLeader\" for=\"GroupLeader\" /><br /><br />\r\n");
                WriteLiteral("        <label>ID Группы: </label>\r\n        <input id=\"GroupID\" type=\"text\" name=\"GroupID\" for=\"GroupID\" /><br /><br />\r\n");
                WriteLiteral("        <label>ID Первого модуля: </label>\r\n        <input id=\"FirstModID\" type=\"text\" name=\"FirstModID\" for=\"FirstModID\" /><br /><br />\r\n");
                WriteLiteral("        <label>ID Второго модуля: </label>\r\n        <input id=\"SecondModID\" type=\"text\" name=\"SecondModID\" for=\"SecondModID\" /><br /><br />\r\n");
                WriteLiteral("        <label>ID Предмета: </label>\r\n        <input id=\"SubjID\" type=\"text\" name=\"SubjID\" for=\"SubjID\" /><br /><br />\r\n");
                WriteLiteral("        <input type=\"submit\" value=\"Добавить нового студента\" />\r\n");
#nullable restore
#line 38 "C:\Users\olega\Desktop\WebApplication6\Views\Student\AddNumbers.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <div>\r\n        ");
#nullable restore
#line 41 "C:\Users\olega\Desktop\WebApplication6\Views\Student\AddNumbers.cshtml"
   Write(Html.ActionLink("Вернуться на страницу вывода студентов", "ShowStudent", "Student"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication6.Storage.Entity.cal_c> Html { get; private set; }
    }
}
#pragma warning restore 1591
