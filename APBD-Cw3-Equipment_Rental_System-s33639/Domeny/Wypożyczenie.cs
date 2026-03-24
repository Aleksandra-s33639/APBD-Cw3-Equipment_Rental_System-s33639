namespace APBD_Cw3_Equipment_Rental_System_s33639.Domeny;

public class Wypozyczenie
{
    public Sprzecik Sprzecik { get; }
    public Osoba Osoba { get; }
    public DateTime DataWypozyczenia { get; }
    public DateTime TerminZwrotu { get; }
    public DateTime? DataZwrotu { get; private set; }

    public bool CzyZwrocone => DataZwrotu.HasValue;

    public Wypozyczenie(Sprzecik sprzecik, Osoba osoba, int dni)
    {
        Sprzecik = sprzecik;
        Osoba = osoba;
        DataWypozyczenia = DateTime.Now;
        TerminZwrotu = DataWypozyczenia.AddDays(dni);
    }

    public void Zwroc()
    {
        DataZwrotu = DateTime.Now;
    }

    public bool CzyPrzeterminowane()
    {
        return !CzyZwrocone && DateTime.Now > TerminZwrotu;
    }

    public decimal ObliczKare()
    {
        if (!CzyZwrocone || DataZwrotu <= TerminZwrotu)
            return 0;

        var dniSpóźnienia = (DataZwrotu.Value - TerminZwrotu).Days;
        return dniSpóźnienia * 10;
    }
}