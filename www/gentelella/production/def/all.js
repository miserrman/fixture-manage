defId = "define"
token = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJVc2VyTmFtZSI6InJvb3QiLCJVc2VyUHdkIjoiMTIzNDU2Iiwid29ya0NlbGwiOi0xfQ.FTE21vqoopvEJYm1LCBFpw8D647aWxw34BP6F7JH0S8"
ready = function() {
    
}

document.addEventListener("DOMContentLoaded", ready)
defAllUrl = "http://localhost:54755/Fixture/GetDefChart"

addCanBorrow = function(node) {
    let addCanBorrow = "<tr class=\"even pointer\"><td class=\"a-center\"><input type=\"checkbox\" class=\"flat\" name=\"table_records\"></td><td>121000040</td><td>真正的牛逼</td><td>121000210 <i class=\"success fa fa-long-arrow-up\"></i></td><td>John Blank L</td><td>Paid</td><td class=\"a-right a-right \">$100000</td><td class=\" last\"><a href=\"form2.html\" class=\"anode\">View</a></td></tr>"
    document.querySelector(stockId).innerHTML += addCanBorrow
}

addDefList = function() {
    $.ajax({
        type: "GET",
        url: defAllUrl,
        headers: {
            "Authorization": token
        },
        success: function() {
            
        }
    })
}