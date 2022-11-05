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
            string sex = "male";
            int number = 0;

            Assert.AreEqual(expected, Numbers.Numbers.Convert(number, sex).TrimEnd(' '));
        }

        [TestMethod]
        public void Test31()
        {
            string expected = "Treinta y Un";
            string sex = "male";
            int number = 31;

            Assert.AreEqual(expected, Numbers.Numbers.Convert(number, sex).TrimEnd(' '));
        }

        [TestMethod]
        public void Test123()
        {
            string expected = "Ciento Veintitres";
            string sex = "male";
            int number = 123;

            Assert.AreEqual(expected, Numbers.Numbers.Convert(number, sex).TrimEnd(' '));
        }

        [TestMethod]
        public void Test501()
        {
            string expected = "Quinientas Una";
            string sex = "female";
            int number = 501;

            Assert.AreEqual(expected, Numbers.Numbers.Convert(number, sex).TrimEnd(' '));
        }

        [TestMethod]
        public void Test111_111_111()
        {
            string expected = "Ciento Una Millones Ciento Una Mil Ciento Una";
            string sex = "female";
            int number = 111111111;

            Assert.AreEqual(expected, Numbers.Numbers.Convert(number, sex).TrimEnd(' '));
        }

        [TestMethod]
        public void Test987_654_321()
        {
            string expected = "Novecientas Ochenta y Siete Millones Sescientas Cincuenta y Cuatro Mil Trescientas Veintiuna";
            string sex = "female";
            int number = 987654321;

            Assert.AreEqual(expected, Numbers.Numbers.Convert(number, sex).TrimEnd(' '));
        }

        [TestMethod]
        public void Test999_999_999()
        {
            string expected = "Novecientos Noventa y Nueve Millones Novecientos Noventa y Nueve Mil Novecientos Noventa y Nueve";
            string sex = "male";
            int number = 999_999_999;

            Assert.AreEqual(expected, Numbers.Numbers.Convert(number, sex).TrimEnd(' '));
        }

        [TestMethod]
        public void Test10pow9()
        {
            string expected = "Mil Millones";
            string sex = "male";
            int number = 1_000_000_000;

            Assert.AreEqual(expected, Numbers.Numbers.Convert(number, sex).TrimEnd(' '));
        }
    }
}
