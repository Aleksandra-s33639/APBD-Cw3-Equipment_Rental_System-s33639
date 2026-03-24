namespace APBD_Cw3_Equipment_Rental_System_s33639.Domeny;

public abstract class Osoba
{
    public Guid Id {get; private set;} = Guid.NewGuid();
    public string Imie {get; set;}
    public string Nazwisko {get; set;}

    public abstract int MaksWypozyczen {get;}

    protected Osoba(string imie, string nazwisko)
    {
        Imie = imie;
        Nazwisko = nazwisko;
    }
}