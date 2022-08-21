using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCtraining.Models;

namespace MVCtraining.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(SimpleCalc sc)
        {
            int num = sc.firNUmber;
            int rev = 0;
            
            for (; num > 0;) 
            {
                int rem = num % 10;
                rev = rev * 10 + rem ;
                num = num / 10;
            }
            if(rev == sc.firNUmber)
            {
                sc.Result = "It is a Palindrome";
            }
            else
            {
                sc.Result = "It is not a Palindrome";
            }
            return View(sc);
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
}