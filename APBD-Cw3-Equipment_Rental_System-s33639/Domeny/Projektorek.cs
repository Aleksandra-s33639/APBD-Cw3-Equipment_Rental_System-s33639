namespace APBD_Cw3_Equipment_Rental_System_s33639.Domeny;

public class Projektorek : Sprzecik
{
    public int Lumeny {get; set;}
    public string Rozdzielczosc {get; set;}

    public Projektorek(string nazwa, int lumeny, string rozdzielczosc)
        : base(nazwa)
    {
        Lumeny = lumeny;
        Rozdzielczosc = rozdzielczosc;
    }
}