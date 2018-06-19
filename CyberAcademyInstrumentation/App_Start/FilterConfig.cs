using CyberAcademyInstrumentation.Helpers;
using System.Web;
using System.Web.Mvc;

namespace CyberAcademyInstrumentation
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());

            filters.Add(new DivideByZeroExceptionFilter());
        }
    }
}
