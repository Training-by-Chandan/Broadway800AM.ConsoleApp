using Microsoft.VisualStudio.TestTools.UnitTesting;
using ECom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECom.Tests
{
    [TestClass()]
    public class ArithmeticTests
    {
        [TestMethod()]
        public void AddTest()
        {
            Arithmetic a = new Arithmetic();
            int x = 10;
            int y = 20;
            int expected = 30;
            var res = a.Add(x, y);
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void AddTestV2()
        {
            Arithmetic a = new Arithmetic();
            var res = a.Add(2, 3);
            Assert.IsInstanceOfType(res, typeof(int));
        }
    }
}
