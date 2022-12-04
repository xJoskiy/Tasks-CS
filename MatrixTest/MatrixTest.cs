using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MatrixTest
{
    [TestClass]
    public class MatrixTest
    {
        [TestMethod]
        public void TestDim2()
        {
            int[,] arr;
            const int dim = 2;
            int[,] expected = new int[dim, dim] { { 1, 2 },
                                              { 3, 4} };
            Matrix.Matrix.Initialize(out arr, dim);
            Matrix.Matrix.Rotate(arr);

            CollectionAssert.AreEqual(expected, arr);
        }

        [TestMethod]
        public void TestDim3()
        {
            int[,] arr;
            const int dim = 3;
            int[,] expected = new int[dim, dim] { { 1, 4, 3 },
                                              { 8, 5, 2 },
                                              { 7, 6, 9 } };
            Matrix.Matrix.Initialize(out arr, dim);
            Matrix.Matrix.Rotate(arr);

            CollectionAssert.AreEqual(expected, arr);
        }

        [TestMethod]
        public void TestDim4()
        {
            int[,] arr;
            const int dim = 4;
            int[,] expected = new int[dim, dim] { {1, 9, 5, 4 },
                                              { 14, 6, 7, 2 },
                                              { 15, 10, 11, 3 },
                                              { 13, 12, 8, 16} };
            Matrix.Matrix.Initialize(out arr, dim);
            Matrix.Matrix.Rotate(arr);

            CollectionAssert.AreEqual(expected, arr);
        }

        [TestMethod]
        public void TestDim5()
        {
            int[,] arr;
            const int dim = 5;
            int[,] expected = new int[dim, dim] { { 1, 16, 11, 6, 5},
                                              { 22, 7, 12, 9, 2},
                                              { 23, 18, 13, 8, 3 },
                                              { 24, 17, 14, 19, 4 },
                                              { 21, 20, 15, 10, 25 } };
            Matrix.Matrix.Initialize(out arr, dim);
            Matrix.Matrix.Rotate(arr);

            CollectionAssert.AreEqual(expected, arr);
        }
        
        [TestMethod]
        public void TestDim6()
        {
            int[,] arr;
            const int dim = 6;
            int[,] expected = new int[dim, dim] { {1, 25, 19, 13, 7, 6},
                                                  {32, 8, 20, 14, 11, 2},
                                                  {33, 27, 15, 16, 9, 3},
                                                  {34, 28, 21, 22, 10, 4},
                                                  {35, 26, 23, 17, 29, 5},
                                                  {31, 30, 24, 18, 12, 36}, };
            Matrix.Matrix.Initialize(out arr, dim);
            Matrix.Matrix.Rotate(arr);

            CollectionAssert.AreEqual(expected, arr);
        }

        [TestMethod]
        public void TestDim7()
        {
            int[,] arr;
            const int dim = 7;
            int[,] expected = new int[dim, dim] { {1, 36, 29, 22, 15, 8, 7},
                                                {44, 9, 30, 23, 16, 13, 2},
                                                {45, 38, 17, 24, 19, 10, 3},
                                                {46, 39, 32, 25, 18, 11, 4},
                                                {47, 40, 31, 26, 33, 12, 5},
                                                {48, 37, 34, 27, 20, 41, 6},
                                                {43, 42, 35, 28, 21, 14, 49} };
            Matrix.Matrix.Initialize(out arr, dim);
            Matrix.Matrix.Rotate(arr);

            CollectionAssert.AreEqual(expected, arr);
        }
    }
}
