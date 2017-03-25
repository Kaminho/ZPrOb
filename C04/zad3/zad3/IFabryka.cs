using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    interface IFabryka
    {
        IObudowa TworzObudowe();
        IEkran TworzEkran();
    }
}
