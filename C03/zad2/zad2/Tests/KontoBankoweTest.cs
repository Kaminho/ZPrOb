using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace zad2
{
    using NUnit.Framework;

    [TestFixture]
    class KontoBankoweTest
    {
        [Test]
        public void WyplacPieniadzeTestMethod()
        {
            KontoBankowe k1 = new KontoBankowe(0);
            KontoBankowe k2 = new KontoBankowe(100);
            KontoBankowe k3 = new KontoBankowe(100);

            Assert.Multiple(() =>
            {
                Assert.Throws(Is.TypeOf<Exception>().And.Message.EqualTo("Kwota wyplacana musi byc wieksza od 0"), () => k1.WyplacPieniadze(0.0));
                Assert.Throws(Is.TypeOf<Exception>().And.Message.EqualTo("Kwota wyplacana musi byc wieksza od 0"), () => k1.WyplacPieniadze(-5.0));
                Assert.Throws(Is.TypeOf<Exception>().And.Message.EqualTo("Kwota wieksza od stanu konta"), () => k1.WyplacPieniadze(10.0));

                Assert.Throws(Is.TypeOf<Exception>().And.Message.EqualTo("Kwota wyplacana musi byc wieksza od 0"), () => k2.WyplacPieniadze(0.0));
                Assert.Throws(Is.TypeOf<Exception>().And.Message.EqualTo("Kwota wyplacana musi byc wieksza od 0"), () => k2.WyplacPieniadze(-5.0));
                Assert.Throws(Is.TypeOf<Exception>().And.Message.EqualTo("Kwota wieksza od stanu konta"), () => k1.WyplacPieniadze(101.0));

                Assert.AreEqual(50.0, k2.WyplacPieniadze(50.0));
                Assert.AreEqual(50.0, k2.StanKonta());

                Assert.AreEqual(0, k3.WyplacPieniadze(100.0));
            });

        }

        [Test]
        public void WplacPieniadzeTestMethod()
        {
            KontoBankowe k1 = new KontoBankowe(100);

            Assert.Multiple(() =>
            {
                Assert.Throws(Is.TypeOf<Exception>().And.Message.EqualTo("Kwota wyplacana musi byc wieksza od 0"), () => k1.WplacPieniadze(0.0));
                Assert.Throws(Is.TypeOf<Exception>().And.Message.EqualTo("Kwota wyplacana musi byc wieksza od 0"), () => k1.WplacPieniadze(-5.0));
                Assert.AreEqual(150, k1.WplacPieniadze(50));
            });
        }

        [Test]
        public void StanKontaTestMethod()
        {
            KontoBankowe k1 = new KontoBankowe(100);

            Assert.Multiple(() =>
            {
                Assert.AreEqual(100.0, k1.StanKonta());
                Assert.AreNotEqual(101.0, k1.StanKonta());
            });
        }

        [Test]
        public void PrzelewTestMethod()
        {
            KontoBankowe k1 = new KontoBankowe(100);
            KontoBankowe k2 = new KontoBankowe(100);

            Assert.Multiple(() =>
            {
                Assert.Throws(Is.TypeOf<Exception>().And.Message.EqualTo("Kwota wyplacana musi byc wieksza od 0"), () => k1.Przelew(k2, 0.0));
                Assert.Throws(Is.TypeOf<Exception>().And.Message.EqualTo("Kwota wyplacana musi byc wieksza od 0"), () => k1.Przelew(k2, -5.0));
                Assert.Throws(Is.TypeOf<Exception>().And.Message.EqualTo("Kwota wieksza od stanu konta"), () => k1.Przelew(k2, 101.0));

                k1.Przelew(k2, 50.0);

                Assert.AreEqual(50.0, k1.StanKonta());
                Assert.AreEqual(150.0, k2.StanKonta());
            });
        }
    }
}
