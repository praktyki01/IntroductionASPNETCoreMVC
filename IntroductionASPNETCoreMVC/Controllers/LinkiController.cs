using Microsoft.AspNetCore.Mvc;
using System.Drawing;

namespace IntroductionASPNETCoreMVC.Controllers
{
    public class LinkiController : Controller
    {
        public IActionResult Index(string link1, string zdjecie1, string nazwa1,
            string link2, string zdjecie2, string nazwa2,
            string link3, string zdjecie3, string nazwa3,
            string link4, string zdjecie4, string nazwa4)
        {
            ViewBag.link1 = link1;
            ViewBag.zdjecie1 = zdjecie1;
            ViewBag.nazwa1 = nazwa1;

            ViewBag.link2 = link2;
            ViewBag.zdjecie2 = zdjecie2;
            ViewBag.nazwa2 = nazwa2;
            
            ViewBag.link3 = link3;
            ViewBag.zdjecie3 = zdjecie3;
            ViewBag.nazwa3 = nazwa3;

            ViewBag.link4 = link4;
            ViewBag.zdjecie4 = zdjecie4;
            ViewBag.nazwa4 = nazwa4;

            return View();
        }
    }
}
