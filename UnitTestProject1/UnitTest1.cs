using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Karl_2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string x1 = "Roger";
            string x2 = "Roger";
            Assert.AreEqual(x1, x2);
        }
        [TestMethod]
        public void TestMethod2()
        {
            StringManipulator StringManipulator = new StringManipulator();
            string x1 = "Roger";
            x1 = StringManipulator.PlusOne(x1);
            Assert.AreEqual("Roger_One", x1);
        }
        [TestMethod]
        public void TestMethod3()
        {
            StringManipulator StringManipulator = new StringManipulator();
            string x1 = "AlphaZero";
            x1 = StringManipulator.ReverseString(x1);
            Assert.AreEqual("oreZahplA", x1);
        }
    }
}
