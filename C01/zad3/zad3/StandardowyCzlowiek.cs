using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    class StandardowyCzlowiek
    {
        public string Imie { get; private set; }
        public int Wiek { get; private set; }
        public string MiejscePochodzenia { get; private set; }
        public static readonly int IloscKosciSzkieletowych = 50;
        public static readonly int IloscChromosomow = 50;

        public StandardowyCzlowiek(string imie, int wiek, string miejscePochodzenia)
        {
            Imie = imie;
            Wiek = wiek;
            MiejscePochodzenia = miejscePochodzenia;
        }

        public override string ToString()
        {
            return string.Format("{0} lat {1} pochodzi z {2}", Imie, Wiek, MiejscePochodzenia);
        }
    }
}
