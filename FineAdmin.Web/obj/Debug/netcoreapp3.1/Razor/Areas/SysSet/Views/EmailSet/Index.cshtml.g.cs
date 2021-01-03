#pragma checksum "G:\VS\VS框架\自写框架\FineAdmin\FineAdmin.Web\Areas\SysSet\Views\EmailSet\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7c16768c5d168fb47afa10261a60d12d3d9234c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SysSet_Views_EmailSet_Index), @"mvc.1.0.view", @"/Areas/SysSet/Views/EmailSet/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7c16768c5d168fb47afa10261a60d12d3d9234c", @"/Areas/SysSet/Views/EmailSet/Index.cshtml")]
    public class Areas_SysSet_Views_EmailSet_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FineAdmin.Web.Areas.SysSet.Models.EmailModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "G:\VS\VS框架\自写框架\FineAdmin\FineAdmin.Web\Areas\SysSet\Views\EmailSet\Index.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Views/Shared/_LayoutSysSetPage.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""layui-fluid"">
    <div class=""layui-row layui-col-space15"">
        <div class=""layui-col-md12"">
            <div class=""layui-card"">
                <div class=""layui-card-header"">邮件设置</div>
                <div class=""layui-card-body"">
                    <form class=""layui-form"" lay-filter=""EmailForm"" action=""/SysSet/EmailSet/Index"" method=""post"">
                        <div class=""layui-form-item"">
                            <label class=""layui-form-label"">SMTP服务器</label>
                            <div class=""layui-input-block"">
                                ");
#nullable restore
#line 17 "G:\VS\VS框架\自写框架\FineAdmin\FineAdmin.Web\Areas\SysSet\Views\EmailSet\Index.cshtml"
                           Write(Html.TextBoxFor(x => x.EmailSmtp, null, new Dictionary<string, object> { { "class", "layui-input" }, { "lay-verify", "required" }, { "autocomplete", "off" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""layui-form-item"">
                            <label class=""layui-form-label"">SSL加密连接</label>
                            <div class=""layui-input-block"">
                                <select name=""EmailSSL"">
                                    <option value=""true"">true</option>
                                    <option value=""false"">false</option>
                                </select>
                            </div>
                        </div>
                        <div class=""layui-form-item"">
                            <label class=""layui-form-label"">SMTP端口</label>
                            <div class=""layui-input-block"">
                                ");
#nullable restore
#line 32 "G:\VS\VS框架\自写框架\FineAdmin\FineAdmin.Web\Areas\SysSet\Views\EmailSet\Index.cshtml"
                           Write(Html.TextBoxFor(x => x.EmailPort, null, new Dictionary<string, object> { { "class", "layui-input" }, { "lay-verify", "required|number" }, { "autocomplete", "off" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""layui-form-item"">
                            <label class=""layui-form-label"">发件人地址</label>
                            <div class=""layui-input-block"">
                                ");
#nullable restore
#line 38 "G:\VS\VS框架\自写框架\FineAdmin\FineAdmin.Web\Areas\SysSet\Views\EmailSet\Index.cshtml"
                           Write(Html.TextBoxFor(x => x.EmailFrom, null, new Dictionary<string, object> { { "class", "layui-input" }, { "lay-verify", "required|email" }, { "autocomplete", "off" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""layui-form-item"">
                            <label class=""layui-form-label"">邮箱账号</label>
                            <div class=""layui-input-block"">
                                ");
#nullable restore
#line 44 "G:\VS\VS框架\自写框架\FineAdmin\FineAdmin.Web\Areas\SysSet\Views\EmailSet\Index.cshtml"
                           Write(Html.TextBoxFor(x => x.MailUserName, null, new Dictionary<string, object> { { "class", "layui-input" }, { "lay-verify", "required|email" }, { "autocomplete", "off" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""layui-form-item"">
                            <label class=""layui-form-label"">邮箱密码</label>
                            <div class=""layui-input-block"">
                                ");
#nullable restore
#line 50 "G:\VS\VS框架\自写框架\FineAdmin\FineAdmin.Web\Areas\SysSet\Views\EmailSet\Index.cshtml"
                           Write(Html.TextBoxFor(x => x.MailPassword, null, new Dictionary<string, object> { { "class", "layui-input" }, { "lay-verify", "required" }, { "autocomplete", "off" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""layui-form-item"">
                            <label class=""layui-form-label"">发件人昵称</label>
                            <div class=""layui-input-block"">
                                ");
#nullable restore
#line 56 "G:\VS\VS框架\自写框架\FineAdmin\FineAdmin.Web\Areas\SysSet\Views\EmailSet\Index.cshtml"
                           Write(Html.TextBoxFor(x => x.MailName, null, new Dictionary<string, object> { { "class", "layui-input" }, { "lay-verify", "required" }, { "autocomplete", "off" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""layui-form-item"">
                            <div class=""layui-input-block"">
                                <button class=""layui-btn"" lay-submit style=""float:left;"">确认保存</button>
                                <div class=""div-msg"" style=""float:left;"">");
#nullable restore
#line 62 "G:\VS\VS框架\自写框架\FineAdmin\FineAdmin.Web\Areas\SysSet\Views\EmailSet\Index.cshtml"
                                                                    Write(ViewBag.Msg);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                            </div>
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </div>
</div>
<script type=""text/javascript"">
    layui.use(['form'], function () {
        var form = layui.form;
        form.val(""EmailForm"",{
            ""EmailSSL"":""");
#nullable restore
#line 75 "G:\VS\VS框架\自写框架\FineAdmin\FineAdmin.Web\Areas\SysSet\Views\EmailSet\Index.cshtml"
                   Write(Model.EmailSSL);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n        });\r\n    })\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FineAdmin.Web.Areas.SysSet.Models.EmailModel> Html { get; private set; }
    }
}
#pragma warning restore 1591