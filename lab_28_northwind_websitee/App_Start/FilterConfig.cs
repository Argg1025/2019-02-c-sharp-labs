using System.Web;
using System.Web.Mvc;

namespace lab_28_northwind_websitee
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
