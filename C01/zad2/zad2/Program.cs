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
            List<KontoBankowe> konta = new List<KontoBankowe>();

            konta.Add(new KontoBankowe("Kazik", "Lazik", "012345", 10.0, 0));
            konta.Add(new KontoBankowe("Kazik", "La", "065345", 100.0, 1));
            konta.Add(new KontoBankowe("Adam", "Karolak", "065655", 1000.0, 2));

            foreach (var konto in konta)
                Console.WriteLine(konto);

            konta[0].WplacPieniadze(50.0);
            konta[1].DodajOdsetki();
            konta[2].UsunKonto();

            foreach (var konto in konta)
                Console.WriteLine(konto);

            konta = konta.FindAll(x => x.DoUsuniecia == false).ToList();

            foreach (var konto in konta)
                Console.WriteLine(konto);

            Console.ReadKey();
        }
    }
}
