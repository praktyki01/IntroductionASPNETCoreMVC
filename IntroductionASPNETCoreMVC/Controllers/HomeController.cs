using IntroductionASPNETCoreMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System.Diagnostics;

namespace IntroductionASPNETCoreMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Zmienne()
        {
            return View();
        }
        public IActionResult Formularz1()
        {
            return View();
        }

        public IActionResult Formularz1Odczyt(string imie, string nazwisko )
        {
            ViewBag.imie = imie;
            ViewBag.nazwisko = nazwisko;
            return View();
        }
        public IActionResult Formularz2()
        {
            return View();
        }
        public IActionResult Formularz2Odczyt(string imie, string nazwisko,
            string kraj, string fav_language)
        {
            ViewBag.imie = imie;
            ViewBag.nazwisko = nazwisko;
            if (kraj == "1") 
            {
                ViewBag.kraj = "Afganistan";
            }
            if (kraj == "2")
            {
                ViewBag.kraj = "Neuru";
            }
            if (kraj == "3")
            {
                ViewBag.kraj = "Burkina Faso";
            }
            if (kraj == "4")
            {
                ViewBag.kraj = "Czechy";
            }
            if (kraj == "5")
            {
                ViewBag.kraj = "Polska";
            }
            if (kraj == "6")
            {
                ViewBag.kraj = "UK";
            }
            ViewBag.fav_language = fav_language;

            return View();
        }
        public IActionResult Formularz3()
        {
            return View();
        }
        public IActionResult Formularz3Odczyt(UserFields daneUzytkownika)
        {
            ViewBag.imie = daneUzytkownika.Imie;
            ViewBag.nazwisko = daneUzytkownika.Nazwisko;
            if (daneUzytkownika.Kraj == "1")
            {
                ViewBag.kraj = "Afganistan";
            }
            if (daneUzytkownika.Kraj == "2")
            {
                ViewBag.kraj = "Neuru";
            }
            if (daneUzytkownika.Kraj    == "3")
            {
                ViewBag.kraj = "Burkina Faso";
            }
            if (daneUzytkownika.Kraj == "4")
            {
                ViewBag.kraj = "Czechy";
            }
            if (daneUzytkownika.Kraj == "5")
            {
                ViewBag.kraj = "Polska";
            }
            if (daneUzytkownika.Kraj == "6")
            {
                ViewBag.kraj = "UK";
            }
            ViewBag.fav_language = daneUzytkownika.Jezyk;

            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
