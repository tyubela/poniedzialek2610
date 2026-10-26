using System;
using System.Collections.Generic;
using System.Text;

namespace _2610
{
    public class Biblioteka
    {
        public List<Ksiazka> ksiazkiList { get; set; }
        public List<Czytelnik> czytelnicyList { get; set; }
        public Biblioteka()
        {
            ksiazkiList = new List<Ksiazka>();
            czytelnicyList = new List<Czytelnik>();
        }
        public void dodajKsizkeDoBiblioteki(Ksiazka ksiazka)
        {
            ksiazkiList.Add(ksiazka);
        }
        public void dodajCzytelnikaDoBiblioteki(Czytelnik czytelnik)
        {
            if (czytelnicyList.Contains(czytelnik))
            {
                Console.WriteLine("Czytelnik już istnieje w bibliotece.");
            }
            else
            {
                czytelnicyList.Add(czytelnik);
            }
        }
    public void wypiszKsizkiDostepne()
        {
            Console.WriteLine("Niewypozyczone ksiazki: ");
            foreach (Ksiazka ksiazka in ksiazkiList)
            {
                if(ksiazka.czyWypozyczona == false)
                {
                    Console.WriteLine(ksiazka);
                }
            }
        }
    }
}
