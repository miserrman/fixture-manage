ready = function() {
    let node = document.querySelector("#sidebar")
    // let nodeChild = node.childNodes
    // console.log(nodeChild[1])
    // node.removeChild(nodeChild[1])
    for (var key in sideBarMap)
        node.innerHTML += sideBarMap[key]
}

document.addEventListener("DOMContentLoaded", ready)
identity = ""

let sideBarMap = {
    "purchaseStock": "<li><a><i class=\"fa fa-home\"></i> 采购入库 <span class=\"fa fa-chevron-down\"></span></a><ul class=\"nav child_menu\"><li><a href=\"form.html\">采购申请</a></li><li><a href=\"index2.html\">Dashboard2</a></li><li><a href=\"index3.html\">Dashboard3</a></li></ul></li>",
    "inoutStockRequest": "<li><a><i class=\"fa fa-edit\"></i> 进出库 <span class=\"fa fa-chevron-down\"></span></a><ul class=\"nav child_menu\"><li><a href=\"form.html\">General Form</a></li></ul></li>",
    "repairRequest": "<li><a><i class=\"fa fa-desktop\"></i> 申请报修 <span class=\"fa fa-chevron-down\"></span></a><ul class=\"nav child_menu\"><li><a href=\"general_elements.html\">报修申请</a></li><li><a href=\"media_gallery.html\">已结束的报修申请</a></li><li><a href=\"typography.html\">待处理的报修申请</a></li><li><a href=\"icons.html\">Icons</a></li><li><a href=\"glyphicons.html\">Glyphicons</a></li><li><a href=\"widgets.html\">Widgets</a></li><li><a href=\"invoice.html\">Invoice</a></li><li><a href=\"inbox.html\">Inbox</a></li><li><a href=\"calendar.html\">Calendar</a></li></ul></li>",
    "repairList": "<li><a><i class=\"fa fa-desktop\"></i> 报修处理 <span class=\"fa fa-chevron-down\"></span></a><ul class=\"nav child_menu\"><li><a href=\"general_elements.html\">报修申请</a></li><li><a href=\"media_gallery.html\">已结束的报修申请</a></li><li><a href=\"typography.html\">待处理的报修申请</a></li><li><a href=\"icons.html\">Icons</a></li><li><a href=\"glyphicons.html\">Glyphicons</a></li><li><a href=\"widgets.html\">Widgets</a></li><li><a href=\"invoice.html\">Invoice</a></li><li><a href=\"inbox.html\">Inbox</a></li><li><a href=\"calendar.html\">Calendar</a></li></ul></li>",
    "discardRequest": "<li><a><i class=\"fa fa-desktop\"></i> 报废申请 <span class=\"fa fa-chevron-down\"></span></a><ul class=\"nav child_menu\"><li><a href=\"general_elements.html\">报修申请</a></li><li><a href=\"media_gallery.html\">已结束的报修申请</a></li><li><a href=\"typography.html\">待处理的报修申请</a></li><li><a href=\"icons.html\">Icons</a></li><li><a href=\"glyphicons.html\">Glyphicons</a></li><li><a href=\"widgets.html\">Widgets</a></li><li><a href=\"invoice.html\">Invoice</a></li><li><a href=\"inbox.html\">Inbox</a></li><li><a href=\"calendar.html\">Calendar</a></li></ul></li>",
    "discardList": "<li><a><i class=\"fa fa-desktop\"></i> 报修 <span class=\"fa fa-chevron-down\"></span></a><ul class=\"nav child_menu\"><li><a href=\"general_elements.html\">报修申请</a></li><li><a href=\"media_gallery.html\">已结束的报修申请</a></li><li><a href=\"typography.html\">待处理的报修申请</a></li><li><a href=\"icons.html\">Icons</a></li><li><a href=\"glyphicons.html\">Glyphicons</a></li><li><a href=\"widgets.html\">Widgets</a></li><li><a href=\"invoice.html\">Invoice</a></li><li><a href=\"inbox.html\">Inbox</a></li><li><a href=\"calendar.html\">Calendar</a></li></ul></li>",
    "fixtureList": "<li><a><i class=\"fa fa-bar-chart-o\"></i> 工具夹信息 <span class=\"fa fa-chevron-down\"></span></a><ul class=\"nav child_menu\"><li><a href=\"chartjs.html\">Chart JS</a></li><li><a href=\"chartjs2.html\">Chart JS2</a></li><li><a href=\"morisjs.html\">Moris JS</a></li><li><a href=\"echarts.html\">ECharts</a></li><li><a href=\"other_charts.html\">Other Charts</a></li></ul></li>",
    "updateFixture": "<li><a><i class=\"fa fa-bar-chart-o\"></i> 工具夹信息 <span class=\"fa fa-chevron-down\"></span></a><ul class=\"nav child_menu\"><li><a href=\"chartjs.html\">Chart JS</a></li><li><a href=\"chartjs2.html\">Chart JS2</a></li><li><a href=\"morisjs.html\">Moris JS</a></li><li><a href=\"echarts.html\">ECharts</a></li><li><a href=\"other_charts.html\">Other Charts</a></li></ul></li>"
}

let peopleLevel = {
    0: ["inoutStockRequest", "repairRequest"],
    1: ["purchaseStock", "fixtureList", ""]
}
