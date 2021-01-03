#pragma checksum "G:\VS\VS框架\自写框架\FineAdmin\FineAdmin.Web\Areas\Security\Views\LogonLog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b2c2931b4a99f2e1e9088490ded75e9e3bc6aa8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Security_Views_LogonLog_Index), @"mvc.1.0.view", @"/Areas/Security/Views/LogonLog/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b2c2931b4a99f2e1e9088490ded75e9e3bc6aa8", @"/Areas/Security/Views/LogonLog/Index.cshtml")]
    public class Areas_Security_Views_LogonLog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "G:\VS\VS框架\自写框架\FineAdmin\FineAdmin.Web\Areas\Security\Views\LogonLog\Index.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Views/Shared/_LayoutList.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!--模糊搜索区域-->
<div class=""layui-row"">
    <form class=""layui-form layui-col-md12 ok-search"">
        <div class=""layui-input-inline"">
            <input class=""layui-input"" placeholder=""请输入账户"" name=""Account"" autocomplete=""off"">
        </div>
        <div class=""layui-input-inline"">
            <input class=""layui-input"" placeholder=""请输入姓名"" name=""RealName"" autocomplete=""off"">
        </div>
        <div class=""layui-input-inline"">
            <input class=""layui-input"" placeholder=""日期范围"" autocomplete=""off"" name=""StartEndDate"" id=""StartEndDate"">
        </div>
        ");
#nullable restore
#line 19 "G:\VS\VS框架\自写框架\FineAdmin\FineAdmin.Web\Areas\Security\Views\LogonLog\Index.cshtml"
   Write(Html.SearchBtnHtml("查询"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 20 "G:\VS\VS框架\自写框架\FineAdmin\FineAdmin.Web\Areas\Security\Views\LogonLog\Index.cshtml"
   Write(Html.ResetBtnHtml());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </form>
</div>
<!--数据表格-->
<table class=""layui-hide"" id=""tableId"" lay-filter=""tableFilter""></table>
<script>
    layui.use([""element"", ""table"", ""form"", ""laydate"", ""okLayer"", ""okUtils""], function () {
        let table = layui.table;
        let form = layui.form;
        let laydate = layui.laydate;
        let okLayer = layui.okLayer;
        let okUtils = layui.okUtils;
        laydate.render({
            elem: '#StartEndDate'
            , range: '~'
        });

        let AllTable = table.render({
            elem: ""#tableId"",
            url: ""/Security/LogonLog/List"",
            limit: 10,
            page: true,
            toolbar: ""#toolbarTpl"",
            size: ""sm"",
            cols: [[
                { type: ""checkbox"" },
                { field: ""Id"", title: ""ID"", width: 80, sort: true },
                { field: ""Account"", title: ""账户"", width: 120 },
                { field: ""RealName"", title: ""姓名"", width: 120 },
                { field: ""LogType"", title: """);
            WriteLiteral(@"登录类型"", width: 100 },
                { field: ""Description"", title: ""描述"", width: 150 },
                { field: ""IPAddress"", title: ""IP地址"", width: 150 },
                { field: ""IPAddressName"", title: ""IP所在城市"", width: 150 },
                { field: ""CreateTime"", title: ""创建时间"", width: 150, templet: '<span>{{showDate(d.CreateTime)}}<span>' },
                { title: ""操作"", width: 100, align: ""center"", fixed: ""right"", templet: ""#operationTpl"" }
            ]],
            done: function (res, curr, count) {
                console.log(res, curr, count);
            }
        });

        form.on(""submit(search)"", function (data) {
            AllTable.reload({
                where: data.field,
                page: { curr: 1 }
            });
            return false;
        });

        table.on(""toolbar(tableFilter)"", function (obj) {
            switch (obj.event) {
                case ""batchDel"":
                    batchDel();
                    break;
            }
       ");
            WriteLiteral(@" });

        table.on(""tool(tableFilter)"", function (obj) {
            let data = obj.data;
            switch (obj.event) {
                case ""del"":
                    del(data.Id);//field Id 和 数据库表字段 Id 要一致
                    break;
            }
        });

        function batchDel() {
            okLayer.confirm(""确定要批量删除吗？"", function (index) {
                layer.close(index);
                let idsStr = okUtils.tableBatchCheck(table);
                if (idsStr) {
                    okUtils.ajax(""/Security/LogonLog/BatchDel"", ""get"", { idsStr: idsStr }, true).done(function (response) {
                        okUtils.tableSuccessMsg(response.message);
                    }).fail(function (error) {
                        console.log(error)
                    });
                }
            });
        }

        function del(id) {
            okLayer.confirm(""确定要删除吗？"", function () {
                okUtils.ajax(""/Security/LogonLog/Delete"", ""get"", { id: id }, true");
            WriteLiteral(@").done(function (response) {
                    okUtils.tableSuccessMsg(response.message);
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
#line 114 "G:\VS\VS框架\自写框架\FineAdmin\FineAdmin.Web\Areas\Security\Views\LogonLog\Index.cshtml"
Write(Html.TopToolBarHtml(ViewData["TopButtonList"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</script>\r\n<!-- 行工具栏模板 -->\r\n<script type=\"text/html\" id=\"operationTpl\">\r\n    ");
#nullable restore
#line 118 "G:\VS\VS框架\自写框架\FineAdmin\FineAdmin.Web\Areas\Security\Views\LogonLog\Index.cshtml"
Write(Html.RightToolBarHtml(ViewData["RightButtonList"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</script>");
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