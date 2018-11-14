﻿using System;

namespace _1_TypyGeneryczne
{
    class Program
    {
        static void Main(string[] args)
        {
            var kolejka = new KolejkaKolowa(pojemnosc: 3);

            while(true)
            {
                var wartosc = 0.0;
                var wartoscWejsciowa = Console.ReadLine();

                if(double.TryParse(wartoscWejsciowa,out wartosc))
                {
                    kolejka.Zapisz(wartosc);
                    continue;
                }
                break;

            }

            Console.WriteLine("W naszej kolejce jest : ");

            var suma = 0.0;
            while (!kolejka.JestPusty)
            {
                suma += kolejka.Czytaj();
            }
            Console.WriteLine("\t\t" + kolejka.Czytaj());
            Console.ReadLine();
        }
    }
}
