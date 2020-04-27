const createDefUrl = 
token = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJVc2VyTmFtZSI6InJvb3QiLCJVc2VyUHdkIjoiMTIzNDU2Iiwid29ya0NlbGwiOi0xfQ.FTE21vqoopvEJYm1LCBFpw8D647aWxw34BP6F7JH0S8"

defMap = {
    "workcell": 0,
    "familyId": 0,
    "name": "",
    "code": "",
    "model": "",
    "partNo": "",
    "userdFor": "",
    "upl": 0,
    "ownerId": 0,
    "remark": "",
    "pmPeriod": "",
    "recOn": "",
    "recBy": "",
    "editOn": "",
    "editBy": ""
}

submit = function() {
    node = document.querySelector("#createDef")
    let local = localStorage
    node.addEventListener("click", function() {
        
        if (getInfoValue()) {
            defMap["workcell"] = 1
            defMap["recOn"] = "2019-3-25 12:30:23"
            data = JSON.stringify(defMap)
            console.log(data)
            $.ajax({
                type: "POST",
                url: "http://localhost:54755/Fixture/CreateDef?body=" + data,
                headers: {
                    "Authorization": token
                },
                error: function(reason) {
                    console.log(reason)
                },
                success: function(response) {
                    console.log(response)
                }
            })
        }
    })
}
getInfoValue = function() {
    let valueArr = []
    let divNode = document.querySelector("#info").querySelectorAll(".form-control")
    console.log(divNode.length)
    for (let i = 0; i < divNode.length; i++) {
        let node = divNode[i]
        if (node != null && node.value == "") {
            return false
        }
        if (node != null)
            valueArr.push(node.value)
    } 
    let eliminte = ["workcell", "recOn", "editOn"]
    let keys = []
    for (key in defMap) {
        keys.push(key)
    }
    let j = 0
    for (let i = 0; i < keys.length; i++) {
        if (keys[i] in eliminte)
            continue;
        else {
            defMap[keys[i]] = valueArr[j]
            j++;
        }
    }
    return true
}
window.onload = function() {
    submit()
}
