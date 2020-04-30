#pragma checksum "L:\实训一\百车汇汽车租赁系统啊mvc\CarMVC\CarMVC\Views\yyhCar\OrdersShow.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f66c63c121b9e75dafc2c10704e65b57d23691d6"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f66c63c121b9e75dafc2c10704e65b57d23691d6", @"/Views/yyhCar/OrdersShow.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20c0780ed8a87b80ef297575bc486aef67988026", @"/Views/_ViewImports.cshtml")]
    public class Views_yyhCar_OrdersShow : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "L:\实训一\百车汇汽车租赁系统啊mvc\CarMVC\CarMVC\Views\yyhCar\OrdersShow.cshtml"
  
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

<table class="" table-bordered table"">
    <tr>
        <td>总记录数<span id=""TotalCount""></span>条</td>
        <td>总共<span id=""TotalPage""></span>页</td>
        <td>当前第<span id=""CurrentPage""></span>页</td>
        <td><a href=""javascript:;"" onclick=""Show(1)"">首页</a></td>
        <td><a href=""javascript:;"" onclick=""Show(currentPage-1)"">上一页</a></td>
        <td><a href=""javascript:;"" onclick=""Show(currentPage+1)"">下一页</a></td>
        <td><a href=""javascript:;"" onclick=""Show(totalPage)"">尾页");
            WriteLiteral(@"</a></td>
    </tr>
</table>

<script>

    var pageSize = 3;
    var currentPage = 1;
    var totalPage = 1;


        $(function () {
            Show();
    })

    function Show1(page) {

        var obj = {};
        obj.currentPage = page;
        obj.pageSize = pageSize;

        $.ajax({
            url: 'http://localhost:57894/api/zjlCar/',
            type: 'get',
            dataType: 'json',
            data: obj,
            async: true,
            crossDomain: true,
            success: function (d) {
                $(""#TotalCount"").text(d.totalCount)
                $(""#TotalPage"").text(d.totalPage)
                $(""#CurrentPage"").text(d.currentPage)
                //最大页
                totalPage = d.totalPage;
                //当前页
                currentPage = d.currentPage;
                    $(""#tb"").empty();
                    $(d.orders).each(function () {
                        var line = '<tr>'
                            + '<td>' + this.Or");
            WriteLiteral(@"dersID + '</td>'
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
                            + '<td>' + (this.Hitch == 1 ? null : ""<input id='Button1' type='button' value='报修原因' class='btn btn-danger' onclick=GetBreakdown("" + this.BreakdownID + "") />"" + '&nbsp;' + ""<input id='Button1' type='button' va");
            WriteLiteral(@"lue='报修通过' class='btn btn-success' onclick=UptAgree("" + this.OrdersID + "") />"" + '&nbsp;' + ""<input id='Button1' type='button' value='有待商议' onclick=UptDisAgree("" + this.OrdersID + "") />"")
                            + '</td>'
                            + '</tr>';
                        $(""#tb"").append(line);
                    })
            }

        })
    }

    //跳转到故障原因
    function GetBreakdown(id) {
        location.href = ""/Admins/GetBreakdownShow?id="" + id;
    }
    //修改状态
    function UptAgree(id) {
        $.ajax({
            url: 'http://localhost:57894/api/Admins/' + id,
            type: 'put',
            dataType: 'json',
            crossDomain: true,
            data: { id: id },
            success: function (d) {
                if (d > 0) {
                    alert('报修通过！');
                    Show();
                }
                else {
                    alert('操作失败！');
                }
            }
        })
    }

    function UptDisAg");
            WriteLiteral(@"ree(id) {
        $.ajax({
            url: 'http://localhost:57894/api/Admins3/' + id,
            type: 'put',
            dataType: 'json',
            crossDomain: true,
            data: { id: id },
            success: function (d) {
                if (d > 0) {
                    alert('有待商议！');
                    Show();
                }
                else {
                    alert('操作失败！');
                }
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
