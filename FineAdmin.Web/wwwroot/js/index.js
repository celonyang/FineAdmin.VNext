layui.use(["okSweetAlert2"], function() {
	okSweetAlert2 = layui.okSweetAlert2;
	var $ = layui.$;
	setInterval(function(){
		$(".now-time")[0].innerHTML = nowDateTim()
	},1000);
})

//多页面选项卡配置项回调方法
function reloadPage(pageTabs) {
	okSweetAlert2.fire({
		type: "warning",
		title: "刷新页面后生效",
		text: "多页面选项卡功能已" + (pageTabs ? '开启' : '关闭') + "，是否现在自动刷新？",
		showCancelButton: true,
		confirmButtonColor: "#3085d6",
		cancelButtonColor: "#d33",
		confirmButtonText: "自动刷新",
		cancelButtonText: "手动刷新"
	}).then((result) => {
		if (result.value) {
			window.location.reload()
		}
	});
}

//当前时间
function nowDateTim() {
	var now = new Date();
	var year = now.getFullYear(); //得到年份
	var month = now.getMonth()+1;//得到月份
	var day = now.getDate();//得到日期
	var hour= now.getHours();//得到小时数
	var minute= now.getMinutes();//得到分钟数
	var second= now.getSeconds();//得到秒数
	console.log(PrefixInteger(second))
	return year + "年" + PrefixInteger(month) + "月" + PrefixInteger(day) + "日 " 
			+ PrefixInteger(hour) + ":" + PrefixInteger(minute) + ":" + PrefixInteger(second)
}

// 前置补0 方法 月、日、时、分、秒 在 1-9时，补0
function PrefixInteger(num, length = 2) {
	return (Array(length).join('0') + num).slice(-length);
}