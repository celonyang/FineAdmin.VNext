#pragma checksum "G:\VS\VS框架\自写框架\FineAdmin\FineAdmin.VNext\FineAdmin.Web\Areas\Permissions\Views\Items\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8738a2ccdf0b6569fd9fb2b9f32c7fc9fc37a298"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Permissions_Views_Items_Index), @"mvc.1.0.view", @"/Areas/Permissions/Views/Items/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8738a2ccdf0b6569fd9fb2b9f32c7fc9fc37a298", @"/Areas/Permissions/Views/Items/Index.cshtml")]
    public class Areas_Permissions_Views_Items_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "G:\VS\VS框架\自写框架\FineAdmin\FineAdmin.VNext\FineAdmin.Web\Areas\Permissions\Views\Items\Index.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Views/Shared/_LayoutList.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style type=""text/css"">
    .div-collapse {
        float: left;
        height: 20px;
        line-height: 20px;
        padding-left: 5px;
    }
</style>
<!--数据表格-->
<table class=""layui-hide"" id=""tableId"" lay-filter=""tableFilter""></table>
<script>
    layui.use([""treeGrid"", ""okLayer"", ""okUtils""], function () {
        let treeGrid = layui.treeGrid;
        let okLayer = layui.okLayer;
        let okUtils = layui.okUtils;
        let $ = layui.$;

        treeGrid.render({
            elem: ""#tableId"",
            url: ""/Permissions/Items/List"",
            page: false,
            toolbar: ""#toolbarTpl"",
            size: ""sm"",
            cellMinWidth: 100,
            treeId: 'Id',   //树形id字段名称
            treeUpId: 'ParentId',   //树形父id字段名称
            treeShowName: 'FullName',   //以树形式显示的字段
            cols: [[
                { field: ""Id"", title: ""ID"", sort: true },
                { field: ""FullName"", title: ""机构名称"" },
                { field: ""EnCode"", title: ""机构编码"" },");
            WriteLiteral(@"
                { field: ""SortCode"", title: ""排序码"", width: 120 },
                { field: ""CreateTime"", title: ""创建时间"", width: 150, templet: '<span>{{showDate(d.CreateTime)}}<span>' },
                { title: ""操作"", width: 230, align: ""center"", fixed: ""right"", templet: ""#operationTpl""}
            ]]
        });

        //add
        $('#add').on('click', function () {
            okLayer.open(""添加分类"", ""/Permissions/Items/Add"", ""100%"", ""100%"", null, null);
        });

        treeGrid.on(""tool(tableFilter)"", function (obj) {
            let data = obj.data;
            switch (obj.event) {
                case ""edit"":
                    edit(data.Id);//field Id 和 数据库表字段 Id 要一致
                    break;
                case ""del"":
                    del(data.Id);
                    break;
            }
        });

        function edit(id) {
            okLayer.open(""编辑分类"", ""/Permissions/Items/Edit/"" + id, ""100%"", ""100%"", null, null);
        }

        function del(id) {
   ");
            WriteLiteral(@"         okLayer.confirm(""确定要删除吗？"", function () {
                okUtils.ajax(""/Permissions/Items/Delete"", ""get"", { id: id }, true).done(function (response) {
                    okUtils.tableSuccessMsg(response.message);
                    //没开启分页，没确定按钮，手动刷新
                    setTimeout(function () {
                        window.location.reload();
                    }, 1500);
                }).fail(function (error) {
                    console.log(error)
                });
            })
        }

    })
</script>
<!-- 头工具栏模板 -->
<script type=""text/html"" id=""toolbarTpl"">
    ");
#nullable restore
#line 83 "G:\VS\VS框架\自写框架\FineAdmin\FineAdmin.VNext\FineAdmin.Web\Areas\Permissions\Views\Items\Index.cshtml"
Write(Html.TopToolBarHtml(ViewData["TopButtonList"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</script>\r\n<!-- 行工具栏模板 -->\r\n<script type=\"text/html\" id=\"operationTpl\">\r\n    ");
#nullable restore
#line 87 "G:\VS\VS框架\自写框架\FineAdmin\FineAdmin.VNext\FineAdmin.Web\Areas\Permissions\Views\Items\Index.cshtml"
Write(Html.RightToolBarHtml(ViewData["RightButtonList"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</script>\r\n\r\n");
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
