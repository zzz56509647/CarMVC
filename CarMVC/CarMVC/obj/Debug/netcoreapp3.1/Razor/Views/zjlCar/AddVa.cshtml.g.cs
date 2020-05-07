#pragma checksum "L:\实训一\百车汇汽车租赁系统mvc\CarMVC\CarMVC\Views\zjlCar\AddVa.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ceba123f2556065c345f75f2b90b7a2ed330010"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_zjlCar_AddVa), @"mvc.1.0.view", @"/Views/zjlCar/AddVa.cshtml")]
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
#line 1 "L:\实训一\百车汇汽车租赁系统mvc\CarMVC\CarMVC\Views\_ViewImports.cshtml"
using CarMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "L:\实训一\百车汇汽车租赁系统mvc\CarMVC\CarMVC\Views\_ViewImports.cshtml"
using CarMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ceba123f2556065c345f75f2b90b7a2ed330010", @"/Views/zjlCar/AddVa.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e7004a7c9a63a2ea2d34940dc9a962f7bc52123", @"/Views/_ViewImports.cshtml")]
    public class Views_zjlCar_AddVa : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "L:\实训一\百车汇汽车租赁系统mvc\CarMVC\CarMVC\Views\zjlCar\AddVa.cshtml"
  
    ViewData["Title"] = "AddVa";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>个人车辆挂靠</h1>

<table>
    <tr>
        <td>汽车品牌：</td>
        <td>
            <select id=""bid"">
            </select>
        </td>
    </tr>
    <tr>
        <td>汽车名字：</td>
        <td>
            <input type=""text"" id=""CarName"" placeholder=""请输入汽车型号"" />
        </td>
    </tr>
    <tr>
        <td>汽车年份：</td>
        <td>
            <input type=""text"" id=""Years"" placeholder=""请输入年份"" />
        </td>
    </tr>
    <tr>
        <td>汽车类型：</td>
        <td>
            <select id=""cid""></select>
        </td>
    </tr>
    <tr>
        <td>汽车排量：</td>
        <td>
            <input type=""text"" id=""CC"" placeholder=""请输入排量"" />
        </td>
    </tr>
    <tr>
        <td>变速箱：</td>
        <td>
            <input type=""checkbox"" id=""AMT1"" name=""AMT"" value=""自动"" /> 自动
            <input type=""checkbox"" id=""AMT2"" name=""AMT"" value=""手动"" /> 手动
        </td>
    </tr>
    <tr>
        <td>日租价格（元/天）：</td>
        <td>
            <input type=""text"" id=""Price"" placeholder=""请输");
            WriteLiteral(@"入单价"" />
        </td>
    </tr>
    <tr>
        <td>汽车照片：</td>
        <td>
            <input id=""Image"" type=""file"" />
        </td>
    </tr>
    <tr>
        <td>
            <input type=""button"" value=""挂靠"" onclick=""AddVa()"" class=""btn bg-success"" />
        </td>
        <td>
            <input type=""button"" value=""取消"" onclick=""location.href='SoCar/CarShow()'"" class=""btn btn-danger"" />
        </td>
    </tr>
</table>



<script>

    $(function () {
        BandSelCarType();
        BandSelCarBrand();
    })
    function BandSelCarType() {
        $.ajax({
            url: 'http://localhost:57894/api/zjlCarType5/',
            type: 'get',
            dataType: 'json',
            success: function (d) {
                $(""#bid"").empty();
                $(""#bid"").append(""<option value=''>--请选择--</option>"");
                $(d).each(function () {
                    var opt = ""<option value="" + this.carTypeID + "">"" + this.type + ""</option>"";
                    $(""");
            WriteLiteral(@"#bid"").append(opt);
                })
            }
        })
    }

    function BandSelCarBrand() {
        $.ajax({
            url: 'http://localhost:57894/api/zjlCarBrand/',
            type: 'get',
            dataType: 'json',
            success: function (d) {
                $(""#cid"").empty();
                $(""#cid"").append(""<option value=''>--请选择--</option>"");
                $(d).each(function () {
                    var opt = ""<option value="" + this.carBrandID + "">"" + this.brand + ""</option>"";
                    $(""#cid"").append(opt);
                })
            }
        })
    }


    function AddVa() {
        var obj = {};
        obj.uid = ""1"";
        obj.Image = $(""#Image"").val();
        obj.bid = $(""#bid"").val();
        obj.CarName = $(""#CarName"").val();
        obj.Years = $(""#Years"").val();
        obj.cid = $(""#cid"").val();
        obj.CC = $(""#CC"").val();
        obj.AMT = $(""#AMT1"").click() == true ? ""手动"" : ""自动"";
        obj.Price = $(""#Pri");
            WriteLiteral(@"ce"").val();

        $.ajax({
            url: ""http://localhost:57894/api/zjlCar2"",
            type: ""POST"",
            data: obj,
            processData: false,
            contentType: false,
            crossDomain: true,
            async: true,
            success: function (d) {
                alert(""挂靠成功"");
                location.href = ""SoCar/Show()"";
            },
            error: function (d) {
                alert(""挂靠失败"");
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
