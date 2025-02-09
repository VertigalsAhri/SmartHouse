using SmartHouse.Klase;

class Program
{
    static void Main(string[] args)
    {
        var garažnaVrata = new GaražnaVrata("Garažna vrata");
        var frižider = new Frižider("Frižider");

        while (true)
        {
            Console.WriteLine("\n=== Smart House Menu ===");
            Console.WriteLine("1. Upravljanje garažnim vratima");
            Console.WriteLine("2. Upravljanje frižiderom");
            Console.WriteLine("3. Izlaz");

            Console.Write("\nIzaberite opciju: ");
            var izbor = Console.ReadLine();

            switch (izbor)
            {
                case "1":
                    UpravaljajGaražnimVratima(garažnaVrata);
                    break;
                case "2":
                    UpravaljajFrižiderom(frižider);
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Nepoznata opcija!");
                    break;
            }
        }
    }

    static void UpravaljajGaražnimVratima(GaražnaVrata vrata)
    {
        Console.WriteLine("\n=== Garažna Vrata ===");
    
        Console.WriteLine("1. Otvori");
        Console.WriteLine("2. Zatvori");

        Console.Write("\nIzaberite opciju: ");
        var izbor = Console.ReadLine();

        switch (izbor)
        {
            case "1": vrata.Otvori(); break;
            case "2": vrata.Zatvori(); break;
            default: Console.WriteLine("Nepoznata opcija!"); break;
        }
    }

    static void UpravaljajFrižiderom(Frižider frižider)
    {
        Console.WriteLine("\n=== Frižider ===");
        Console.WriteLine("1. Uključi");
        Console.WriteLine("2. Isključi");
        Console.WriteLine("3. Postavi temperaturu");
        Console.WriteLine("4. Prikaži trenutnu temperaturu");

        Console.Write("\nIzaberite opciju: ");
        var izbor = Console.ReadLine();

        switch (izbor)
        {
            case "1":
                frižider.Uključi();
                break;
            case "2":
                frižider.Isključi();
                break;
            case "3":
                Console.Write("Unesite željenu temperaturu (2-8°C): ");
                if (double.TryParse(Console.ReadLine(), out double temp))
                {
                    frižider.PostaviTemperaturu(temp);
                }
                else
                {
                    Console.WriteLine("Neispravan unos temperature!");
                }
                break;
            case "4":
                Console.WriteLine($"Trenutna temperatura: {frižider.DohvatiTemperaturu()}°C");
                break;
            default:
                Console.WriteLine("Nepoznata opcija!");
                break;
        }
    }
}
