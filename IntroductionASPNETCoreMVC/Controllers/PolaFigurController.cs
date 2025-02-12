using Microsoft.AspNetCore.Mvc;

namespace IntroductionASPNETCoreMVC.Controllers
{
    public class PolaFigurController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult PoleKwadratu()
        {
            return View();
        }
    }
}
