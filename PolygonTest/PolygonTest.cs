using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using static Polygon.Polygon;
using System.Collections.Generic;

namespace PolygonTest
{
    [TestClass]
    public class PolygonTest
    {
        [TestMethod]
        public void OnTheEdge()
        {
            float[] xCoords = { -5f, 12f, 9f, 5f };
            float[] yCoords = { 0f, 5f, 5f, 10f };

            float xPoint = 0f, yPoint = 5f;

            bool expected = true;

            List<Point> poly = new List<Point>();
            Point point = new Point(xPoint, yPoint);

            for (int i = 0; i < xCoords.Length; i++)
                poly.Add(new Point(xCoords[i], yCoords[i]));

            Assert.AreEqual(expected, Polygon.Polygon.IsInside(poly, point));
        }
        [TestMethod]
        public void CoincidingWithEdgeInside()
        {
            float[] xCoords = { -4f, 9f, 9f, 4f, -3f };
            float[] yCoords = { -6f, -2f, 5f, 5f, 10f };

            float xPoint = 0f, yPoint = 5f;

            bool expected = true;

            List<Point> poly = new List<Point>();
            Point point = new Point(xPoint, yPoint);

            for (int i = 0; i < xCoords.Length; i++)
                poly.Add(new Point(xCoords[i], yCoords[i]));

            Assert.AreEqual(expected, Polygon.Polygon.IsInside(poly, point));
        }

        [TestMethod]
        public void CoincidingWithEdgeOutside()
        {
            float[] xCoords = { -4f, 9f, 9f, 4f, -3f };
            float[] yCoords = { -6f, -2f, 5f, 5f, 10f };

            float xPoint = -1000f, yPoint = 5f;

            bool expected = false;

            List<Point> poly = new List<Point>();
            Point point = new Point(xPoint, yPoint);

            for (int i = 0; i < xCoords.Length; i++)
                poly.Add(new Point(xCoords[i], yCoords[i]));

            Assert.AreEqual(expected, Polygon.Polygon.IsInside(poly, point));
        }
        [TestMethod]
        public void CoincidingWithEdge_OnTheVertex()
        {
            float[] xCoords = { -4f, 10f, 10f, 10f, -3f, 0f, 5f };
            float[] yCoords = { -5f, 0f, 5f, 10f, 10f, 4f, 4f };

            float xPoint = 0f, yPoint = 4f;

            bool expected = true;

            List<Point> poly = new List<Point>();
            Point point = new Point(xPoint, yPoint);

            for (int i = 0; i < xCoords.Length; i++)
                poly.Add(new Point(xCoords[i], yCoords[i]));

            Assert.AreEqual(expected, Polygon.Polygon.IsInside(poly, point));
        }

        [TestMethod]
        public void SeveralPointsOnTheCoincidingEdge()
        {
            float[] xCoords = { -10f, -5f, 0f, 0f, -5f, -10f, -15f, -15f };
            float[] yCoords = { 0f, 0f, 0f, 10f, 10f, 10f, 10f, 0f };

            float xPoint = -15f, yPoint = 0f;

            bool expected = true;

            List<Point> poly = new List<Point>();
            Point point = new Point(xPoint, yPoint);

            for (int i = 0; i < xCoords.Length; i++)
                poly.Add(new Point(xCoords[i], yCoords[i]));

            Assert.AreEqual(expected, Polygon.Polygon.IsInside(poly, point));
        }
    }
}
