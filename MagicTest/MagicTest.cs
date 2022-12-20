using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace MagicTest
{
    [TestClass]
    public class MagicTest
    {
        [TestMethod]
        public void Empty()
        {
            for (int i = 0; i < 10; i++)
                if (i != 5)
                    Assert.AreEqual(0, Magic.Magic.GetAllMagics(i).Count);

            
        }

        [TestMethod]
        public void Central5()
        {
            int centralNum = 5;
            List<int[,]> magicSquares = Magic.Magic.GetAllMagics(centralNum);

            foreach (var matrix in magicSquares)
                Assert.IsTrue(Magic.Magic.isMagic(matrix));
            
        }
    }
}
