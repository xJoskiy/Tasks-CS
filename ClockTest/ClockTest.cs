using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ClockTest
{
    [TestClass]
    public class ClockTest
    {
        [TestMethod]
        public void TestZeros()
        {
            string expected = "0:00";
            int hours = 0, minutes = 0;
            float degree = 0;

            Assert.AreEqual(expected, Clock.Clock.ComputeTime(degree, hours, minutes));
        }

        [TestMethod]
        public void Test1()
        {
            string expected = "1:00";
            int hours = 1, minutes = 0;
            float degree = 30;

            Assert.AreEqual(expected, Clock.Clock.ComputeTime(degree, hours, minutes));
        }

        [TestMethod]
        public void Test2()
        {
            string expected = "1:37";
            int hours = 1, minutes = 5;
            float degree = 180;

            Assert.AreEqual(expected, Clock.Clock.ComputeTime(degree, hours, minutes));
        }

        [TestMethod]
        public void Test3()
        {
            string expected = "1:37";
            int hours = 1, minutes = 5;
            float degree = 180;

            Assert.AreEqual(expected, Clock.Clock.ComputeTime(degree, hours, minutes));
        }
    }
}
