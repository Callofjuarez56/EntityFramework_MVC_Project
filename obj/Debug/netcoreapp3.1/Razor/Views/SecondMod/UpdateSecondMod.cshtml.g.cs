#pragma checksum "C:\Users\olega\Desktop\WebApplication6\Views\SecondMod\UpdateSecondMod.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d60601b249a2292eb85ba99581e43de60e397ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SecondMod_UpdateSecondMod), @"mvc.1.0.view", @"/Views/SecondMod/UpdateSecondMod.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d60601b249a2292eb85ba99581e43de60e397ec", @"/Views/SecondMod/UpdateSecondMod.cshtml")]
    public class Views_SecondMod_UpdateSecondMod : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication6.Storage.Entity.SecondM>
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
#line 3 "C:\Users\olega\Desktop\WebApplication6\Views\SecondMod\UpdateSecondMod.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d60601b249a2292eb85ba99581e43de60e397ec3017", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>UpdateSecondMod</title>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d60601b249a2292eb85ba99581e43de60e397ec4086", async() => {
                WriteLiteral("\r\n    <div>\r\n");
#nullable restore
#line 15 "C:\Users\olega\Desktop\WebApplication6\Views\SecondMod\UpdateSecondMod.cshtml"
         using (Html.BeginForm("Update", "SecondMod", FormMethod.Post)) // все элементы будт переданы скрытым образом в результирующий набор нашей формы
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <input id=\"id\" name=\"id\" type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 449, "\"", 466, 1);
#nullable restore
#line 17 "C:\Users\olega\Desktop\WebApplication6\Views\SecondMod\UpdateSecondMod.cshtml"
WriteAttributeValue("", 457, Model.id, 457, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
                WriteLiteral("            <label>Оценка: </label>\r\n            <input id=\"SecondMd\" type=\"text\" name=\"SecondMd\"");
                BeginWriteAttribute("value", " value=\"", 571, "\"", 594, 1);
#nullable restore
#line 20 "C:\Users\olega\Desktop\WebApplication6\Views\SecondMod\UpdateSecondMod.cshtml"
WriteAttributeValue("", 579, Model.SecondMd, 579, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /><br /><br />\r\n            <input type=\"submit\" value=\"Редактировать модуль\" />\r\n");
#nullable restore
#line 22 "C:\Users\olega\Desktop\WebApplication6\Views\SecondMod\UpdateSecondMod.cshtml"


        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 26 "C:\Users\olega\Desktop\WebApplication6\Views\SecondMod\UpdateSecondMod.cshtml"
         using (Html.BeginForm("DeleteSecondMod", "SecondMod", FormMethod.Get))
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <input id=\"id\" name=\"id\" type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 837, "\"", 854, 1);
#nullable restore
#line 28 "C:\Users\olega\Desktop\WebApplication6\Views\SecondMod\UpdateSecondMod.cshtml"
WriteAttributeValue("", 845, Model.id, 845, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n            <input type=\"submit\" value=\"удалить модуль\" />\r\n");
#nullable restore
#line 30 "C:\Users\olega\Desktop\WebApplication6\Views\SecondMod\UpdateSecondMod.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n        <div>\r\n            ");
#nullable restore
#line 34 "C:\Users\olega\Desktop\WebApplication6\Views\SecondMod\UpdateSecondMod.cshtml"
       Write(Html.ActionLink("Вернуться на страницу ввода Модулей", "ShowSecondMod", "SecondMod"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication6.Storage.Entity.SecondM> Html { get; private set; }
    }
}
#pragma warning restore 1591