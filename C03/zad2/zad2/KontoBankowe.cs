using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    class KontoBankowe
    {
        private double stanKonta;

        public KontoBankowe(double stanKonta)
        {
            this.stanKonta = stanKonta;
        }

        public double WyplacPieniadze(double ile)
        {
            kwotaMniejszaRownaZero(ile);
            kwotaWiekszaNizStanKonta(ile);

            stanKonta -= ile;

            return stanKonta;
        }

        public double WplacPieniadze(double ile)
        {
            kwotaMniejszaRownaZero(ile);

            stanKonta += ile;

            return stanKonta;
        }

        public double StanKonta()
        {
            return stanKonta;
        }

        public void Przelew(KontoBankowe konto, double ile)
        {
            kwotaMniejszaRownaZero(ile);
            kwotaWiekszaNizStanKonta(ile);

            WyplacPieniadze(ile);
            konto.WplacPieniadze(ile);
        }

        private void kwotaMniejszaRownaZero(double ile)
        {
            if (ile <= 0.0)
                throw new Exception("Kwota wyplacana musi byc wieksza od 0");
        }

        private void kwotaWiekszaNizStanKonta(double ile)
        {
            if (ile > stanKonta)
                throw new Exception("Kwota wieksza od stanu konta");
        }
    }
}
