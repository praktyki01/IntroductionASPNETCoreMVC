using Microsoft.AspNetCore.Mvc;

namespace IntroductionASPNETCoreMVC.Controllers
{
    public class MultipleInputsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult IndexOdczyt(string sklep, string[] produkt)
        {
            return View();
        }
        public IActionResult Kalkulator()
        {
            return View();
        }
        public IActionResult KalkulatorJS()
        {
            return View();
        }
        public IActionResult PoleTrojkataJS()
        {
            return View();
        }
    }
}
