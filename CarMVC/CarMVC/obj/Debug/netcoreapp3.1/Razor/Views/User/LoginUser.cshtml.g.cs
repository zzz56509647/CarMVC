#pragma checksum "D:\物联网\实训\CarMVC1\CarMVC\CarMVC\Views\User\LoginUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a4341d7d457bf19f6c9b688c9b4337ac5ac63bd3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_LoginUser), @"mvc.1.0.view", @"/Views/User/LoginUser.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4341d7d457bf19f6c9b688c9b4337ac5ac63bd3", @"/Views/User/LoginUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20c0780ed8a87b80ef297575bc486aef67988026", @"/Views/_ViewImports.cshtml")]
    public class Views_User_LoginUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/jquery.unobtrusive-ajax.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/jquery-3.3.1.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\物联网\实训\CarMVC1\CarMVC\CarMVC\Views\User\LoginUser.cshtml"
  
    ViewData["Title"] = "LoginUser";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>百车汇租赁系统登录</h1>\r\n\r\n<table class=\"table \">\r\n    <tr>\r\n        <td>用户姓名</td>\r\n        <td>\r\n            <input id=\"name\" type=\"text\" />\r\n        </td>\r\n\r\n    </tr>\r\n");
            WriteLiteral(@"    <tr>
        <td>邮箱:</td>
        <td>
            <input id=""mail"" type=""text"" />
        </td>
    </tr>
    <tr>
        <td>验证码</td>
        <td>
            <input id=""core"" type=""text"" />
            <input id=""Button1"" type=""button"" value=""获取验证码"" onclick=""createcore()"" />

        </td>
    </tr>
    <tr>
        <td></td>
        <td>
            <input id=""button"" type=""button"" value=""登录"" />
            <input id=""Hidden1"" type=""hidden"" />
        </td>
    </tr>

</table>


");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a4341d7d457bf19f6c9b688c9b4337ac5ac63bd34818", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a4341d7d457bf19f6c9b688c9b4337ac5ac63bd35917", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n\r\n        //发送验证码\r\n        function createcore() {\r\n            var Email = $(\"#mail\").val();\r\n\r\n            /*var reg = */");
                WriteLiteral("\r\n                var reg = \"^\\\\s*([A-Za-z0-9_-]+(\\\\.\\\\w+)*");
#nullable restore
#line 55 "D:\物联网\实训\CarMVC1\CarMVC\CarMVC\Views\User\LoginUser.cshtml"
                                                      Write(Html.Raw("@"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "D:\物联网\实训\CarMVC1\CarMVC\CarMVC\Views\User\LoginUser.cshtml"
                                                                         ;

#line default
#line hidden
#nullable disable
                WriteLiteral(@"(\\w+\\.)+\\w{2,5})\\s*$"";

            if (Email.search(reg) == -1) {
                alert(""邮箱格式错误！"");
                return;
            }
            $.ajax({
                url: 'http://localhost:57894/api/user/SendMailMessage?Email=' + Email,
                type: 'get',

                success: function (d) {
                    alert(d);
                    $(""#Hidden1"").val(d);
                }
            })
        }
        //登录方法
        $(""#button"").click(function () {


            var obj = {};
            obj.Name = $(""#name"").val();
            obj.Email = $(""#mail"").val();

            if (obj.Name == """" || obj.Email == """") {
                alert(""用户名或邮箱不能为空！"");
                return;
            }

            var core = $(""#core"").val();
            var hidden = $(""#Hidden1"").val();
            if (core != hidden) {
                alert(""验证码错误！"");
                return;
            }


            $.ajax({
                url: 'http://localhos");
                WriteLiteral(@"t:57894/api/userlogin',
                type: 'post',
                //dataType: 'json',
                data: JSON.stringify(obj),
                contentType: ""application/json"",

                success: function (d) {
                    if (d > 0) {
                        alert(""登录成功！"");
                        location.href = '/Admin/OrderShow/';
                    }
                    else {
                        alert(""用户名或密码错误！"");
                        return;
                    }
                }
            })
        })

    </script>
");
            }
            );
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
