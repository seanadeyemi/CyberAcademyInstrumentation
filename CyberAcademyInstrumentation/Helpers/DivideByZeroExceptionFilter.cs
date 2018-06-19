using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CyberAcademyInstrumentation.Helpers
{

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, Inherited = true, AllowMultiple = true)]
    public class DivideByZeroExceptionFilter : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
           if(!filterContext.ExceptionHandled && filterContext.Exception is DivideByZeroException)
            {
                filterContext.Result = new RedirectResult("/Errors/ErrorPage.html");
                filterContext.HttpContext.Trace.Write("");
                var error = $" Route: {filterContext.RequestContext.RouteData}, Message: {filterContext.Exception.Message} ";

                Trace.WriteLine(error);

                filterContext.ExceptionHandled = true;
            }
        }
    }
}