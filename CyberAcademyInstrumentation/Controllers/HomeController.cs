using CyberAcademyInstrumentation.Helpers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CyberAcademyInstrumentation.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            int sam = 0;
            try
            {
               
                decimal dc = 5 / sam;
            }
            catch (Exception)
            {

                Debug.WriteLineIf((sam == 0), "Failed to calculate");
                Trace.WriteLine("This is for production");
            }




            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }


        [DivideByZeroExceptionFilter]
        public ActionResult Contact()
        {
            try
            {
            int n = 0;
            decimal p = 5 / n;
            }
            catch (DivideByZeroException)
            {

                throw new DivideByZeroException();
            }
          


            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}