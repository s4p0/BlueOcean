using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueOceanTester.UT
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void TestMethod()
        {
            
            var result = new Lib.Class1().MagicNumber(3);
            Assert.AreEqual(9, result);
        }
    }
}
