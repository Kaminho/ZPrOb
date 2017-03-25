using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    class FabrykaApple : IFabryka
    {
        public IObudowa TworzObudowe()
        {
            return new AppleObudowa();
        }

        public IEkran TworzEkran()
        {
            return new AppleEkran();
        }
    }
}
