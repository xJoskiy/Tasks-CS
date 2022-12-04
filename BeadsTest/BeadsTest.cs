using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BeadsTest
{
    [TestClass]
    public class BeadsTest
    {
        [TestMethod]
        public void Ones()
        {
            int N = 1, red = 1, blue = 1, green = 1;
            int expected = 3;

            Assert.AreEqual(expected, Beads.Beads.Calculate(N, red, blue, green));
        }

        [TestMethod]
        public void Twos()
        {
            int N = 2, red = 2, blue = 2, green = 2;
            int expected = 5;

            Assert.AreEqual(expected, Beads.Beads.Calculate(N, red, blue, green));
        }

        [TestMethod]
        public void TwosLenght3()
        {
            int N = 3, red = 2, blue = 2, green = 2;
            int expected = 13;

            Assert.AreEqual(expected, Beads.Beads.Calculate(N, red, blue, green));
        }

        [TestMethod]
        public void TwosLenght4()
        {
            int N = 4, red = 2, blue = 2, green = 2;
            int expected = 13;

            Assert.AreEqual(expected, Beads.Beads.Calculate(N, red, blue, green));
        }

        [TestMethod]
        public void TwosLenght5()
        {
            int N = 5, red = 2, blue = 2, green = 2;
            int expected = 19;

            Assert.AreEqual(expected, Beads.Beads.Calculate(N, red, blue, green));
        }

        [TestMethod]
        public void TwosLenght6()
        {
            int N = 6, red = 2, blue = 2, green = 2;
            int expected = 3;

            Assert.AreEqual(expected, Beads.Beads.Calculate(N, red, blue, green));
        }

        [TestMethod]
        public void Random()
        {
            int N = 26, red = 9, blue = 7, green = 9;
            int expected = 0;

            Assert.AreEqual(expected, Beads.Beads.Calculate(N, red, blue, green));
        }

        [TestMethod]
        public void Lenght1()
        {
            int N = 1, red = 124, blue = 43, green = 41;
            int expected = 3;
                
            Assert.AreEqual(expected, Beads.Beads.Calculate(N, red, blue, green));
        }

        [TestMethod]
        public void GreenAndRed()
        {
            int N = 2, red = 10000, blue = 0, green = 1;
            int expected = 1;

            Assert.AreEqual(expected, Beads.Beads.Calculate(N, red, blue, green));
        }
    }
}
