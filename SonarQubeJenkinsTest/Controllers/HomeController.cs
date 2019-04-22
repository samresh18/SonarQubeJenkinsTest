using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SonarQubeJenkinsTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string i = "Test";
            string UU = "";
            int target = -5;
            int num = 3;
            var v = true;

            if (!v)
            {
                num = 4;
            }

            target = -num;  // Noncompliant; target = -3. Is that really what's meant?
            target = +num; // Noncompliant; target = 3
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


    }

    abstract class Base
    {
        public Base() // Noncompliant, should be private or protected
        {
            //...
        }
    }
}