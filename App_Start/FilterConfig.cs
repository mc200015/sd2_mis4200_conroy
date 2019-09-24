using System.Web;
using System.Web.Mvc;

namespace sd2_mis4200_conroy
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
