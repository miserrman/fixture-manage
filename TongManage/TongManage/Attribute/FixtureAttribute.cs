using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
}