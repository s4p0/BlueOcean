using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlueOceanTester.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueOceanTester.Lib.Tests
{
    [TestClass()]
    public class Class1Tests
    {
        [TestMethod()]
        public void MagicNumberTest()
        {
            var result = new Class1().MagicNumber(3);
            var expected = 9;
            Assert.AreEqual(expected, result);
        }
    }
}