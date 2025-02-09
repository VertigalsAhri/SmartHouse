using System;
using SmartHouse.Interfejs;
namespace SmartHouse.Klase
{
    public class GaražnaVrata
    {
        public string Ime { get; set; }
        public string Opis { get; set; }
        public bool IsOtvorena { get; private set; }

        public GaražnaVrata(string name)
        {
            Ime = name;
            Opis = "Garažna vrata sa automatskim otvaranjem";
            IsOtvorena = false;
        }

        public void Otvori()
        {
            if (!IsOtvorena)
            {
                IsOtvorena = true;
                Console.WriteLine("Garažna vrata se otvaraju...");
            }
            else
            {
                Console.WriteLine("Garažna vrata su već otvorena!");
            }
        }

        public void Zatvori()
        {
            if (IsOtvorena)
            {
                IsOtvorena = false;
                Console.WriteLine("Garažna vrata se zatvaraju...");
            }
            else
            {
                Console.WriteLine("Garažna vrata su već zatvorena!");
            }
        }
    }
}
