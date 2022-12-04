using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace BinaryTest
{
    [TestClass]
    public class BinaryTest
    {
        [TestMethod]
        public void Zero()
        {
            int number = 0;
            List<string> expected = new List<string> { "0", "1"};
            CollectionAssert.AreEquivalent(expected, Binary.Binary.Generate(number));
        }

        [TestMethod]
        public void One()
        {
            int number = 1;
            List<string> expected = new List<string> { "0", "1" };
            CollectionAssert.AreEquivalent(expected, Binary.Binary.Generate(number));
        }

        [TestMethod]
        public void PowerOfTwo64()
        {
            int number = 64;
            List<string> expected = new List<string> { "1000001", "1000000", "1000010", "1000100", "1001000", "1010000", "1100000", "0" };
            CollectionAssert.AreEquivalent(expected, Binary.Binary.Generate(number));
        }

        [TestMethod]
        public void Thousand()
        {
            int number = 1000;
            List<string> expected = new List<string> { "1111101000", "1111101001", "1111101010", "1111101100", "1111100000", "1111111000",
                "1111001000", "1110101000", "1101101000", "1011101000", "111101000" };

            CollectionAssert.AreEquivalent(expected, Binary.Binary.Generate(number));
        }

        [TestMethod]
        public void PowerOfTwo1024()
        {
            int number = 1024;
            List<string> expected = new List<string> { "10000000000", "10000000001", "10000000010", "10000000100", "10000001000", "10000010000",
                "10000100000", "10001000000", "10010000000", "10100000000", "11000000000", "0" };

            CollectionAssert.AreEquivalent(expected, Binary.Binary.Generate(number));
        }

        [TestMethod]
        public void AllOnes()
        {
            int number = 1023;
            List<string> expected = new List<string> { "1111111111", "1111111110", "1111111101", "1111111011", "1111110111", "1111101111",
                "1111011111", "1110111111", "1101111111", "1011111111", "111111111" };

            CollectionAssert.AreEquivalent(expected, Binary.Binary.Generate(number));
        }

        [TestMethod]
        public void AlternatingZeroOne()
        {
            int number = 682;
            List<string> expected = new List<string> { "1010101010", "1010101011", "1010101000", "1010101110", "1010100010",
                "1010111010", "1010001010", "1011101010", "1000101010", "1110101010", "10101010" };

            CollectionAssert.AreEquivalent(expected, Binary.Binary.Generate(number));
        }

        [TestMethod]
        public void AlternatingOneOneZeroZero()
        {
            int number = 819;
            List<string> expected = new List<string> { "1100110011", "1100110010", "1100110001", "1100110111", "1100111011", "1100100011",
                "1100010011", "1101110011", "1110110011", "1000110011", "100110011" };

            CollectionAssert.AreEquivalent(expected, Binary.Binary.Generate(number));
        }


    }
}
