using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    class FabrykaSamsung : IFabryka
    {
        public IObudowa TworzObudowe()
        {
            return new SamsungObudowa();
        }

        public IEkran TworzEkran()
        {
            return new SamsungEkran();
        }
    }
}
