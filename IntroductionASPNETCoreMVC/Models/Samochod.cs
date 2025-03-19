namespace IntroductionASPNETCoreMVC.Models
{
    public class Samochod
    {
        public int SamochodId { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Kolor { get; set; }
        public float PojSilnika { get; set; }
        public int RokProdukcji { get; set; }
        public int Przebieg { get; set; }
    }
}
