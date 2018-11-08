using System;

namespace _1_TypyGeneryczne
{
    public class KolejkaKołowa
    {
        private Double[] bufor;
        private int poczatekBufora;
        private int koniecBufora;


        public KolejkaKołowa() : this(pojemnosc: 5)
        {

        }

        public KolejkaKołowa(int pojemnosc)
        {
            bufor = new double[pojemnosc + 1];
            poczatekBufora = 0;
            koniecBufora = 0;
        }

        public void Zapisz(double wartosc)
        {
            bufor[koniecBufora] = wartosc;
            koniecBufora = (koniecBufora + 1) % bufor.Length;
            if (koniecBufora == poczatekBufora)
            {
                poczatekBufora = (poczatekBufora + 1) % bufor.Length;
            }
        }

        public double Czytaj()
        {
            var wynik = bufor[poczatekBufora];
            poczatekBufora = (poczatekBufora + 1) % bufor.Length;

            return wynik;
        }

        public int Pojemnosc
        {
            get
            {
                return bufor.Length;
            }
        }
        public bool JestPusty
        {
            get
            {
                return koniecBufora == poczatekBufora;
            }
        }

        public bool JestPelny
        {
            get
            {
                return (koniecBufora + 1) % bufor.Length ==poczatekBufora;
            }
        }

    }
}
