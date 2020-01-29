using System.Web;
using System.Web.Mvc;
using TongManage.Attribute;

namespace TongManage
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new FixtureAttribute());
        }
    }
}
