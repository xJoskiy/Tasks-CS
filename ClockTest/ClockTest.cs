using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ClockTest
{
    [TestClass]
    public class ClockTest
    {
        [TestMethod]
        public void Zeros()
        {
            string expected = "0:00";
            int hours = 0, minutes = 0;
            float degree = 0;

            Assert.AreEqual(expected, Clock.Clock.ComputeTime(degree, hours, minutes));
        }

        [TestMethod]
        public void Test100()
        {
            string expected = "1:00";
            int hours = 1, minutes = 0;
            float degree = 30;

            Assert.AreEqual(expected, Clock.Clock.ComputeTime(degree, hours, minutes));
        }

        [TestMethod]
        public void Test180Degrees()
        {
            string expected = "1:39";
            int hours = 1, minutes = 5;
            float degree = 180;

            Assert.AreEqual(expected, Clock.Clock.ComputeTime(degree, hours, minutes));
        }

        [TestMethod]
        public void Test58Degrees()
        {
            string expected = "1:16";
            int hours = 1, minutes = 5;
            float degree = 58;

            Assert.AreEqual(expected, Clock.Clock.ComputeTime(degree, hours, minutes));
        }

        [TestMethod]
        public void TestOnes()
        {
            string expected = "11:11";
            int hours = 10, minutes = 39;
            float degree = 90;

            Assert.AreEqual(expected, Clock.Clock.ComputeTime(degree, hours, minutes));
        }

        [TestMethod]
        public void TestEvening()
        {
            string expected = "17:40";
            int hours = 17, minutes = 20;
            float degree = 65;

            Assert.AreEqual(expected, Clock.Clock.ComputeTime(degree, hours, minutes));
        }

        [TestMethod]
        public void TestSame()
        {
            string expected = "21:05";
            int hours = 21, minutes = 5;
            float degree = 117.5f;

            Assert.AreEqual(expected, Clock.Clock.ComputeTime(degree, hours, minutes));
        }

        [TestMethod]
        public void TestMorning()
        {
            string expected = "9:11";
            int hours = 8, minutes = 17;
            float degree = 150.5f;

            Assert.AreEqual(expected, Clock.Clock.ComputeTime(degree, hours, minutes));
        }

        [TestMethod]
        public void TestDay()
        {
            string expected = "14:47";
            int hours = 14, minutes = 41;
            float degree = 162;

            Assert.AreEqual(expected, Clock.Clock.ComputeTime(degree, hours, minutes));
        }
    }
}
