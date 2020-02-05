using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


/// <summary>
/// author: ZhouXing
/// date: 2020/2/1
/// </summary>

namespace TongManage.Utils
{
    //401, "参数不对"
    //402, "参数值不对"
    //501, "请登录"
    //502, "系统内部错误"
    //503, "业务不支持"
    //504, "更新数据已经失效"
    //505, "更新数据失败"
    //506, "无操作权限"
    public class ResponseUtil
    {
        public static Object Ok()
        {
            Dictionary<String, Object> obj = new Dictionary<String, Object>(4);
            obj.Add("errno", 0);
            obj.Add("errmsg", "成功");
            return obj;
        }

        public static Object Ok(Object data)
        {
            Dictionary<String, Object> obj = new Dictionary<String, Object>(4);
            obj.Add("errno", 0);
            obj.Add("errmsg", "成功");
            obj.Add("data", data);
            return obj;
        }

        public static Object Fail()
        {
            Dictionary<String, Object> obj = new Dictionary<String, Object>(4);
            obj.Add("errno", -1);
            obj.Add("errmsg", "错误");
            return obj;
        }

        public static Object Fail(int errno, String errmsg)
        {
            Dictionary<String, Object> obj = new Dictionary<String, Object>(4);
            obj.Add("errno", errno);
            obj.Add("errmsg", errmsg);
            return obj;
        }
    }
}