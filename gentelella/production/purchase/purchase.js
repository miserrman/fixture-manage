window.onload = function() {
    button = document.querySelector("#purchase")
    button.onclick = function() {
        for (var key in dataMap) {
            let s = "#" + key
            input = document.querySelector(s)
            dataMap[key] = input.value
        }
    }
}

dataMap = {
    "name": "",
    "workcell": "",
    "fixtureType": "",
    "count": "",
    "seq": "",
    "picUrl": ""
}