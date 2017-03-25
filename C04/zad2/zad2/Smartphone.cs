using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    class Smartphone : Dekorator
    {
        public Smartphone(ZwyklyTelefon zwyklyTelefon, string typ) : base(zwyklyTelefon, typ)
        {

        }

        public void OdwiedzStrone(string adres)
        {
            Console.WriteLine("Odwiedzono stronę o adresie {0}", adres);
        }

        public void UruchomAplikacje(string nazwa)
        {
            Console.WriteLine("Uruchomiono aplikację {0}", nazwa);
        }
    }
}
