#pragma checksum "G:\VS\VS框架\自写框架\FineAdmin\FineAdmin.Web\Areas\Permissions\Views\Organize\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37454b9080d7cf2f632824598916cf33dc9a81f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Permissions_Views_Organize_Edit), @"mvc.1.0.view", @"/Areas/Permissions/Views/Organize/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37454b9080d7cf2f632824598916cf33dc9a81f2", @"/Areas/Permissions/Views/Organize/Edit.cshtml")]
    public class Areas_Permissions_Views_Organize_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FineAdmin.Model.OrganizeModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "G:\VS\VS框架\自写框架\FineAdmin\FineAdmin.Web\Areas\Permissions\Views\Organize\Edit.cshtml"
  
    ViewBag.Title = "Edit";
    Layout = "~/Views/Shared/_LayoutForm.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<form class=\"layui-form layui-form-pane ok-form\" lay-filter=\"formTest\">\r\n");
            WriteLiteral("    ");
#nullable restore
#line 9 "G:\VS\VS框架\自写框架\FineAdmin\FineAdmin.Web\Areas\Permissions\Views\Organize\Edit.cshtml"
Write(Html.HiddenFor(x => x.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 10 "G:\VS\VS框架\自写框架\FineAdmin\FineAdmin.Web\Areas\Permissions\Views\Organize\Edit.cshtml"
Write(Html.HiddenFor(x => x.CreateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 11 "G:\VS\VS框架\自写框架\FineAdmin\FineAdmin.Web\Areas\Permissions\Views\Organize\Edit.cshtml"
Write(Html.HiddenFor(x => x.CreateUserId));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div class=""layui-form-item"">
        <label class=""layui-form-label"">机构编码</label>
        <div class=""layui-input-block"">
            <input type=""text"" name=""EnCode"" placeholder=""机构编码"" autocomplete=""off"" class=""layui-input"" lay-verify=""required"">
        </div>
    </div>
    <div class=""layui-form-item"">
        <label class=""layui-form-label"">机构名称</label>
        <div class=""layui-input-block"">
            <input type=""text"" name=""FullName"" placeholder=""机构名称"" autocomplete=""off"" class=""layui-input"" lay-verify=""required"">
        </div>
    </div>
    <div class=""layui-form-item"">
        <label class=""layui-form-label"">上级机构</label>
        <div class=""layui-input-block"">
            <input type=""text"" id=""ParentId"" lay-filter=""tree"" name=""ParentId"" placeholder=""上级机构"" autocomplete=""off"" class=""layui-input"">
        </div>
    </div>
    <div class=""layui-form-item"">
        <label class=""layui-form-label"">排序码</label>
        <div class=""layui-input-block"">
            <input type=");
            WriteLiteral(@"""text"" name=""SortCode"" placeholder=""排序码"" autocomplete=""off"" class=""layui-input"" lay-verify=""number"" maxlength=""2"">
        </div>
    </div>
    <div class=""layui-form-item"">
        <label class=""layui-form-label"">分类</label>
        <div class=""layui-input-block"">
            ");
#nullable restore
#line 39 "G:\VS\VS框架\自写框架\FineAdmin\FineAdmin.Web\Areas\Permissions\Views\Organize\Edit.cshtml"
       Write(Html.DropDownList("CategoryId", (IEnumerable<SelectListItem>)ViewBag.CategoryNameList, "请选择分类", new Dictionary<string, object> { { "lay-verify", "required" } }));

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
    layui.use([""form"", ""treeSelect"", ""okLayer"", ""okUtils""], function () {
        let treeSelect = layui.treeSelect;
        let form = layui.form;
        let okLayer = layui.okLayer;
        let okUtils = layui.okUtils;
        treeSelect.render({
            elem: ""#ParentId"",
            data: ""/Permissions/Organize/GetOrganizeTreeSelect"",
            type: ""GET""
");
#nullable restore
#line 59 "G:\VS\VS框架\自写框架\FineAdmin\FineAdmin.Web\Areas\Permissions\Views\Organize\Edit.cshtml"
             if (Model.ParentId!=0)
            {
                

#line default
#line hidden
#nullable disable
            WriteLiteral(",success: function (d) {\r\n                treeSelect.checkNode(\'tree\', \"");
#nullable restore
#line 62 "G:\VS\VS框架\自写框架\FineAdmin\FineAdmin.Web\Areas\Permissions\Views\Organize\Edit.cshtml"
                                         Write(Model.ParentId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\");\r\n                treeSelect.refresh(\'tree\');\r\n                }");
#nullable restore
#line 64 "G:\VS\VS框架\自写框架\FineAdmin\FineAdmin.Web\Areas\Permissions\Views\Organize\Edit.cshtml"
                        
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        });\r\n        //给表单赋值\r\n        form.val(\"formTest\", { //formTest 即 class=\"layui-form\" 所在元素属性 lay-filter=\"\" 对应的值\r\n            \"EnCode\": \"");
#nullable restore
#line 69 "G:\VS\VS框架\自写框架\FineAdmin\FineAdmin.Web\Areas\Permissions\Views\Organize\Edit.cshtml"
                  Write(Model.EnCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\r\n            \"FullName\": \"");
#nullable restore
#line 70 "G:\VS\VS框架\自写框架\FineAdmin\FineAdmin.Web\Areas\Permissions\Views\Organize\Edit.cshtml"
                    Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\r\n            \"SortCode\": \"");
#nullable restore
#line 71 "G:\VS\VS框架\自写框架\FineAdmin\FineAdmin.Web\Areas\Permissions\Views\Organize\Edit.cshtml"
                    Write(Model.SortCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\r\n            \"CategoryId\": \"");
#nullable restore
#line 72 "G:\VS\VS框架\自写框架\FineAdmin\FineAdmin.Web\Areas\Permissions\Views\Organize\Edit.cshtml"
                      Write(Model.CategoryId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""
        });
        form.on(""submit(add)"", function (data) {
            okUtils.ajax(""/Permissions/Organize/Edit"", ""post"", data.field, true).done(function (response) {
                okLayer.greenTickMsg(response.message, function () {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FineAdmin.Model.OrganizeModel> Html { get; private set; }
    }
}
#pragma warning restore 1591