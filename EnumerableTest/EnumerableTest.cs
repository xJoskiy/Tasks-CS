using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text;

namespace EnumerableTest
{
    [TestClass]
    public class EnumerableTest
    {
        [TestMethod]
        public void TestLen1()
        {
            int len = 1;
            StringBuilder strToCompare = new StringBuilder("A");
            Enumerable.Permutations.PermutationsEnum permEnum = new Enumerable.Permutations.PermutationsEnum(len);
            for (int i = 0; i < 26; i++)
            {
                permEnum.MoveNext();
                Assert.AreEqual(strToCompare.ToString(), permEnum.Current.ToString());
                strToCompare[0] = (char)(strToCompare[0] + 1);
            }
        }

        [TestMethod]
        public void TestLen2()
        {
            int len = 2;
            StringBuilder strToCompare = new StringBuilder("AA");
            Enumerable.Permutations.PermutationsEnum permEnum = new Enumerable.Permutations.PermutationsEnum(len);
            for (int i = 0; i < 26; i++)
            {
                for (int j = 0; j < 26; j++)
                {
                    permEnum.MoveNext();
                    Assert.AreEqual(strToCompare.ToString(), permEnum.Current.ToString());
                    strToCompare[1] = (char)(strToCompare[1] + 1);
                }
                strToCompare[0] = (char)(strToCompare[0] + 1);
                strToCompare[1] = 'A';
            }
        }

        [TestMethod]
        public void TestLen3()
        {
            int len = 3;
            StringBuilder strToCompare = new StringBuilder("AAA");
            Enumerable.Permutations.PermutationsEnum permEnum = new Enumerable.Permutations.PermutationsEnum(len);
            for (int k = 0; k < 26; k++)
            {
                for (int i = 0; i < 26; i++)
                {
                    for (int j = 0; j < 26; j++)
                    {
                        permEnum.MoveNext();
                        Assert.AreEqual(strToCompare.ToString(), permEnum.Current.ToString());
                        strToCompare[len - 1] = (char)(strToCompare[len - 1] + 1);
                    }
                    strToCompare[1] = (char)(strToCompare[1] + 1);
                    strToCompare[2] = 'A';
                }
                strToCompare[0] = (char)(strToCompare[0] + 1);
                strToCompare[1] = 'A';
                strToCompare[2] = 'A';
            }
        }

    }
}
