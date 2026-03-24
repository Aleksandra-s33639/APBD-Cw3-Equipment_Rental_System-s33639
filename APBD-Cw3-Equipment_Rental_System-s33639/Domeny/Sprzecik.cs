namespace APBD_Cw3_Equipment_Rental_System_s33639.Domeny;

public abstract class Sprzecik {
    public Guid Id {get; private set;} = Guid.NewGuid();
    public string Nazwa {get; set;}
    public bool CzyDostepny {get; set;} = true;

    protected Sprzecik(string nazwa)
    {
        Nazwa = nazwa;
    }
}