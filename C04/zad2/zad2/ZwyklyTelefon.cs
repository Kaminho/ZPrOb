using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    class ZwyklyTelefon : ITelefon
    {
        private string _typ;

        public ZwyklyTelefon(string typ)
        {
            _typ = typ;
        }

        public void PokazTyp()
        {
            Console.WriteLine("Typ telefonu: {0}", _typ);
        }

        public void WybierzNumer(string numer)
        {
            Console.WriteLine("Wybieram numer {0}", numer);
        }

        public void WyslijWiadomosc(string numer, string tresc)
        {
            Console.WriteLine("Wysyłam wiadomość o treści \"{0}\" na numer {1}", tresc, numer);
        }
    }
}
