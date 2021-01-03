#pragma checksum "G:\VS\VS框架\自写框架\FineAdmin\FineAdmin.Web\Areas\SysSet\Views\DevSet\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9af2efd703edd62c1004e6fd981976ce258608df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SysSet_Views_DevSet_Index), @"mvc.1.0.view", @"/Areas/SysSet/Views/DevSet/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9af2efd703edd62c1004e6fd981976ce258608df", @"/Areas/SysSet/Views/DevSet/Index.cshtml")]
    public class Areas_SysSet_Views_DevSet_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FineAdmin.Web.Areas.SysSet.Models.DevModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "G:\VS\VS框架\自写框架\FineAdmin\FineAdmin.Web\Areas\SysSet\Views\DevSet\Index.cshtml"
  
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
                <div class=""layui-card-header"">开发设置</div>
                <div class=""layui-card-body"">
                    <form class=""layui-form"" action=""/SysSet/DevSet/Index"" method=""post"">
                        <div class=""layui-form-item"">
                            <label class=""layui-form-label"">初始化密码</label>
                            <div class=""layui-input-block"">
                                ");
#nullable restore
#line 17 "G:\VS\VS框架\自写框架\FineAdmin\FineAdmin.Web\Areas\SysSet\Views\DevSet\Index.cshtml"
                           Write(Html.TextBoxFor(x => x.InitUserPwd, null, new Dictionary<string, object> { { "class", "layui-input" }, { "lay-verify", "required" }, { "autocomplete", "off" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""layui-form-item"">
                            <label class=""layui-form-label"">上传文件大小</label>
                            <div class=""layui-input-block"">
                                ");
#nullable restore
#line 23 "G:\VS\VS框架\自写框架\FineAdmin\FineAdmin.Web\Areas\SysSet\Views\DevSet\Index.cshtml"
                           Write(Html.TextBoxFor(x => x.UploadFileSize, null, new Dictionary<string, object> { { "class", "layui-input" }, { "lay-verify", "required|number" }, { "autocomplete", "off" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""layui-form-item"">
                            <label class=""layui-form-label"">上传文件类型</label>
                            <div class=""layui-input-block"">
                                ");
#nullable restore
#line 29 "G:\VS\VS框架\自写框架\FineAdmin\FineAdmin.Web\Areas\SysSet\Views\DevSet\Index.cshtml"
                           Write(Html.TextBoxFor(x => x.UploadFileType, null, new Dictionary<string, object> { { "class", "layui-input" }, { "lay-verify", "required" }, { "autocomplete", "off" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""layui-form-item"">
                            <label class=""layui-form-label"">登陆提供者模式</label>
                            <div class=""layui-input-inline"">
                                ");
#nullable restore
#line 35 "G:\VS\VS框架\自写框架\FineAdmin\FineAdmin.Web\Areas\SysSet\Views\DevSet\Index.cshtml"
                           Write(Html.TextBoxFor(x => x.LoginProvider, null, new Dictionary<string, object> { { "class", "layui-input" }, { "lay-verify", "required" }, { "autocomplete", "off" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                            <div class=""layui-form-mid layui-word-aux"">默认用Cookie登录模式，修改成Session要在启动项目前配置文件中改</div>
                        </div>
                        <div class=""layui-form-item"">
                            <div class=""layui-input-block"">
                                <button class=""layui-btn"" lay-submit style=""float:left;"">确认保存</button>
                                <div class=""div-msg"" style=""float:left;"">");
#nullable restore
#line 42 "G:\VS\VS框架\自写框架\FineAdmin\FineAdmin.Web\Areas\SysSet\Views\DevSet\Index.cshtml"
                                                                    Write(ViewBag.Msg);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            </div>\r\n                        </div>\r\n                    </form>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FineAdmin.Web.Areas.SysSet.Models.DevModel> Html { get; private set; }
    }
}
#pragma warning restore 1591