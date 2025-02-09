 SmartHouse - Pametni Dom

Ova konzolna aplikacija razvijena je u .NET 6 C# i služi za demonstraciju osnovnih koncepata objektno orijentisanog programiranja kroz simulaciju pametnog doma. Aplikacija omogućava upravljanje s dva pametna uređaja: garažnim vratima i frižiderom.

 Struktura projekta

 1. Klasa GaražnaVrata
- **Lokacija:** `/Klase/GaražnaVrata.cs`
- **Svrha:**  
  Klasa `GaražnaVrata` simulira rad garažnih vrata u pametnom domu. Omogućava korisniku da otvori i zatvori vrata te provjeri trenutno stanje.
- **Glavna svojstva:**  
  - `Ime` – naziv uređaja.
  - `Opis` – opis funkcionalnosti (npr. automatsko otvaranje).
  - `IsOtvorena` – logička vrijednost koja pokazuje da li su vrata otvorena.
- **Metode:**  
  - `Otvori()` – otvara garažna vrata (ako već nisu otvorena).
  - `Zatvori()` – zatvara garažna vrata (ako već nisu zatvorena).

 2. Klasa Frižider
- **Lokacija:** `/Klase/Frižider.cs`
- **Svrha:**  
  Klasa `Frižider` predstavlja pametni frižider s mogućnošću kontrole temperature i statusa uključenosti. Ova klasa implementira interfejs `IUređaj` kako bi osigurala osnovne funkcionalnosti koje dijele svi pametni uređaji.
- **Glavna svojstva:**  
  - `Ime` – naziv uređaja.
  - `Opis` – opis funkcionalnosti frižidera.
  - `IsUključen` – logička vrijednost koja pokazuje da li je frižider uključen.
- **Metode:**  
  - `Uključi()` – uključuje frižider.
  - `Isključi()` – isključuje frižider.
  - `PostaviTemperaturu(double novaTemperatura)` – postavlja temperaturu, pod uvjetom da je frižider uključen i da je temperatura u dozvoljenom rasponu (npr. 2°C - 8°C).
  - `DohvatiTemperaturu()` – vraća trenutačno postavljenu temperaturu.

 3. Interfejs IUređaj
- **Lokacija:** `/Interfejs/IUređaj.cs`
- **Svrha:**  
  Interfejs `IUređaj` definira osnovne karakteristike i metode koje svaki pametni uređaj treba implementirati. Na taj način se osigurava konzistentnost u radu različitih uređaja unutar sistema.
- **Definisane stavke:**  
  - Svojstva: `Ime`, `Opis`, `IsUključen`.
  - Metode: `Uključi()` i `Isključi()`.

 4. Glavna klasa Program
- **Lokacija:** `Program.cs`
- **Svrha:**  
  Klasa `Program` sadrži ulaznu tačku aplikacije (metodas `Main`) te implementira konzolni meni za interakciju s korisnikom. Kroz ovaj meni korisnici mogu birati između upravljanja garažnim vratima i frižiderom.
- **Funkcionalnosti:**  
  - Prikaz menija s opcijama za upravljanje uređajima.
  - Pozivanje odgovarajućih metoda iz klasa `GaražnaVrata` i `Frižider` na osnovu korisničkog izbora.

 K

## Dodatne napomene

- Prilikom postavljanja temperature frižidera potrebno je pokrenuti opciju "Uključi" inače će izbaciti error 