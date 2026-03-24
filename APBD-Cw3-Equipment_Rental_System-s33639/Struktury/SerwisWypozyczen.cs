namespace APBD_Cw3_Equipment_Rental_System_s33639.Struktury;

using APBD_Cw3_Equipment_Rental_System_s33639.Domeny;

public class SerwisWypozyczen {
    private readonly List<Sprzecik> _sprzeciki = new();
    private readonly List<Osoba> _osoby = new();
    private readonly List<Wypozyczenie> _wypozyczenia = new();

    public void DodajSprzecik(Sprzecik s) => _sprzeciki.Add(s);
    public void DodajOsobe(Osoba u) => _osoby.Add(u);

    public void Wypozycz(Guid sprzecikId, Guid osobaId, int dni) {
        var sprzet = _sprzeciki.First(s => s.Id == sprzecikId);
        var user = _osoby.First(u => u.Id == osobaId);

        if (!sprzet.CzyDostepny)
            throw new Exception("Sprzęcik jest niedostępny :(");

        var aktywne = _wypozyczenia.Count(w => w.Osoba.Id == osobaId && !w.CzyZwrocone);

        if (aktywne >= user.MaksWypozyczen)
            throw new Exception("Przekroczono limit wypozyczen :(");

        var wyp = new Wypozyczenie(sprzet, user, dni);
        sprzet.CzyDostepny = false;
        _wypozyczenia.Add(wyp);
        Console.WriteLine("Wypozyczono sprzecik! :D");
    }

    public decimal Zwroc(Guid sprzetId) {
        var wyp = _wypozyczenia.First(w => w.Sprzecik.Id == sprzetId && !w.CzyZwrocone);

        wyp.Zwroc();
        wyp.Sprzecik.CzyDostepny = true;
        Console.WriteLine("Zwrocono sprzecik! :D");
        
        return wyp.ObliczKare();
    }

    public List<Sprzecik> DostepnySprzet()
        => _sprzeciki.Where(s => s.CzyDostepny).ToList();

    public List<Wypozyczenie> Przeterminowane()
        => _wypozyczenia.Where(w => w.CzyPrzeterminowane()).ToList();
    
    public string Raport()
    {
        return $"Sprzęcik: {_sprzeciki.Count}, Dostępny: {_sprzeciki.Count(s => s.CzyDostepny)}";
    }
}