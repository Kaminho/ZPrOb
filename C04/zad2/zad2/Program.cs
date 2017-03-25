using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            ZwyklyTelefon zwykly = new ZwyklyTelefon("zwykły");
            Smartphone smartphone = new Smartphone(zwykly, "smartphone");

            zwykly.WybierzNumer("666 666 666");
            smartphone.WybierzNumer("666 666 666");

            zwykly.PokazTyp();
            smartphone.PokazTyp();

            zwykly.WyslijWiadomosc("666 666 666", "Brak treści");
            smartphone.WyslijWiadomosc("666 666 666", "Brak treści");

            smartphone.OdwiedzStrone("uwm.edu.pl");
            smartphone.UruchomAplikacje("Chrome");

            Console.ReadKey();
        }
    }
}
