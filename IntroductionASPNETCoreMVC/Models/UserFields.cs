using System.ComponentModel.DataAnnotations;

namespace IntroductionASPNETCoreMVC.Models
{
    public class UserFields
    {
        [Required(ErrorMessage ="Podaj imię")]
        public string Imie {  get; set; }
        [Required(ErrorMessage = "Podaj nazwisko")]
        public string Nazwisko { get; set; }
        [Required(ErrorMessage = "Podaj Kraj")]
        public string Kraj { get; set; }
        public string Jezyk { get; set; }
    }
}
