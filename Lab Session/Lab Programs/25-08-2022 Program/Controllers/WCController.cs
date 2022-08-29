using Microsoft.AspNetCore.Mvc;
using WebCalculator.Models;

namespace WebCalculator.Controllers
{
    public class WCController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(WebCalc wc)
        {
            if(wc.calc == "Addition")
            {
                wc.Result = wc.FirstNumber + wc.SecondNumber;
            }
            else if(wc.calc == "Subtraction")
            {
                wc.Result = wc.FirstNumber - wc.SecondNumber;
            }
            else if (wc.calc == "Multiplication")
            {
                wc.Result = wc.FirstNumber * wc.SecondNumber;
            }
            else if (wc.calc == "Division")
            {
                wc.Result = wc.FirstNumber / wc.SecondNumber;
            }
            else
            {
                wc.Result = 666;
            }
            return View(wc);
        }

    }
}
