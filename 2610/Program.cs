using _2610;

Console.WriteLine("Hello, World!");
//Osoba osoba = new Osoba("Janek");
Czytelnik czytelnik = new Czytelnik("Janek");
czytelnik.wypiszInfoOCzytelniku();

Ksiazka ksiazkaLalka = new Ksiazka("Lalka", new Autor("Bolesław"));
Ksiazka ksiazkaDzieci = new Ksiazka("Dzieci z Bullerbyn", new Autor("Astrid"));
Ksiazka ksiazkaEmil = new Ksiazka("Emil z Smalandii", new Autor("Astrid"));
czytelnik.wypozyczKsiazke(ksiazkaEmil);
czytelnik.wypiszInfoOCzytelniku();
czytelnik.wypozyczKsiazke(ksiazkaEmil);
czytelnik.wypozyczKsiazke(ksiazkaDzieci);
Biblioteka biblioteka = new Biblioteka();
biblioteka.dodajCzytelnikaDoBiblioteki(czytelnik);
biblioteka.dodajKsizkeDoBiblioteki(ksiazkaDzieci);  
biblioteka.dodajKsizkeDoBiblioteki(ksiazkaEmil);
biblioteka.dodajKsizkeDoBiblioteki(ksiazkaLalka);
Console.WriteLine("Testowanie metody w bibliotece: ");
biblioteka.wypiszKsizkiDostepne();
czytelnik.oddajKsiazkeDoBiblioteki();
Console.WriteLine("Testowanie metody w bibliotece");
biblioteka.wypiszKsizkiDostepne();