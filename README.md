Aleksandra Jurszo - s33639
APBD - Cwiczenia 3

System Wypożyczalni Sprzętu:

Opis:
Konsolowa aplikacja służąca do obsługi uczelnianej wypożyczalni sprzętu.
Pozwala dodawać sprzęt i osoby (studentów, pracownikó), wypożyczać i zwracać sprzęt, kontrolować dostępność oraz generować raporty.

Struktura:
1. Domeny: Sprzecik (Laptopik, Aparacik, Projektorek), Osoba (Pracownik, Student), Wypozyczenie
2. Serwisy: SerwisWypozyczen + Program.cs z przykładowym scenariuszem.

Rospiska Modeli:
1. Sprzęcik: Laptop, Projektor, Aparat
2. Osoba: Student (max 2 wypożyczenia), Pracownik (max 5)
3. Wypożyczenie: dane o sprzęcie, osobie, terminie i karach

Logika biznesowa:
1. Blokuje wypożyczenie niedostępnego sprzętu
2. Sprawdza limit wypożyczeń użytkownika
3. Naliczanie kary za przeterminowany zwrot (10 jednostek/dzień)
4. Raport - Wyświetla ilość sprzętu ogółem i dostępnego

Decyzje projektowe:
Pakiety: Domena – dane, Serwis – logika
Dziedziczenie: tylko tam, gdzie wynika z modelu domeny
Coupling: warstwa UI nie zawiera logiki biznesowej
Każda klasa ma jedną, wyraźną odpowiedzialność
