ready = function() {
    mentionNode = document.querySelector("#mention").querySelectorAll("p")
    hideAllNode(mentionNode)
    submitEvent(mentionNode)
}
loginUrl = "http://localhost:54755/User/login"

document.addEventListener("DOMContentLoaded", ready)

hideAllNode = function(mentionNode) {
    for (let i = 0; i < mentionNode.length; i++)
        mentionNode[i].style.display = "None"
}

setCookie = function(n, v, day) {
    name = n
    value = v
    let exp = new Date()
    exp.setDate(exp.getDate() + day * 24 * 60 * 60)
    document.cookie = name + "=" + escape(value) + ";expires=" + exp.toGMTString();
}

jQuery.support.cors = true;
submitEvent = function(mention) {
    button = document.querySelector("#submit");
    let d = document
    button.addEventListener("click", function() {
        name = d.querySelector("#username").value
        passw = d.querySelector("#password").value
        if (name == "") {
            hideAllNode(mention)
            mention[0].style.display= ""
        }
        else if (passw == "") {
            hideAllNode(mention)
            mention[1].style.display= ""
        }
        else {
            l = loginUrl + "?userName=" + name + "&passW=" + passw
            $.ajax({
                type: "POST",
                url: l,
                headers: {
                    'Accept': 'application/json',
                    'Content-Type': 'application/json',
                    'Access-Control-Allow-Origin': '*'
                },
                error: function(data) {
                    console.log(data)
                },
                success: function(response) {
                    let data = JSON.parse(response)
                    console.log(data.errno)
                    if (data.errno == 0) {
                        console.log("成功")
                        d.cookie = "csdcdsc"
                        setCookie("name", data.data, 3)
                    }
                }
            })            
        }
    })
}
