ready = function() {
    let node = document.querySelector("#sidebar")
    // let nodeChild = node.childNodes
    // console.log(nodeChild[1])
    // node.removeChild(nodeChild[1])
    node.innerHTML += sideBarMap["inoutStock"]
}

document.addEventListener("DOMContentLoaded", ready)
identity = ""

let sideBarMap = {
    "inoutStock": "<li><a><i class=\"fa fa-home\"></i> 采购入库 <span class=\"fa fa-chevron-down\"></span></a><ul class=\"nav child_menu\"><li><a href=\"form.html\">采购申请</a></li><li><a href=\"index2.html\">Dashboard2</a></li><li><a href=\"index3.html\">Dashboard3</a></li></ul></li>"
}