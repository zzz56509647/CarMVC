#pragma checksum "D:\A_Githup\thisOnline\CarMvc_\CarMVC\CarMVC\Views\yyhCar\AddUserInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11d128230e20fe1ceb763398889580535bfddb64"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_yyhCar_AddUserInfo), @"mvc.1.0.view", @"/Views/yyhCar/AddUserInfo.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11d128230e20fe1ceb763398889580535bfddb64", @"/Views/yyhCar/AddUserInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e7004a7c9a63a2ea2d34940dc9a962f7bc52123", @"/Views/_ViewImports.cshtml")]
    public class Views_yyhCar_AddUserInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\A_Githup\thisOnline\CarMvc_\CarMVC\CarMVC\Views\yyhCar\AddUserInfo.cshtml"
  
    ViewData["Title"] = "AddUserInfo";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>个人实名认证</h1>
<table class=""table table-bordered"">
    <tr>
        <td>个人姓名：<input id=""Text1"" type=""text"" /></td>
    </tr>
    <tr>
        <td>身份证号：<input id=""Text2"" type=""text"" /></td>
    </tr>
    <tr>
        <td><input type=""button"" value=""取消""");
            BeginWriteAttribute("onclick", " onclick=\"", 313, "\"", 323, 0);
            EndWriteAttribute();
            WriteLiteral("  class=\"btn btn-primary\" />\r\n        <input type=\"button\" value=\"提交认证\" onclick=\"AddUser()\"  class=\"btn btn-primary\" /></td>\r\n    </tr>\r\n</table>\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
    function AddUser() {
        var obj = {};
        obj.UName = $(""#Text1"").val();
        obj.IDcard = $(""#Text2"").val();
        $.ajax({
            url: 'http://localhost:57894/api/zjlCar3/',
            type: 'post',
            dataType: 'json',
            data: obj,
            success: function (d) {
                if (d > 0) {
                    alert('添加成功！');
                    location.href = '//';
                }
            }
        })
    </script>

");
            }
            );
            WriteLiteral("\r\n");
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
