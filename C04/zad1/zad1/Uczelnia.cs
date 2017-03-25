using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    class Uczelnia
    {
        private static Uczelnia _uczelnia;
        private DateTime _dataRejestracji;

        private Uczelnia(DateTime dataRekrutacji)
        {
            _dataRejestracji = dataRekrutacji;
        }

        public static Uczelnia PobierzObiekt(DateTime dataRekrutacji)
        {
            if (_uczelnia == null)
            {
                _uczelnia = new Uczelnia(dataRekrutacji);
                return _uczelnia;
            }

            return _uczelnia;
        }

        public DateTime RekrutujStudentow()
        {
            return _dataRejestracji;
        }
    }
}
