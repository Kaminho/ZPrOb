using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    class Dekorator : ITelefon
    {
        protected ITelefon _iTelefon;
        protected string _typ;

        public Dekorator(ITelefon iTelefon, string typ)
        {
            _iTelefon = iTelefon;
            _typ = typ;
        }

        public void PokazTyp()
        {
            Console.WriteLine("Typ telefonu: {0}", _typ);
        }

        public void WybierzNumer(string numer)
        {
            _iTelefon.WybierzNumer(numer);
        }

        public void WyslijWiadomosc(string numer, string tresc)
        {
            _iTelefon.WyslijWiadomosc(numer, tresc);
        }
    }
}
