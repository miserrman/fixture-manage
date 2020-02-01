using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TongManage.Utils;
using JWT;

namespace TongManage.Controllers
{
    public class LoginController : ApiController
    {
        [HttpGet]
        public string login()
        {

            //生成Token
            TokenInfo tokenInfo = new TokenInfo();
            tokenInfo.Pwd = "password";
            tokenInfo.UserName = "tel";
            string token = TokenHelper.GenToken(tokenInfo);
            return "登录成功";
        }
    }
}
