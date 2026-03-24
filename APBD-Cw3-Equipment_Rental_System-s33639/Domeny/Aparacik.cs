namespace APBD_Cw3_Equipment_Rental_System_s33639.Domeny;

public class Aparacik : Sprzecik
{ 
    public int Megapiksele {get; set;}
    public bool CzyLustrzanka {get; set;}

    public Aparacik(string nazwa, int megapiksele, bool czyLustrzanka)
        : base(nazwa)
    {
        Megapiksele = megapiksele;
        CzyLustrzanka = czyLustrzanka;
    }
}