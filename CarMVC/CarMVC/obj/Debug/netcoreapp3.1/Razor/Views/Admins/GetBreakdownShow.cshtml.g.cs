#pragma checksum "L:\实训一\百车汇汽车租赁系统mvc\CarMVC\CarMVC\Views\Admins\GetBreakdownShow.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a3718311532de87dbe6bd89442ee6ad14495710"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admins_GetBreakdownShow), @"mvc.1.0.view", @"/Views/Admins/GetBreakdownShow.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a3718311532de87dbe6bd89442ee6ad14495710", @"/Views/Admins/GetBreakdownShow.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20c0780ed8a87b80ef297575bc486aef67988026", @"/Views/_ViewImports.cshtml")]
    public class Views_Admins_GetBreakdownShow : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<table class=""table table-bordered"">
    <tr>
        <td>订单序号：</td>
        <td><input id=""OrdersID"" type=""text"" readonly=""readonly"" /></td>
    </tr>
    <tr>
        <td>故障原因：</td>
        <td><input id=""Reson"" type=""text"" readonly=""readonly"" /></td>

    </tr>
    <tr>
        <td>联系电话：</td>
        <td><input id=""Phone"" type=""text"" readonly=""readonly"" /></td>

    </tr>
</table>

");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(function () {\r\n            show();\r\n        })\r\n\r\n        function show() {\r\n            $.ajax({\r\n                url: \'http://localhost:57894/api/Admins/\' +");
#nullable restore
#line 27 "L:\实训一\百车汇汽车租赁系统mvc\CarMVC\CarMVC\Views\Admins\GetBreakdownShow.cshtml"
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
