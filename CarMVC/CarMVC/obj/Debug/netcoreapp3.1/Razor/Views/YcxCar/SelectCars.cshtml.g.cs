#pragma checksum "D:\A_Githup\thisOnline\CarMvc_\CarMVC\CarMVC\Views\YcxCar\SelectCars.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "832099cbe3afd08699a80b63b4633a0b83165803"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_YcxCar_SelectCars), @"mvc.1.0.view", @"/Views/YcxCar/SelectCars.cshtml")]
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
#line 1 "D:\A_Githup\thisOnline\CarMvc_\CarMVC\CarMVC\Views\_ViewImports.cshtml"
using CarMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\A_Githup\thisOnline\CarMvc_\CarMVC\CarMVC\Views\_ViewImports.cshtml"
using CarMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"832099cbe3afd08699a80b63b4633a0b83165803", @"/Views/YcxCar/SelectCars.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e7004a7c9a63a2ea2d34940dc9a962f7bc52123", @"/Views/_ViewImports.cshtml")]
    public class Views_YcxCar_SelectCars : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CarMVC.Models.AllCarThis>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\A_Githup\thisOnline\CarMvc_\CarMVC\CarMVC\Views\YcxCar\SelectCars.cshtml"
  
    ViewData["Title"] = "SelectCars";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
<link href=""D:\A_Githup\thisOnline\CarMvc_\CarMVC\CarMVC\CssAndJs\ClassView\bootstrap.css"" rel=""stylesheet"" />
<h1>GetCars</h1>
<div>
    <div class=""row"">
        <div class=""col-md-3"">
            <label>
                汽车名字
            </label>
            <input type=""text"" id=""takeKeyword""");
            BeginWriteAttribute("value", " value=\"", 402, "\"", 410, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </div>\r\n        <div class=\"col-md-3\">\r\n            <label>\r\n                汽车类型\r\n            </label>\r\n            <select id=\"TypeCar\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "832099cbe3afd08699a80b63b4633a0b831658034293", async() => {
                WriteLiteral("--请选择--");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n            </select>\r\n        </div>\r\n        <div class=\"col-md-3\">\r\n            <label>\r\n                汽车品牌\r\n            </label>\r\n            <select id=\"CarBrand\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "832099cbe3afd08699a80b63b4633a0b831658035663", async() => {
                WriteLiteral("--请选择--");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

            </select>
        </div>
        <div class=""col-md-2"">

            <input type=""button"" name=""name"" value=""查询"" onclick=""SelectGetCars(keyword)"" />
        </div>
        <div>
            <input type=""button"" name=""name"" value=""清空选项"" onclick=""Clear()"" />
        </div>
    </div>

    <table class=""table tab-content"">
        <thead>
            <tr>
                <th>
                    编号
                </th>
                <th>
                    图片
                </th>
                <th>
                    汽车名字
                </th>
                <th>
                    汽车年份
                </th>
                <th>
                    汽车排量
                </th>
                <th>
                    个数
                </th>
                <th>
                    手动/自动
                </th>
                <th>
                    价格/日
                </th>
                <th>
                    地址
                </th>

     ");
            WriteLiteral("           <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 80 "D:\A_Githup\thisOnline\CarMvc_\CarMVC\CarMVC\Views\YcxCar\SelectCars.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 84 "D:\A_Githup\thisOnline\CarMvc_\CarMVC\CarMVC\Views\YcxCar\SelectCars.cshtml"
                   Write(Html.DisplayFor(modelItem => item.CarInfoID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 87 "D:\A_Githup\thisOnline\CarMvc_\CarMVC\CarMVC\Views\YcxCar\SelectCars.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 90 "D:\A_Githup\thisOnline\CarMvc_\CarMVC\CarMVC\Views\YcxCar\SelectCars.cshtml"
                   Write(Html.DisplayFor(modelItem => item.CarName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 93 "D:\A_Githup\thisOnline\CarMvc_\CarMVC\CarMVC\Views\YcxCar\SelectCars.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Years));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n\r\n                    <td>\r\n                        ");
#nullable restore
#line 97 "D:\A_Githup\thisOnline\CarMvc_\CarMVC\CarMVC\Views\YcxCar\SelectCars.cshtml"
                   Write(Html.DisplayFor(modelItem => item.CC));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 100 "D:\A_Githup\thisOnline\CarMvc_\CarMVC\CarMVC\Views\YcxCar\SelectCars.cshtml"
                   Write(Html.DisplayFor(modelItem => item.AMT));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 103 "D:\A_Githup\thisOnline\CarMvc_\CarMVC\CarMVC\Views\YcxCar\SelectCars.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 106 "D:\A_Githup\thisOnline\CarMvc_\CarMVC\CarMVC\Views\YcxCar\SelectCars.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 109 "D:\A_Githup\thisOnline\CarMvc_\CarMVC\CarMVC\Views\YcxCar\SelectCars.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Count));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 114 "D:\A_Githup\thisOnline\CarMvc_\CarMVC\CarMVC\Views\YcxCar\SelectCars.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n\r\n\r\n\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CarMVC.Models.AllCarThis>> Html { get; private set; }
    }
}
#pragma warning restore 1591
