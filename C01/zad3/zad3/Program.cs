using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<StandardowyCzlowiek> ludzie = new List<StandardowyCzlowiek>();

            ludzie.Add(new StandardowyCzlowiek("Kamil", 12, "Olsztyn"));
            ludzie.Add(new StandardowyCzlowiek("Tadeusz", 13, "Warszawa"));
            ludzie.Add(new StandardowyCzlowiek("Roman", 14, "Warszawa"));
            ludzie.Add(new StandardowyCzlowiek("Jaroslaw", 15, "Olsztyn"));
            ludzie.Add(new StandardowyCzlowiek("Waclaw", 17, "Olsztyn"));

            double sredniaWieku = (double)ludzie.Sum(x => x.Wiek) / ludzie.Count;

            Console.WriteLine("Srednia wieku {0}", sredniaWieku);

            foreach (var czlowiek in ludzie)
                Console.WriteLine(czlowiek.Imie);

            foreach (var czlowiek in ludzie)
                Console.WriteLine(czlowiek);

            Dictionary<string, int> miasta = new Dictionary<string, int>();

            foreach (var czlowiek in ludzie)
            {
                if (miasta.ContainsKey(czlowiek.MiejscePochodzenia))
                    miasta[czlowiek.MiejscePochodzenia]++;
                else
                    miasta.Add(czlowiek.MiejscePochodzenia, 0);
            }

            string najczesciejWystepujaceMiasto = miasta.OrderByDescending(x=>x.Value).First().Key;

            Console.WriteLine("Najczesciej wystepujace miasto {0}", najczesciejWystepujaceMiasto);

            Console.ReadKey();
        }
    }
}
