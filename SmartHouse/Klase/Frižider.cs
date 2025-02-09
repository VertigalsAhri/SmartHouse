using SmartHouse.Interfejs;
namespace SmartHouse.Klase
{
    public class Frižider : IUređaj
    {
        public string Ime { get; set; }
        public string Opis { get; set; }
        public bool IsUključen { get; set; }
        private double _temperatura;

        public Frižider(string name)
        {
            Ime = name;
            Opis = "Pametni frižider sa kontrolom temperature";
            IsUključen = false;
            _temperatura = 3.0; 
        }

        public void Uključi()
        {
            IsUključen = true;
            Console.WriteLine($"{Ime} je uključen.");
        }

        public void Isključi()
        {
            IsUključen = false;
            Console.WriteLine($"{Ime} je isključen.");
        }

        public void PostaviTemperaturu(double novaTemperatura)
        {
            if (!IsUključen)
            {
                Console.WriteLine("Prvo uključite frižider!");
                return;
            }

            if (novaTemperatura >= 2 && novaTemperatura <= 8)
            {
                _temperatura = novaTemperatura;
                Console.WriteLine($"Temperatura je postavljena na {novaTemperatura}°C");
            }
            else
            {
                Console.WriteLine("Temperatura mora biti između 2°C i 8°C!");
            }
        }

        public double DohvatiTemperaturu()
        {
            return _temperatura;
        }
    }
} 