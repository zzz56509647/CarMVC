#pragma checksum "L:\实训一\百车汇汽车租赁系统啊mvc\CarMVC\CarMVC\Views\YcxCar\GetCars.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13e65902fb82ca89498c8bdf7c0e15663e6f4cf7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_YcxCar_GetCars), @"mvc.1.0.view", @"/Views/YcxCar/GetCars.cshtml")]
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
#line 1 "L:\实训一\百车汇汽车租赁系统啊mvc\CarMVC\CarMVC\Views\_ViewImports.cshtml"
using CarMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "L:\实训一\百车汇汽车租赁系统啊mvc\CarMVC\CarMVC\Views\_ViewImports.cshtml"
using CarMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13e65902fb82ca89498c8bdf7c0e15663e6f4cf7", @"/Views/YcxCar/GetCars.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20c0780ed8a87b80ef297575bc486aef67988026", @"/Views/_ViewImports.cshtml")]
    public class Views_YcxCar_GetCars : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 2 "L:\实训一\百车汇汽车租赁系统啊mvc\CarMVC\CarMVC\Views\YcxCar\GetCars.cshtml"
  
    ViewData["Title"] = "GetCars";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <link href=""D:\A_Githup\thisOnline\CarMvc_\CarMVC\CarMVC\CssAndJs\ClassView\bootstrap.css"" rel=""stylesheet"" />
<h1>GetCars</h1>
<div >
    <div class=""row"">
        <div class=""col-md-3"">
            <label>
                汽车名字
            </label>
            <input type=""text"" id=""takeKeyword""");
            BeginWriteAttribute("value", " value=\"", 354, "\"", 362, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </div>\r\n        <div class=\"col-md-3\">\r\n            <label>\r\n                汽车类型\r\n            </label>\r\n            <select id=\"TypeCar\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13e65902fb82ca89498c8bdf7c0e15663e6f4cf74170", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13e65902fb82ca89498c8bdf7c0e15663e6f4cf75540", async() => {
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
   
    <table class=""table table-danger"">
        <tr>
            <td>编号</td>
            <td>图片</td>
            <td>汽车名字</td>
            <td>汽车年份</td>
            <td>汽车排量</td>
            <td>个数</td>
            <td>手动/自动</td>
            <td>价格/日</td>
            <td>地址</td>
            <td>操作</td>
        </tr>
        <tbody id=""CaseBody"">


        </tbody>

    </table>
    
    

    <script src=""D:\A_Githup\thisOnline\CarMvc_\CarMVC\CarMVC\CssAndJs\Ajax\jquery-1.10.2.js""></script>
</div>

<script>
    $(GetCars);
    function GetCars() {
        $.ajax({
            url: 'http://localhost:57894/api/Get',
            type: 'get',
            dataType:");
            WriteLiteral(@" 'json',
            success: function (data) {
                $(data).each(
                    function () {
                        var GetCarOperation = ' <tr>< td >' + this.CarInfoID + '</td> <td>' + this.Image + '</td> <td>' + this.CarName + '</td> <td>' + this.Years + '</td><td>' + this.CC + '</td><td>' + this.Count + '</td><td>' + this.AMT + '</td><td>' + this.Price + '</td><td>' + this.Address + '</td>                           < td >' +");
#nullable restore
#line 77 "L:\实训一\百车汇汽车租赁系统啊mvc\CarMVC\CarMVC\Views\YcxCar\GetCars.cshtml"
                                                                                                                                                                                                                                                                                                                                              Write(Html.ActionLink("详细信息","","",new { }));

#line default
#line hidden
#nullable disable
            WriteLiteral("+\'\'+");
#nullable restore
#line 77 "L:\实训一\百车汇汽车租赁系统啊mvc\CarMVC\CarMVC\Views\YcxCar\GetCars.cshtml"
                                                                                                                                                                                                                                                                                                                                                                                        Write(Html.ActionLink("删除","","",new { }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"+'</td ></tr > '
                        $(""#CaseBody"").append(GetCarOperation);

                    }
                );
            }


        });
    }



    function SelectGetCars(keyword) {       
        keyword = $(""#takeKeyword"").val();
        $.ajax({
            url: 'http://localhost:57894/api/zjlCar/get?Name='+keyword,
            type: 'post',
            data: {
                keyword: $(""#takeKeyword"").val(),

            },
            dataType: 'json',
            success: function (data) {
                $(data).each(
                    function () {
                        var GetCarOperation = ' <tr>< td >' + this.CarInfoID + '</td> <td>' + this.Image + '</td> <td>' + this.CarName + '</td> <td>' + this.Years + '</td><td>' + this.CC + '</td><td>' + this.Count + '</td><td>' + this.AMT + '</td><td>' + this.Price + '</td><td>' + this.Address + '</td>                           < td >' +");
#nullable restore
#line 103 "L:\实训一\百车汇汽车租赁系统啊mvc\CarMVC\CarMVC\Views\YcxCar\GetCars.cshtml"
                                                                                                                                                                                                                                                                                                                                              Write(Html.ActionLink("详细信息","","",new { }));

#line default
#line hidden
#nullable disable
            WriteLiteral("+\'\'+");
#nullable restore
#line 103 "L:\实训一\百车汇汽车租赁系统啊mvc\CarMVC\CarMVC\Views\YcxCar\GetCars.cshtml"
                                                                                                                                                                                                                                                                                                                                                                                        Write(Html.ActionLink("删除","","",new { }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"+'</td ></tr > '
                        $(""#CaseBody"").append(GetCarOperation);

                    }
                );
            }


        });
    }

    function Clear() {
        location.href=""/YcxCar/GetCars""
        
    }




</script>



");
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
