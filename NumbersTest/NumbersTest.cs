using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace NumbersTest
{
    [TestClass]
    public class NumbersTest
    {
        [TestMethod]
        public void Test0()
        {
            string expected = "Cero";
            var sex = "male";

            Assert.AreEqual(expected, Numbers.Numbers.Convert(0, ""));
        }
    }
}
