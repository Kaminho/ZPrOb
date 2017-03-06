using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    class Samochod
    {
        public string Marka { get; private set; }
        public int LiczbaKol { get; private set; }
        public double Predkosc { get; private set; }
        public string Kolor { get; private set; }
        public string Rocznik { get; private set; }

        public Samochod(string marka, int liczbaKol, double predkosc, string kolor = "Czarny", string rocznik = "2016")
        {
            Marka = marka;
            LiczbaKol = liczbaKol;
            Predkosc = predkosc;
            Kolor = kolor;
            Rocznik = rocznik;
        }

        public void Hamuj()
        {
            Predkosc = 0.0;
            Console.WriteLine("Samochod {0} wyhamowal\n", Marka);
        }

        public void Jedz(double predkosc)
        {
            if (predkosc > 0)
                Predkosc = predkosc;

            Console.WriteLine("Samochod {0} rozpedzil sie do {1}\n", Marka, Predkosc);
        }

        public override string ToString()
        {
            return string.Format("{0} samochód marki {1} jedzie z prędkością {2}"
                                 + "\nDomyślna ilość kół używanych jednocześnie w samochodzie to {3}\n",
                                 Kolor, Marka, Predkosc, LiczbaKol);
        }
    }
}
