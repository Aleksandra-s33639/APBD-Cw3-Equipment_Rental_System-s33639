namespace APBD_Cw3_Equipment_Rental_System_s33639.Domeny;

public class Pracownik : Osoba
{
    public override int MaksWypozyczen => 5;

    public Pracownik(string imie, string nazwisko)
        : base(imie, nazwisko) { }
}