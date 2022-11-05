using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MatrixTest
{
    [TestClass]
    public class MatrixTest
    {
        [TestMethod]
        public void TestDim3()
        {
            int[,] arr;
            int[,] expected = new int[3, 3] { { 1, 4, 3 },
                                              { 8, 5, 2 }, 
                                              { 7, 6, 9 } };
            int dim = 3;
            Matrix.Matrix.Initialize(out arr, dim);
            Matrix.Matrix.Rotate(arr);

            CollectionAssert.AreEqual(expected, arr);

        }

        [TestMethod]
        public void TestDim4()
        {
            int[,] arr;
            int[,] expected = new int[5, 5] { { 1, 16, 11, 6, 5},
                                              { 22, 7, 12, 9, 2},
                                              { 23, 18, 13, 8, 3 },
                                              { 24, 17, 14, 19, 4 },
                                              { 21, 20, 15, 10, 25 } };
            int dim = 5;
            Matrix.Matrix.Initialize(out arr, 5);
            Matrix.Matrix.Rotate(arr);

            CollectionAssert.AreEqual(expected, arr);

        }
    }
}
