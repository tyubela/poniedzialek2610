using System;
using System.Collections.Generic;
using System.Text;

namespace _2610
{
    public class Czytelnik:Osoba
    {
        private static int licznikCzytelnikow;
        private int nrEwidencyjny;
        private List<Ksiazka> ksziazkaWypozyczone;

        public Czytelnik(string imie) : base(imie)
        { 
            licznikCzytelnikow++;
            nrEwidencyjny = licznikCzytelnikow;
            ksziazkaWypozyczone = new List<Ksiazka>();
        }

        public void wypozyczKsiazke(Ksiazka ksiazka)
        {
            if (ksiazka.czyWypozyczona == true)
            {
                Console.WriteLine("Książka jest już wypożyczona.");
            }
            else
            {
                Console.WriteLine($"Książka nie jest wypozyczona");
                ksiazka.czyWypozyczona = true;
            }
        }

        public void oddajKsiazkeDoBiblioteki(Ksiazka ksiazka)
        {
            if (ksiazka.czyWypozyczona == true)
            {
                ksziazkaWypozyczone.Remove(ksiazka);
                Console.WriteLine($"Książka {ksiazka.Tytul} została zwrócona do biblioteki.");
            }
            else
            {
                Console.WriteLine($"Książka {ksiazka.Tytul} nie jest wypożyczona przez tego czytelnika.");
            }
        }

        public void oddajWszystkieKsiazki()
        {
            foreach (Ksiazka ksiazka in ksziazkaWypozyczone)
            {
                ksiazka.czyWypozyczona = false;
            }
            ksziazkaWypozyczone.Clear();
        }

        public void wypiszInfoOCzytelniku()
        {
            Console.WriteLine($"Imię: {imie}");
            Console.WriteLine($"nr w bibliotece: {nrEwidencyjny}");
            Console.WriteLine("Wypożyczone książki:");
            foreach (Ksiazka ksiazka in ksziazkaWypozyczone)
            {
                Console.WriteLine(ksiazka.ToString());
            }
        }
    }
}
