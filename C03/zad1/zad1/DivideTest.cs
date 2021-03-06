﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    using NUnit.Framework;

    [TestFixture]
    class DivideTest
    {
        [Test]
        public void DivideTestMethod()
        {
            Assert.Multiple(() =>
            {
                Assert.AreEqual(0.5, Divide.DivideNumbers(1, 2));
                Assert.AreEqual(0, Divide.DivideNumbers(0, 2));
                Assert.AreNotEqual(0.5, Divide.DivideNumbers(1, 3));
                Assert.Throws(typeof(DivideByZeroException), () => Divide.DivideNumbers(1, 0));
            });
        }
    }
}
