#pragma checksum "G:\VS\VS框架\自写框架\FineAdmin\FineAdmin.Web\Areas\Permissions\Views\Items\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84065918a5d56e81dd6e6a77e691b96e03cd6f49"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Permissions_Views_Items_Add), @"mvc.1.0.view", @"/Areas/Permissions/Views/Items/Add.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84065918a5d56e81dd6e6a77e691b96e03cd6f49", @"/Areas/Permissions/Views/Items/Add.cshtml")]
    public class Areas_Permissions_Views_Items_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "G:\VS\VS框架\自写框架\FineAdmin\FineAdmin.Web\Areas\Permissions\Views\Items\Add.cshtml"
  
    ViewBag.Title = "Add";
    Layout = "~/Views/Shared/_LayoutForm.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<form class=""layui-form layui-form-pane ok-form"">
    <div class=""layui-form-item"">
        <label class=""layui-form-label"">分类编码</label>
        <div class=""layui-input-block"">
            <input type=""text"" name=""EnCode"" placeholder=""分类编码"" autocomplete=""off"" class=""layui-input"" lay-verify=""required"">
        </div>
    </div>
    <div class=""layui-form-item"">
        <label class=""layui-form-label"">分类名称</label>
        <div class=""layui-input-block"">
            <input type=""text"" name=""FullName"" placeholder=""分类名称"" autocomplete=""off"" class=""layui-input"" lay-verify=""required"">
        </div>
    </div>
    <div class=""layui-form-item"">
        <label class=""layui-form-label"">上级分类</label>
        <div class=""layui-input-block"">
            <input type=""text"" id=""ParentId"" name=""ParentId"" placeholder=""上级机构"" autocomplete=""off"" class=""layui-input"">
        </div>
    </div>
    <div class=""layui-form-item"">
        <label class=""layui-form-label"">排序码</label>
        <div class=""layui-input-");
            WriteLiteral(@"block"">
            <input type=""text"" name=""SortCode"" placeholder=""排序码"" autocomplete=""off"" class=""layui-input"" lay-verify=""number"" maxlength=""2"">
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
    layui.use([""form"", ""treeSelect"", ""okLayer"", ""okUtils""], function () {
        let treeSelect = layui.treeSelect;
        let form = layui.form;
        let okLayer = layui.okLayer;
        let okUtils = layui.okUtils;
        treeSelect.render({
            elem: ""#ParentId"",
            data: ""/Permissions/Items/GetItemsTreeSelect"",
            type: ""GET""
        });
        form.on(""submit(add)"", function (data) {
            okUtils.ajax(""/Permissions/Items/Add"", ""post"", data.field, true).done(function (response) {
                okLa");
            WriteLiteral(@"yer.greenTickMsg(response.message, function () {
                    parent.location.reload(); // 父页面刷新
                    parent.layer.close(parent.layer.getFrameIndex(window.name));//先得到当前iframe层的索引 再执行关闭
                });
            }).fail(function (error) {
                console.log(error)
            });
            return false;
        });
    });
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
