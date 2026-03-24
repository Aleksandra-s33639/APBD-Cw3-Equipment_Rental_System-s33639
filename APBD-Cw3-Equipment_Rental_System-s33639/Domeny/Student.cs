namespace APBD_Cw3_Equipment_Rental_System_s33639.Domeny;

public class Student : Osoba
{
    public override int MaksWypozyczen => 2;

    public Student(string imie, string nazwisko)
        : base(imie, nazwisko) { }
}