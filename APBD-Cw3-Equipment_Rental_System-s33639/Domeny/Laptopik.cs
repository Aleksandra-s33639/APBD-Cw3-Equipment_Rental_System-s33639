namespace APBD_Cw3_Equipment_Rental_System_s33639.Domeny;

public class Laptopik : Sprzecik {
    public int RamGb {get; set;}
    public string Procesor {get; set;}

    public Laptopik(string nazwa, int ramGb, string procesor)
        : base(nazwa)
    {
        RamGb = ramGb;
        Procesor = procesor;
    }
}