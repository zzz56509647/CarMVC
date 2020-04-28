#pragma checksum "D:\物联网\实训\CarMVC1\CarMVC\CarMVC\Views\yyhCar\OrdersShow.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db8a698246868317bbf3187e74671e52cf93de83"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_yyhCar_OrdersShow), @"mvc.1.0.view", @"/Views/yyhCar/OrdersShow.cshtml")]
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
#line 1 "D:\物联网\实训\CarMVC1\CarMVC\CarMVC\Views\_ViewImports.cshtml"
using CarMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\物联网\实训\CarMVC1\CarMVC\CarMVC\Views\_ViewImports.cshtml"
using CarMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db8a698246868317bbf3187e74671e52cf93de83", @"/Views/yyhCar/OrdersShow.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20c0780ed8a87b80ef297575bc486aef67988026", @"/Views/_ViewImports.cshtml")]
    public class Views_yyhCar_OrdersShow : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\物联网\实训\CarMVC1\CarMVC\CarMVC\Views\yyhCar\OrdersShow.cshtml"
  
    ViewData["Title"] = "OrdersShow";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>个人订单显示</h1>

<table class=""table table-bordered"">
    <thead style=""background-color:bisque"">
        <tr style=""text-align:center"">
            <th>ID</th>
            <th>订单编号</th>
            <th>用户</th>
            <th>汽车名称</th>
            <th>租车用途</th>
            <th>取车时间</th>
            <th>还车时间</th>
            <th>是否配用司机</th>
            <th>费用</th>
            <th>订单状态</th>
            <th>是否故障</th>
            <th>操作</th>
        </tr>
    </thead>
    <tbody id=""tb""></tbody>
</table>

<script>
    $(function () {
        Show();
    })

    function Show() {
        $.ajax({
            url: 'http://localhost:57894/api/zjlCar/',
            type: 'get',
            dataType: 'json',
            async: true,
            crossDomain: true,
            success: function (d) {
                    $(""#tb"").empty();
                    $(d).each(function () {
                        var line = '<tr>'
                            + '<td>' + this.OrdersID + '</");
            WriteLiteral(@"td>'
                            + '<td>' + this.Oid + '</td>'
                            + '<td>' + this.Name + '</td>' //有待改动
                            + '<td>' + this.CarName + '</td>'
                            + '<td>' + this.Useing + '</td>'
                            + '<td>' + this.StartTime + '</td>'
                            + '<td>' + this.EndTime + '</td>'
                            + '<td>' + (this.Driver ? ""是"" : ""否"") + '</td>'
                            + '<td>' + this.Price + '</td>'
                            + '<td>' + (this.ZT == 1 ? ""您已预定"" : (this.ZT == 2 ? ""立刻上路"" : ""取消订单"")) + '</td>'
                            + '<td>' + (this.Hitch == 1 ? ""暂无问题"" : (this.Hitch == 2 ? ""故障申请"" : (this.Hitch == 3 ? ""报修通过"" : ""有待商议""))) + '</td>'
                            + '<td>' + (this.Hitch == 1 ? null : ""<input id='Button1' type='button' value='报修原因' class='btn btn-danger' onclick=GetBreakdown("" + this.BreakdownID + "") />"" + '&nbsp;' + ""<input id='Button1' type='button' value='报修通过' c");
            WriteLiteral(@"lass='btn btn-success' onclick=UptAgree("" + this.OrdersID + "") />"" + '&nbsp;' + ""<input id='Button1' type='button' value='有待商议' onclick=UptDisAgree("" + this.OrdersID + "") />"")
                            + '</td>'
                            + '</tr>';
                        $(""#tb"").append(line);
                 })
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