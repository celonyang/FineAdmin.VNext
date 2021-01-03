#pragma checksum "G:\VS\VS框架\自写框架\FineAdmin\FineAdmin.Web\Areas\Permissions\Views\Role\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "637e3be8f6e607a44f26fa80a2fc9a5c5d5b5460"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Permissions_Views_Role_Add), @"mvc.1.0.view", @"/Areas/Permissions/Views/Role/Add.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"637e3be8f6e607a44f26fa80a2fc9a5c5d5b5460", @"/Areas/Permissions/Views/Role/Add.cshtml")]
    public class Areas_Permissions_Views_Role_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "G:\VS\VS框架\自写框架\FineAdmin\FineAdmin.Web\Areas\Permissions\Views\Role\Add.cshtml"
  
    ViewBag.Title = "Add";
    Layout = "~/Views/Shared/_LayoutForm.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<form class=""layui-form layui-form-pane ok-form"">
    <div class=""layui-form-item"">
        <label class=""layui-form-label"">角色编码</label>
        <div class=""layui-input-block"">
            <input type=""text"" name=""EnCode"" placeholder=""角色编码"" autocomplete=""off"" class=""layui-input"" lay-verify=""required"">
        </div>
    </div>
    <div class=""layui-form-item"">
        <label class=""layui-form-label"">角色名称</label>
        <div class=""layui-input-block"">
            <input type=""text"" name=""FullName"" placeholder=""角色名称"" autocomplete=""off"" class=""layui-input"" lay-verify=""required"">
        </div>
    </div>
    <div class=""layui-form-item"">
        <label class=""layui-form-label"">排序码</label>
        <div class=""layui-input-block"">
            <input type=""text"" name=""SortCode"" placeholder=""排序码"" autocomplete=""off"" class=""layui-input"" lay-verify=""number"" maxlength=""2"">
        </div>
    </div>
    <div class=""layui-form-item"">
        <label class=""layui-form-label"">角色类型</label>
        <div ");
            WriteLiteral("class=\"layui-input-block\">\r\n            ");
#nullable restore
#line 29 "G:\VS\VS框架\自写框架\FineAdmin\FineAdmin.Web\Areas\Permissions\Views\Role\Add.cshtml"
       Write(Html.DropDownList("TypeClass", (IEnumerable<SelectListItem>)ViewBag.RoleTypeList, "请选择角色类型", new Dictionary<string, object> { { "lay-verify", "required" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
    </div>
    <div class=""layui-form-item"">
        <div class=""layui-input-block"">
            <button class=""layui-btn"" lay-submit lay-filter=""add"">立即提交</button>
            <button type=""reset"" class=""layui-btn layui-btn-primary"">重置</button>
        </div>
    </div>
</form>
<script>
    layui.use([""form"", ""okLayer"", ""okUtils""], function () {
        let form = layui.form;
        let okLayer = layui.okLayer;
        let okUtils = layui.okUtils;
        form.on(""submit(add)"", function (data) {
            okUtils.ajax(""/Permissions/Role/Add"", ""post"", data.field, true).done(function (response) {
                okLayer.greenTickMsg(response.message, function () {
                    parent.location.reload(); // 父页面刷新
                    parent.layer.close(parent.layer.getFrameIndex(window.name));//先得到当前iframe层的索引 再执行关闭
                });
            }).fail(function (error) {
                console.log(error)
            });
            return false;
        });
");
            WriteLiteral("    });\r\n</script>\r\n\r\n");
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
