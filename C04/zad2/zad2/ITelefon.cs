using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    interface ITelefon
    {
        void WybierzNumer(string numer);
        void WyslijWiadomosc(string numer, string tresc);
        void PokazTyp();
    }
}
