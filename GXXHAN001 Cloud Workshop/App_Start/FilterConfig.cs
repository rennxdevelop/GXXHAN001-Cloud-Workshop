using System.Web;
using System.Web.Mvc;

namespace GXXHAN001_Cloud_Workshop
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
