using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TongManage.Utils;

namespace TongManage.Attribute
{
    public class FixtureAttribute : AuthorizeAttribute
    {
        public static string ipAdress;

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            return true;
        }
    }

    //此特性是约束自定义特性的使用方式。这里约束只能在方法上使用此特性
    [AttributeUsage(AttributeTargets.Method)]
    public class CheckAttribute : System.Attribute
    {
        public CheckAttribute(int PermissionsID)
        {
            this.PermissionsID = PermissionsID;
        }
        public int PermissionsID { get; set; }
    }

    public class CustomerFilterAttribute:ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //获取当前方法上的所有自定义特性，false表示不递归查找
            object[] objs = filterContext.ActionDescriptor.GetCustomAttributes(false);
            //循环所有特性
            foreach (object item in objs)
            {
                //如果此特性是我需要的（CheckAttribute）特性
                if (item is CheckAttribute)
                {
                    //强制转换成特性的对象（特性就是一个比较特殊的类，本质上还是类）
                    CheckAttribute attr = (CheckAttribute)item;
                    //下面可以对特性的数据做一些校验，比如：校验此方法需要什么样的权限才可以访问,校验请求端的IP地址是否在白名单等
                    if (attr.PermissionsID == 1)//第一级权限,判断是否登录即可
                    {
                        //此段是模拟登录，携带token，测试用的。
                        /*
                        TokenInfo tokenInfo = new TokenInfo();
                        tokenInfo.Pwd = "password";
                        tokenInfo.UserName = "tel";
                        string token = TokenHelper.GenToken(tokenInfo);
                        filterContext.HttpContext.Request.Headers.Add("Authorization", token);
                        */
                        //如果此方法有1号权限则跳转提示页面，这里判断的逻辑等，都看业务的需求！！
                        if (filterContext.HttpContext.Request.Headers["Authorization"] != null)
                        {
                            if (!TokenHelper.DecodeToken())
                            {
                                var _response = filterContext.HttpContext.Response;
                                byte[] ss = System.Text.Encoding.UTF8.GetBytes(JSONHelper.ObjectToJSON(ResponseUtil.Fail(501,"请登录")));
                                _response.OutputStream.Write(ss, 0, ss.Length);
                                _response.ContentType = "text/plain";
                                _response.End();
                            }
                        }
                        else
                        {
                            var _response = filterContext.HttpContext.Response;
                            //_response.Redirect("~/Error.html");
                            byte[] ss = System.Text.Encoding.UTF8.GetBytes(JSONHelper.ObjectToJSON(ResponseUtil.Fail(501, "请登录")));
                            _response.OutputStream.Write(ss, 0, ss.Length);
                            _response.ContentType = "text/plain";
                            _response.End();
                        }
                    }
                    else if(attr.PermissionsID==2)//第二级权限
                    {
                        //待补充

                    }
                    else if(attr.PermissionsID==3)//第三级权限
                    {
                        //待补充
                    }
                    else if(attr.PermissionsID==4)//第四级权限
                    {
                        //待补充
                    }
                }
            }
        }
    }
}