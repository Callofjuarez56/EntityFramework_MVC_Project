#pragma checksum "C:\Users\olega\Desktop\WebApplication6\Views\Group\ShowGroups.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8db5b0ab97dccffabef1bfcd38f35df012deadd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Group_ShowGroups), @"mvc.1.0.view", @"/Views/Group/ShowGroups.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8db5b0ab97dccffabef1bfcd38f35df012deadd", @"/Views/Group/ShowGroups.cshtml")]
    public class Views_Group_ShowGroups : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApplication6.Storage.Entity.Group>>
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\olega\Desktop\WebApplication6\Views\Group\ShowGroups.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8db5b0ab97dccffabef1bfcd38f35df012deadd2974", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>ShowGroups</title>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8db5b0ab97dccffabef1bfcd38f35df012deadd4038", async() => {
                WriteLiteral("\r\n    <div>\r\n        <h1>Группы</h1>\r\n");
#nullable restore
#line 16 "C:\Users\olega\Desktop\WebApplication6\Views\Group\ShowGroups.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <label>ID: </label>");
#nullable restore
#line 18 "C:\Users\olega\Desktop\WebApplication6\Views\Group\ShowGroups.cshtml"
                          Write(item.id);

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n            <label>Номер группы: </label>");
#nullable restore
#line 19 "C:\Users\olega\Desktop\WebApplication6\Views\Group\ShowGroups.cshtml"
                                    Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n            <label>Направление: </label>");
#nullable restore
#line 20 "C:\Users\olega\Desktop\WebApplication6\Views\Group\ShowGroups.cshtml"
                                   Write(item.DepartmentNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n            <a");
                BeginWriteAttribute("href", " href=\"", 504, "\"", 538, 2);
                WriteAttributeValue("", 511, "/Group/UpdateGroup/", 511, 19, true);
#nullable restore
#line 21 "C:\Users\olega\Desktop\WebApplication6\Views\Group\ShowGroups.cshtml"
WriteAttributeValue("", 530, item.id, 530, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Редактировать группу</a><br /><br />");
#nullable restore
#line 21 "C:\Users\olega\Desktop\WebApplication6\Views\Group\ShowGroups.cshtml"
                                                                                      // контроллер -> метод -> передаем Idшник
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 25 "C:\Users\olega\Desktop\WebApplication6\Views\Group\ShowGroups.cshtml"
         using (Html.BeginForm("AddGroup", "Group"))
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div>\r\n                <input type=\"submit\" value=\"Добавить новую группу\" />\r\n            </div>\r\n");
#nullable restore
#line 30 "C:\Users\olega\Desktop\WebApplication6\Views\Group\ShowGroups.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <p></p>\r\n\r\n");
#nullable restore
#line 34 "C:\Users\olega\Desktop\WebApplication6\Views\Group\ShowGroups.cshtml"
         using (Html.BeginForm("HomePage", "Group"))
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div>\r\n                <input type=\"submit\" value=\"Вернуться\" />\r\n            </div>\r\n");
#nullable restore
#line 39 "C:\Users\olega\Desktop\WebApplication6\Views\Group\ShowGroups.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApplication6.Storage.Entity.Group>> Html { get; private set; }
    }
}
#pragma warning restore 1591
