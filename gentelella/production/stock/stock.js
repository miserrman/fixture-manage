let stockId = "#stockTable"
stockList = [
    {"code": "232323", "kind": "csdcsd"}
]
ready = function() {
    node = document.querySelectorAll(stockId)
    addCanBorrow(node)
    addCanBorrow(node)
    let aNode = document.querySelectorAll(".anode")
    for (let i = 0; i < aNode.length; i++) {
        aNode[i].addEventListener("click", function() {
            localStorage.setItem("stockCode", stockList[i]["code"])
            localStorage.setItem("stockKind", stockList[i]["kind"])
        })
    }
}

document.addEventListener("DOMContentLoaded", ready)
addCanBorrow = function(node) {
    let addCanBorrow = "<tr class=\"even pointer\"><td class=\"a-center\"><input type=\"checkbox\" class=\"flat\" name=\"table_records\"></td><td>121000040</td><td>真正的牛逼</td><td>121000210 <i class=\"success fa fa-long-arrow-up\"></i></td><td>John Blank L</td><td>Paid</td><td class=\"a-right a-right \">$100000</td><td class=\" last\"><a href=\"form2.html\" class=\"anode\">View</a></td></tr>"
    document.querySelector(stockId).innerHTML += addCanBorrow
}
