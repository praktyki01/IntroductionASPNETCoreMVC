using Microsoft.AspNetCore.Mvc;

namespace IntroductionASPNETCoreMVC.Controllers
{
    public class PolaFigurController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult PoleKwadratu(int bok)
        {
            //jeżeli bok będzie miało wartość 0 lub mniej nie wykonujemy obliczenia
            if (bok > 0)
            {
                int pole = bok * bok;
                ViewBag.PoleKwadratu = pole;
            }
            return View();
        }
        public IActionResult PoleTrojkata(float bok, float wysokosc)
        {
            if (bok > 0 && wysokosc>0)
            {
                float pole = bok * wysokosc * 0.5f;
                ViewBag.PoleTrojkata = pole;
            }
            return View();
        }

        //prostokąt
        //trójkąt
        //trapez
        //romb
        //koło
    }
}
