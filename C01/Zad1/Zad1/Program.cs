using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            Samochod pierwszy = new Samochod("Honda", 4, 0.0);
            Samochod drugi = new Samochod("Fiat", 4, 10.0, "bialy", "1993");

            Console.WriteLine(pierwszy);
            Console.WriteLine(drugi);

            pierwszy.Jedz(100.0);
            drugi.Jedz(1.0);

            Console.WriteLine(pierwszy);
            Console.WriteLine(drugi);

            pierwszy.Hamuj();
            drugi.Hamuj();

            Console.WriteLine(pierwszy);
            Console.WriteLine(drugi);

            Console.ReadKey();
        }
    }
}
