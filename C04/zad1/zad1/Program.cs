using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            Uczelnia UWM = Uczelnia.PobierzObiekt(DateTime.Parse("2017/03/25"));
            Uczelnia Stamford = Uczelnia.PobierzObiekt(DateTime.Parse("2017/03/20"));

            Console.WriteLine(UWM.RekrutujStudentow());
            Console.WriteLine(Stamford.RekrutujStudentow());

            Console.ReadKey();
        }
    }
}
