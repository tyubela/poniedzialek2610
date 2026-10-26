using System;
using System.Collections.Generic;
using System.Text;

namespace _2610
{
    public class Ksiazka
    {
        public string Tytul { get; set; }
        public string autor { get; set; }
        public bool czyWypozyczona { get; set; }
        public Ksiazka(string tytul, Autor autor, bool czyWypozyczona)
        {
            Tytul = tytul;
            this.autor = autor;
            czyWypozyczona = false;
        }
        public override string ToString()
        {
            return $"Tytuł: {Tytul}";
        }
    }
}
