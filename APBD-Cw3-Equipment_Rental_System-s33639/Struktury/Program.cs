using APBD_Cw3_Equipment_Rental_System_s33639.Domeny;
using APBD_Cw3_Equipment_Rental_System_s33639.Struktury;

var serwis = new SerwisWypozyczen();

var student = new Student("Maria", "Kwiatkowska");
var laptop = new Laptopik("Lenovo", 32, "i7");

serwis.DodajOsobe(student);
serwis.DodajSprzecik(laptop);

serwis.Wypozycz(laptop.Id, student.Id, 1);

try
{
    serwis.Wypozycz(laptop.Id, student.Id, 1);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

var kara = serwis.Zwroc(laptop.Id);
Console.WriteLine($"Kara: {kara}");