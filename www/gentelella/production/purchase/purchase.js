purchaseUrl = "http://localhost:54755/Fixture/PurchaseEntity?body=" 
typeSelectId = "#typeSelect"
token = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJVc2VyTmFtZSI6InJvb3QiLCJVc2VyUHdkIjoiMTIzNDU2Iiwid29ya0NlbGwiOi0xfQ.FTE21vqoopvEJYm1LCBFpw8D647aWxw34BP6F7JH0S8"

check = function() {
    return true
}
window.onload = function() {
    submit = document.querySelector("#purchase")
    submit.addEventListener("click", function() {
        if (check) {
            $.ajax({
                type: "POST",
                url: purchaseUrl + JSON.stringify(dataMap),
                headers: {
                    "Authorization": token
                },
                error: function(reason) {
                    console.log(reason)
                },
                success: function(response) {
                    
                }
            })
        }
    })
}

dataMap = {
    "billNo": "2423423",
    "defId": 1
}