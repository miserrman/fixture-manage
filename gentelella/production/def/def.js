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
    "recBy": 0,
    "editOn": "",
    "editBy": 0
}

submit = function() {
    node = document.querySelector("#createDef")
    node.addEventListener("click", function() {
        if (getInfoValue()) {
            data = JSON.stringify(defMap)
            $.ajax({
                
            })
        }
    })
}
getInfoValue = function() {
    let valueArr = []
    let divNode = document.querySelector("#info").querySelectorAll("div")
    for (let i = 0; i < divNode.length; i++) {
        let node = divNode[i].querySelector(".form-control")
        if (node != null && node.value == "") {
            console.log(i)
            return false
        }
        if (node != null)
            valueArr.push(node.value)
    }
    console.log(valueArr)
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
