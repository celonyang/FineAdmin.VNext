var objOkTab = "";
layui.use(["element", "layer", "okUtils", "okTab", "okLayer", "okContextMenu", "okHoliday"], function () {
    var okUtils = layui.okUtils;
    var $ = layui.jquery;
    var layer = layui.layer;
    var okLayer = layui.okLayer;
    var okHoliday = layui.okHoliday;

    var okTab = layui.okTab({
        // 菜单请求路径
        url: "/Permissions/Module/GetModuleList",
        // 允许同时选项卡的个数
        openTabNum: 30,
        // 如果返回的结果和navs.json中的数据结构一致可省略这个方法
        parseData: function (data) {
            return data;
        }
    });
    objOkTab = okTab;

    /**
     * 左侧导航渲染完成之后的操作
     */
    okTab.render(function () {
        /**tab栏的鼠标右键事件**/
        $("body .ok-tab").okContextMenu({
            width: 'auto',
            itemHeight: 30,
            menu: [
                {
                    text: "定位所在页",
                    icon: "ok-icon ok-icon-location",
                    callback: function () {
                        okTab.positionTab();
                    }
                },
                {
                    text: "关闭当前页",
                    icon: "ok-icon ok-icon-roundclose",
                    callback: function () {
                        okTab.tabClose(1);
                    }
                },
                {
                    text: "关闭其他页",
                    icon: "ok-icon ok-icon-roundclose",
                    callback: function () {
                        okTab.tabClose(2);
                    }
                },
                {
                    text: "关闭所有页",
                    icon: "ok-icon ok-icon-roundclose",
                    callback: function () {

                        okTab.tabClose(3);
                    }
                }
            ]
        });
    });

    /**
     * 添加新窗口
     */
    $("body").on("click", "#navBar .layui-nav-item a, #userInfo a", function () {
        // 如果不存在子级
        if ($(this).siblings().length == 0) {
            okTab.tabAdd($(this));
        }
        // 关闭其他展开的二级标签
        $(this).parent("li").siblings().removeClass("layui-nav-itemed");
        if (!$(this).attr("lay-id")) {
            var topLevelEle = $(this).parents("li.layui-nav-item");
            var childs = $("#navBar > li > dl.layui-nav-child").not(topLevelEle.children("dl.layui-nav-child"));
            childs.removeAttr("style");
        }
    });

    /**
     * 左侧菜单展开动画
     */
    $("#navBar").on("click", ".layui-nav-item a", function () {
        if (!$(this).attr("lay-id")) {
            var superEle = $(this).parent();
            var ele = $(this).next('.layui-nav-child');
            var height = ele.height();
            ele.css({ "display": "block" });
            // 是否是展开状态
            if (superEle.is(".layui-nav-itemed")) {
                ele.height(0);
                ele.animate({ height: height + "px" }, function () {
                    ele.css({ height: "auto" });
                });
            } else {
                ele.animate({ height: 0 }, function () {
                    ele.removeAttr("style");
                });
            }
        }
    });

    /**
     * 左边菜单显隐功能
     */
    $(".ok-menu").click(function () {
        $(".layui-layout-admin").toggleClass("ok-left-hide");
        $(this).find("i").toggleClass("ok-menu-hide");
        localStorage.setItem("isResize", false);
        setTimeout(function () {
            localStorage.setItem("isResize", true);
        }, 1200);
    });

    /**
     * 移动端的处理事件
     */
    $("body").on("click", ".layui-layout-admin .ok-left a[data-url], .ok-make", function () {
        if ($(".layui-layout-admin").hasClass("ok-left-hide")) {
            $(".layui-layout-admin").removeClass("ok-left-hide");
            $(".ok-menu").find('i').removeClass("ok-menu-hide");
        }
    });

    /**
     * tab左右移动
     */
    $("body").on("click", ".okNavMove", function () {
        var moveId = $(this).attr("data-id");
        var that = this;
        okTab.navMove(moveId, that);
    });

    /**
     * 刷新当前tab页
     */
    $("body").on("click", ".ok-refresh", function () {
        okTab.refresh(this);
    });

    /**
     * 关闭tab页
     */
    $("body").on("click", "#tabAction a", function () {
        var num = $(this).attr("data-num");
        okTab.tabClose(num);
    });

    /**
     * 键盘的事件监听
     */
    $("body").on("keydown", function (event) {
        event = event || window.event || arguments.callee.caller.arguments[0];

        // 按 Esc
        if (event && event.keyCode === 27) {
            console.log("Esc");
            $("#fullScreen").children("i").eq(0).removeClass("layui-icon-screen-restore");
        }
        // 按 F11
        if (event && event.keyCode == 122) {
            console.log("F11");
            $("#fullScreen").children("i").eq(0).addClass("layui-icon-screen-restore");
        }
    });

	/**
	 * 全屏/退出全屏
	 */
    $("body").on("click", "#fullScreen", function () {
        if ($(this).children("i").hasClass("layui-icon-screen-restore")) {
            screenFun(2).then(function () {
                $("#fullScreen").children("i").eq(0).removeClass("layui-icon-screen-restore");
            });
        } else {
            screenFun(1).then(function () {
                $("#fullScreen").children("i").eq(0).addClass("layui-icon-screen-restore");
            });
        }
    });

    /**
     * 全屏和退出全屏的方法
     * @param num 1代表全屏 2代表退出全屏
     * @returns {Promise}
     */
    function screenFun(num) {
        num = num || 1;
        num = num * 1;
        var docElm = document.documentElement;

        switch (num) {
            case 1:
                if (docElm.requestFullscreen) {
                    docElm.requestFullscreen();
                } else if (docElm.mozRequestFullScreen) {
                    docElm.mozRequestFullScreen();
                } else if (docElm.webkitRequestFullScreen) {
                    docElm.webkitRequestFullScreen();
                } else if (docElm.msRequestFullscreen) {
                    docElm.msRequestFullscreen();
                }
                break;
            case 2:
                if (document.exitFullscreen) {
                    document.exitFullscreen();
                } else if (document.mozCancelFullScreen) {
                    document.mozCancelFullScreen();
                } else if (document.webkitCancelFullScreen) {
                    document.webkitCancelFullScreen();
                } else if (document.msExitFullscreen) {
                    document.msExitFullscreen();
                }
                break;
        }

        return new Promise(function (res, rej) {
            res("返回值");
        });
    }

    /**
     * 系统公告
     */
    $(document).on("click", "#notice", noticeFun);

    function noticeFun() {
        var srcWidth = okUtils.getBodyWidth();
        layer.open({
            type: 0, title: "系统公告", btn: "我知道啦", btnAlign: 'c', content: getContent(),
        });
    }

    function getContent() {
        let content = "";
        content = "版权声明：<br/>" +
            "Zl.WebApp说明：作者兴趣爱好将FineAdmin.Mvc移植到asp.net core3.1取名Zl.WebApp,发挥core版本的优势。<br/>" +
            "ok-admin 和 FineAdmin.Mvc都使用GPL-3.0开源协议，个人<span style='color:#5cb85c'>免费使用</span>，商用请联系二位作者,本人无需授权<br/>" +
            "作者：ZhangLu (我自己)<br/>" +
            "Zl.WebApp开源地址：<a style='color:#ff5722;' target='_blank' href='https://gitee.com/Zl819058637/Zl.WebApp.git'><span>Zl.WebApp</span></a>";
        return content;
    }

    /**
     * 捐赠作者
     */
    $(".layui-footer button.donate").click(function () {
        layer.tab({
            area: ["330px", "350px"],
            tab: [{
                title: "支付宝",
                content: "<img src='/images/zfb.jpg' width='200' height='300' style='margin-left: 60px'>"
            }, {
                title: "微信",
                content: "<img src='/images/wx.png' width='200' height='300' style='margin-left: 60px'>"
            }]
        });
    });

    /**
     * QQ群交流
     */
    $("body").on("click", ".layui-footer button.communication,#noticeQQ", function () {
        layer.tab({
            area: ["330px", "350px"],
            tab: [{
                title: "QQ",
                content: "<img src='/images/qq.jpg' width='200' height='300' style='margin-left: 60px'>"
            }]
        });
    });

    /**
     * 弹窗皮肤
     */
    $("#alertSkin").click(function () {
        okLayer.open("皮肤动画", "/alertSkin.html", "50%", "45%", function (layero) {
        }, function () {
        });
    });

    console.log("        __                         .___      .__        \n" +
        "  ____ |  | __         _____     __| _/_____ |__| ____  \n" +
        " /  _ \\|  |/ /  ______ \\__  \\   / __ |/     \\|  |/    \\ \n" +
        "(  <_> )    <  /_____/  / __ \\_/ /_/ |  Y Y  \\  |   |  \\\n" +
        " \\____/|__|_ \\         (____  /\\____ |__|_|  /__|___|  /\n" +
        "            \\/              \\/      \\/     \\/        \\/\n" +
        "" +
        "版本：v2.0\n" +
        "作者：bobi\n" +
        "邮箱：bobi1234@foxmail.com\n" +
        "企鹅：833539807\n" +
        "描述：一个很赞的，扁平化风格的，响应式布局的后台管理模版，旨为后端程序员减压！\n" +
        "版权说明：项目使用GPL-3.0开源协议，个人免费使用，商用请获取授权\n" +
        "码云：https://gitee.com/bobi1234/ok-admin");
    console.log(" _____ _               _       _           _       \n" +
        "|  ___(_)_ __   ___   / \\   __| |_ __ ___ (_)_ __  \n" +
        "| |_  | | '_ \\ / _ \\ / _ \\ / _` | '_ ` _ \\| | '_ \\ \n" +
        "|  _| | | | | |  __// ___ \\ (_| | | | | | | | | | |\n" +
        "|_|   |_|_| |_|\\___/_/   \\_\\__,_|_| |_| |_|_|_| |_|\n" +
        "作者：Liu_Cabbage\n" +
        "邮箱：178899573@qq.com\n" +
        "企鹅：178899573\n" +
        "描述：使用ok-admin+ASP.NET MVC搭建的通用权限后台管理系统。\n" +
        "版权说明：项目使用GPL-3.0开源协议，个人免费使用，商用请获取授权\n" +
        "码云：https://gitee.com/Liu_Cabbage/FineAdmin.Mvc");
    console.log(" _____ _               _       _           _       \n" +
        "|  ___(_)_ __   ___   / \\   __| |_ __ ___ (_)_ __  \n" +
        "| |_  | | '_ \\ / _ \\ / _ \\ / _` | '_ ` _ \\| | '_ \\ \n" +
        "|  _| | | | | |  __// ___ \\ (_| | | | | | | | | | |\n" +
        "|_|   |_|_| |_|\\___/_/   \\_\\__,_|_| |_| |_|_|_| |_|\n" +
        "移植作者：ZhangLu\n" +
        "邮箱：819058637@qq.com\n" +
        "企鹅：819058637\n" +
        "描述：使用ok-admin+ASP.NET core3搭建的通用权限后台管理系统。(移植FineAdmin.Mvc)\n" +
        "版权说明：楼上授权就行\n" +
        "码云：https://gitee.com/Zl819058637/Zl.WebApp.git");
});
