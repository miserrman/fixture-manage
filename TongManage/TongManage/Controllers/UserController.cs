using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TongManage.Services;
using TongManage.Utils;
using TongManage.Models;

namespace TongManage.Controllers
{
    /// <summary>
    /// author: ZhouXing
    /// date: 2020/2/5
    /// </summary>
    public class UserController : Controller
    {
        static UserService userService = new UserService();
        /// <summary>
        /// 利用token返回用户信息
        /// </summary>
        /// <param></param>
        /// <returns></returns>
        [HttpGet]
        public string getInfoByToken()
        {
            string token = HttpContext.Request.Headers["Authorization"];
            TokenInfo tokenInfo = JSONHelper.JSONToObject<TokenInfo>(token);
            User user = new User();
            user.Name = tokenInfo.UserName;
            User result = userService.getInfoByToken(user);
            if (result == null)
            {
                return JSONHelper.ObjectToJSON(ResponseUtil.Fail());
            }
            else
            {
                return JSONHelper.ObjectToJSON(ResponseUtil.Ok(result));
            }
        }
        /// <summary>
        /// 用户注册
        /// </summary>
        /// <param name="body">用户类</param>
        /// <returns></returns>
        [HttpPost]
        public string register(string body)
        {
            User user= JSONHelper.JSONToObject<User>(body);
            User result = userService.register(user);
            return JSONHelper.ObjectToJSON(ResponseUtil.Ok(result));
        }

        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="passW">密码</param>
        /// <returns></returns>
        [HttpPost]
        public string login(string userName,string passW)
        {
            User user = new User();
            user.Name = userName;
            user.Password = passW;
            string result = userService.login(user);
            if(result!=null)
            {
                return JSONHelper.ObjectToJSON(ResponseUtil.Ok(result));
            }
            else
            {
                return JSONHelper.ObjectToJSON(ResponseUtil.Fail());
            }
        }

        /// <summary>
        /// 注销用户
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <returns></returns>
        [HttpDelete]
        public string delUser(string userName)
        {
            User user = new User();
            user.Name = userName;
            int result = userService.delUser(user);
            if(result==1)
                return JSONHelper.ObjectToJSON(ResponseUtil.Ok());
            else
                return JSONHelper.ObjectToJSON(ResponseUtil.Fail());
        }

        /// <summary>
        /// 修改用户信息
        /// </summary>
        /// <param name="id">用户id</param>
        /// <param name="body">用户类</param>
        /// <returns></returns>
        [HttpPut]
        public string setUserInfo(int id,string body)
        {
            User user = JSONHelper.JSONToObject<User>(body);
            user.Id = id;
            User result = userService.setUserInfo(user);
            if(result==null)
            {
                return JSONHelper.ObjectToJSON(ResponseUtil.Fail());
            }
            else
            {
                return JSONHelper.ObjectToJSON(ResponseUtil.Ok(result));
            }
        }

        /// <summary>
        /// 找回密码
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <returns></returns>
        [HttpPost]
        public string findPassW(string userName)
        {
            //通过邮箱找回
            //数据库需要进行更改，添加邮箱字段
            return null;
        }

        /// <summary>
        /// 获得用户列表信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public string getUserList()
        {
            string token = HttpContext.Request.Headers["Authorization"];//利用这个进行数据按部门进行隔离
            TokenInfo tokenInfo = JSONHelper.JSONToObject<TokenInfo>(token);
            int WorkcellId = tokenInfo.workCell;
            User user = new User();
            user.WorkcellId = WorkcellId;
            List<User> result = userService.getUserList(user);
            return JSONHelper.ObjectToJSON(ResponseUtil.Ok(result));
        }

        /// <summary>
        /// 获得用户信息
        /// </summary>
        /// <param name="id">用户id</param>
        /// <returns></returns>
        [HttpGet]
        public string getUserById(int id)
        {
            string token = HttpContext.Request.Headers["Authorization"];//利用这个进行数据按部门进行隔离
            TokenInfo tokenInfo = JSONHelper.JSONToObject<TokenInfo>(token);
            int WorkcellId = tokenInfo.workCell;
            User user = new User();
            user.WorkcellId = WorkcellId;
            user.Id = id;
            User result = userService.getUserById(user);
            if(result==null)
            {
                return JSONHelper.ObjectToJSON(ResponseUtil.Fail());
            }
            else
            {
                return JSONHelper.ObjectToJSON(ResponseUtil.Ok(result));
            }
        }

        /// <summary>
        /// 获得用户信息
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <returns></returns>
        [HttpGet]
        public string getUserByName(string userName)
        {
            string token = HttpContext.Request.Headers["Authorization"];//利用这个进行数据按部门进行隔离
            TokenInfo tokenInfo = JSONHelper.JSONToObject<TokenInfo>(token);
            int WorkcellId = tokenInfo.workCell;
            User user = new User();
            user.WorkcellId = WorkcellId;
            user.Name = userName;
            User result = userService.getUserByName(user);
            if (result == null)
            {
                return JSONHelper.ObjectToJSON(ResponseUtil.Fail());
            }
            else
            {
                return JSONHelper.ObjectToJSON(ResponseUtil.Ok(result));
            }
        }

        /// <summary>
        /// 获得用户信息
        /// </summary>
        /// <param name="workNo">工号</param>
        /// <returns></returns>
        [HttpGet]
        public string getUserByWorkNo(string workNo)
        {
            string token = HttpContext.Request.Headers["Authorization"];//利用这个进行数据按部门进行隔离
            TokenInfo tokenInfo = JSONHelper.JSONToObject<TokenInfo>(token);
            int WorkcellId = tokenInfo.workCell;
            User user = new User();
            user.WorkcellId = WorkcellId;
            user.WorkNo = workNo;
            //数据库的表需要进行更改才能完成此功能
            //添加workNo字段
            User result = userService.getUserByWorkNo(user);
            if (result == null)
            {
                return JSONHelper.ObjectToJSON(ResponseUtil.Fail());
            }
            else
            {
                return JSONHelper.ObjectToJSON(ResponseUtil.Ok(result));
            }
        }

        /// <summary>
        /// 获得用户信息
        /// </summary>
        /// <param name="workCell">部门id</param>
        /// <returns></returns>
        [HttpGet]
        public string getUserListByWorkCell(int workCell)
        {
            string token = HttpContext.Request.Headers["Authorization"];//利用这个进行数据按部门进行隔离
            TokenInfo tokenInfo = JSONHelper.JSONToObject<TokenInfo>(token);
            int WorkcellId = tokenInfo.workCell;
            User user = new User();
            user.WorkcellId = WorkcellId;
            user.WorkcellId = workCell;
            List<User> result = userService.getUserListByWorkCell(user);
            return JSONHelper.ObjectToJSON(ResponseUtil.Ok(result));
        }

    }
}
