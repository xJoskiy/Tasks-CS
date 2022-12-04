using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using static Polygon.Polygon;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace PolygonTest
{
    [TestClass]
    public class PolygonTest
    {

        // сделать метод для инициализации
        void InitAndCheck(bool expected, float[] xCoords, float[] yCoords, float xPoint, float yPoint)
        {
            List<Point> poly = new List<Point>();
            Point point = new Point(xPoint, yPoint);

            for (int i = 0; i < xCoords.Length; i++)
                poly.Add(new Point(xCoords[i], yCoords[i]));

            Assert.AreEqual(expected, Polygon.Polygon.IsInside(poly, point));
        }

        [TestMethod]
        public void OnTheEdge()
        {
            float[] xCoords = { -5f, 12f, 9f, 5f };
            float[] yCoords = { 0f, 5f, 5f, 10f };

            float xPoint = 0f, yPoint = 5f;

            bool expected = true;

            InitAndCheck(expected, xCoords, yCoords, xPoint, yPoint);
            
        }

        [TestMethod]
        public void CoincidingWithEdgeInside()
        {
            float[] xCoords = { -4f, 9f, 9f, 4f, -3f };
            float[] yCoords = { -6f, -2f, 5f, 5f, 10f };

            float xPoint = 0f, yPoint = 5f;

            bool expected = true;

            InitAndCheck(expected, xCoords, yCoords, xPoint, yPoint);
        }

        [TestMethod]
        public void CoincidingWithEdgeOutside()
        {
            float[] xCoords = { -4f, 9f, 9f, 4f, -3f };
            float[] yCoords = { -6f, -2f, 5f, 5f, 10f };

            float xPoint = -1000f, yPoint = 5f;

            bool expected = false;

            InitAndCheck(expected, xCoords, yCoords, xPoint, yPoint);
        }

        [TestMethod]
        public void CoincidingWithEdge_OnTheVertex()
        {
            float[] xCoords = { -4f, 10f, 10f, 10f, -3f, 0f, 5f };
            float[] yCoords = { -5f, 0f, 5f, 10f, 10f, 4f, 4f };

            float xPoint = 0f, yPoint = 4f;

            bool expected = true;

            InitAndCheck(expected, xCoords, yCoords, xPoint, yPoint);
        }

        [TestMethod]
        public void SeveralPointsOnTheCoincidingEdge()
        {
            float[] xCoords = { -10f, -5f, 0f, 0f, -5f, -10f, -15f, -15f };
            float[] yCoords = { 0f, 0f, 0f, 10f, 10f, 10f, 10f, 0f };

            float xPoint = -15f, yPoint = 0f;

            bool expected = true;

            InitAndCheck(expected, xCoords, yCoords, xPoint, yPoint);
        }

        [TestMethod]
        public void StrangeStarOutside()
        {
            float[] xCoords = { -12.75f, -18f, 4.6f, 7.7f, -10.9f, -9.5f, -15.65f, -32.35f };
            float[] yCoords = { -15.4f, -1f, 0.9f, 6.3f, 1.3f, 18.15f, 1.3f, 15.4f };

            float xPoint = -26.57f, yPoint = 6.3f;

            bool expected = false;

            InitAndCheck(expected, xCoords, yCoords, xPoint, yPoint);
        }

        [TestMethod]
        public void CrownOutside()
        {
            float[] xCoords = { 9.75f, 4.5f, 0f, -4.5f, -9.75f, -11.5f, -19.75f, -17f, -17f, 17f, 17f, 19.75f, 11.5f};
            float[] yCoords = { 14f, 1.5f, 20f, 1.5f, 14f, 1.5f, 11f, -4.5f, -9f, -9f, -4.5f, 11f, 1.5f};

            float xPoint = -30f, yPoint = 1.5f;

            bool expected = false;

            InitAndCheck(expected, xCoords, yCoords, xPoint, yPoint);
        }

        [TestMethod]
        public void TriangleOutside()
        {
            float[] xCoords = { 0f, -10f, 10f};
            float[] yCoords = { 20f, 0f, 0f};

            float xPoint = -5.7f, yPoint = 20f;

            bool expected = false;

            InitAndCheck(expected, xCoords, yCoords, xPoint, yPoint);
        }

        [TestMethod]
        public void ParallelOutside()
        {
            float[] xCoords = { -3f, -15f, 0f, 15f, 3f, 3f, -3f };
            float[] yCoords = { 0f, 0f, 15f, 0f, 0f, 4f, 4f };

            float xPoint = -20f, yPoint = 0f;

            bool expected = false;

            InitAndCheck(expected, xCoords, yCoords, xPoint, yPoint);
        }

        [TestMethod]
        public void ParallelOutside2()
        {
            float[] xCoords = { -3f, -15f, 0f, 15f, 3f, 3f, -3f };
            float[] yCoords = { 0f, 0f, 15f, 0f, 0f, 4f, 4f };

            float xPoint = 0f, yPoint = 0f;

            bool expected = false;

            InitAndCheck(expected, xCoords, yCoords, xPoint, yPoint);
        }

        [TestMethod]
        public void CloseToZeroInside()
        {
            float[] xCoords = { -30f, -18f, -3f, -1f, -6f, -20f, -24f, -28f };
            float[] yCoords = { 0f, 0f, 0f, 0.02f, 0.01f, 0.01f, 0.01f, 0.01f };

            float xPoint = -29.05f, yPoint = 0.002f;

            bool expected = true;

            InitAndCheck(expected, xCoords, yCoords, xPoint, yPoint);
        }
    }
}
