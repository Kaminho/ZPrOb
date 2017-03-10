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
            Student student = new Student("Jan", "Student", "1990/05/12", 1, 3, 123456);
            student.DodajOcene("ZPrOb", "2017/03/10", 5.0);
            student.DodajOcene("ZPrOb", "2017/03/10", 4.0);
            student.DodajOcene("ZPrOb", "2017/03/10", 3.0);
            student.DodajOcene("ZPrOb", "2017/03/10", 2.0);

            student.DodajOcene("PSI", "2017/03/10", 5.0);
            student.DodajOcene("SI", "2017/03/10", 4.0);
            student.DodajOcene("AiOK", "2017/03/10", 3.0);

            student.WypiszInfo();
            student.WypiszOceny();

            Console.WriteLine();

            Console.WriteLine("usun ocene ZPrOb 2017/03/10 2.0");
            student.UsunOcene("ZPrOb", "2017/03/10", 2.0);
            student.WypiszOceny();

            Console.WriteLine();

            Console.WriteLine("usun oceny z ZPrOb");
            student.UsunOceny("ZPrOb");
            student.WypiszOceny();

            Console.WriteLine();

            Console.WriteLine("usun oceny");
            student.UsunOceny();
            student.WypiszOceny();

            Console.WriteLine("-----------------");

            Pilkarz p = new Pilkarz("Kazik", "Lewy", "1990/05/12", "Napastnik", "AA", 5);
            PilkarzReczny pr = new PilkarzReczny("Kazik", "Kolowy", "1990/05/12", "Obrotowy", "BB", 4);
            PilkarzNozny pn = new PilkarzNozny("Kazik", "Strzelec", "1990/05/12", "Pomocnik", "AA", 6);

            p.StrzelGola();
            pr.StrzelGola();
            pn.StrzelGola();

            Console.ReadKey();
        }
    }
}
