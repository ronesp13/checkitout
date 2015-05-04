using System.Web.Mvc;
using ProjectCS.Filters;

namespace ProjectCS
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new CurrentUserAttribute());
        }
    }
}
