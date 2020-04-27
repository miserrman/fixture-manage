userTokenUrl =  "http://localhost:54755/User/getInfoByToken"
jQuery.support.cors = true;
ready = function() {
    document.querySelector(".site_title").html = "工具夹管理系统"
    token = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJVc2VyTmFtZSI6InJvb3QiLCJVc2VyUHdkIjoiMTIzNDU2Iiwid29ya0NlbGwiOi0xfQ.FTE21vqoopvEJYm1LCBFpw8D647aWxw34BP6F7JH0S8"
    if (localStorage.getItem("userName") == null || localStorage.getItem("workcell") == null) {
        $.ajax({
            type: "GET",
            url: userTokenUrl,
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json',
                'Access-Control-Allow-Origin': '*',
                "Authorization": token
            },
            error: function(reason) {
                console.log(reason)
            },
            success: function(response) {
                let data = JSON.parse(response)
                let person = data.data
                console.log(person)
                $('#userName').html(person.Name)
                $('#userWorkCell').html(person.WorkcellName);
            }
        })
    }
    else {
        userName = localStorage.getItem("userName")
        workcell = localStorage.getItem("workcell")
        $('#userWorkCell').html(userName)
        $('#userName').html(workcell);
    }
}
document.addEventListener("DOMContentLoaded", ready)
