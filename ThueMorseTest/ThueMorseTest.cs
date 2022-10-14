using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ThueMorseTest
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void TestN0()
        {
            int N = 0;
            string expected = "";
            Assert.AreEqual(expected, ThueMorse.ThueMorse.Generate(N));
        }

        [TestMethod]
        public void TestN1()
        {
            int N = 1;
            string expected = "0";
            Assert.AreEqual(expected, ThueMorse.ThueMorse.Generate(N));
        }

        [TestMethod]
        public void TestN10()
        {
            int N = 10;
            string expected = "0110100110";
            Assert.AreEqual(expected, ThueMorse.ThueMorse.Generate(N));
        }

        [TestMethod]
        public void TestN20()
        {
            int N = 20;
            string expected = "01101001100101101001";
            Assert.AreEqual(expected, ThueMorse.ThueMorse.Generate(N));
        }

        [TestMethod]
        public void TestN100()
        {
            int N = 100;
            string expected = "0110100110010110100101100110100110010110011010010110100110010110100101100110100101101001100101100110";
            Assert.AreEqual(expected, ThueMorse.ThueMorse.Generate(N));
        }
    }
}
