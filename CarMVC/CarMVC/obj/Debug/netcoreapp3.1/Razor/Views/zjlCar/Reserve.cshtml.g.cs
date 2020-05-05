#pragma checksum "C:\Users\o\Source\Repos\CarMVC\CarMVC\CarMVC\Views\zjlCar\Reserve.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "296de34e3ff0f01b677ae332b65270556cb87cc9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_zjlCar_Reserve), @"mvc.1.0.view", @"/Views/zjlCar/Reserve.cshtml")]
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
#line 1 "C:\Users\o\Source\Repos\CarMVC\CarMVC\CarMVC\Views\_ViewImports.cshtml"
using CarMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\o\Source\Repos\CarMVC\CarMVC\CarMVC\Views\_ViewImports.cshtml"
using CarMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"296de34e3ff0f01b677ae332b65270556cb87cc9", @"/Views/zjlCar/Reserve.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20c0780ed8a87b80ef297575bc486aef67988026", @"/Views/_ViewImports.cshtml")]
    public class Views_zjlCar_Reserve : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\o\Source\Repos\CarMVC\CarMVC\CarMVC\Views\zjlCar\Reserve.cshtml"
  
    ViewData["Title"] = "Reserve";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


    <table class="" table table-borderless"">
        <tr>
            <td>
                车辆名字：
            </td>
            <td>
                <span id=""CarName""></span>
            </td>
        </tr>
        <tr>
            <td>
                变速箱：
            </td>
            <td>
                <span id=""AMT""></span>
            </td>
        </tr>
        <tr>
            <td>租车用途：</td>
            <td>
                <input type=""text"" id=""Useing"" placeholder=""请填写租车用途 如：商用、自用..等"" />
            </td>
        </tr>
        <tr>
            <td>取车时间：</td>
            <td>
                <input type=""datetime"" id=""StartTime"" />
            </td>
        </tr>
        <tr>
            <td>还车时间：</td>
            <td>
                <input type=""datetime"" id=""EndTime"" />
            </td>
        </tr>
        <tr>
            <td>是否配用司机：</td>
            <td>
                <input type=""checkbox"" id=""Driver"" />

            </td>
        </tr>
     ");
            WriteLiteral(@"   <tr>
            <td>
                <input type=""button"" onclick=""Reserve()"" class=""btn btn-success"" value=""预定"" />
            </td>
            <td>
                <input type=""button"" onclick=""location.href='SoCar/Show()'"" class=""btn btn-warning"" value=""取消"" />
            </td>
        </tr>
    </table>


    <script>

    $(function(){
        Show();
    });

    function Show() {
          function show() {
            $.ajax({
                url: 'http://localhost:57894/api//' +");
#nullable restore
#line 69 "C:\Users\o\Source\Repos\CarMVC\CarMVC\CarMVC\Views\zjlCar\Reserve.cshtml"
                                                Write(ViewContext.RouteData.Values["id"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@",
                type: 'get',
                dataType: 'json',
                crossDomain: true,
                success: function (d) {
                    $(""#OrdersID"").val(d.OrdersID);
                    $(""#Reson"").val(d.Reson);
                    $(""#Phone"").val(d.Phone);

                }
            });
        }
    }

    function Reserve() {
        var obj = {};

        obj.Oid = ""202004301"";
        obj.uid = 1;
        obj.CarInfoid =  1;


        obj.Useing = $(""#Useing"").val();
        obj.StartTime = $(""#StartTime"").val();
        obj.EndTime = $(""#EndTime"").val();


        obj.Price = (obj.EndTime - obj.StartTime)* 2;   // 单价用来反填获取
        obj.Driver = $(""#Driver"").click() == true ? ""1"" : ""0"";


        $.ajax({
            url: ""http://localhost:57894/api/zjlCar"",
            type: ""POST"",
            data: obj,
            processData: false,
            contentType: false,
            crossDomain: true,

            success: function (d) {
");
            WriteLiteral(@"                alert(""预定成功"");
                location.href = ""SoCar/Show()"";
            },
            error: function (d) {
                alert(""预定失败"");
                location.href = ""SoCar/Show()"";
            }

        })
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
