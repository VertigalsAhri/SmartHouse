namespace SmartHouse.Interfejs
{
    public interface IUređaj
    {
        string Ime { get; set; }
        string Opis { get; set; }
        bool IsUključen { get; set; }
        void Uključi();
        void Isključi();
    }
}

        