using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Polygon
{
    public class Polygon
    {
        public struct Point
        {
            public float x;
            public float y;
            public Point(float _x, float _y) { x = _x; y = _y; }
        }
        public static bool IsInside(List<Point> poly, Point point)
        {
            // the ray is heading right

            bool c = false;
            int N = poly.Count;
            float xCross;           // coordinate X of point, where the ray crosses edge, Y = point.y

            // if it intersects, we just consider both points of the edge as a single point
            for (int i = 0; i < N; i++)
                if (poly[(i + 1) % N].y == poly[i].y && point.y == poly[i].y)
                {
                    poly.RemoveAt(poly[(i + 1) % N].x == point.x ? i : (i + 1) % N);
                    N = poly.Count;
                    i--;
                }

            for (int i = 0; i < N; i++)
            {
                // we skip the edge if it is parallel to the ray
                if (poly[(i + 1) % N].y == poly[i].y && point.y != poly[i].y)
                    continue;

                // x coordinate where the ray crosses the edge
                xCross = (point.y - poly[i].y) * (poly[(i + 1) % N].x - poly[i].x)
                    / (poly[(i + 1) % N].y - poly[i].y) + poly[i].x;

                float xMin = Math.Min(poly[i].x, poly[(i + 1) % N].x);
                float xMax = Math.Max(poly[i].x, poly[(i + 1) % N].x);

                // intersection with vertex
                if (xCross == poly[i].x || xCross == poly[(i + 1) % N].x)
                {
                    // if it coincides the vertex => it is inside
                    if (poly[i].x == point.x || poly[(i + 1) % N].x == point.x)
                        return true;

                    // count only if it intersect the highest point of edge
                    else if (point.y == Math.Max(poly[i].y, poly[(i + 1) % N].y))
                        c = !c;
                }
                // intersection with edge 
                else if (xCross >= point.x && xMin < xCross && xCross < xMax)
                {
                    // if it is on the edge => it is inside
                    if (xCross == point.x)
                        return true;
                    else c = !c;
                }
            }

            return c;
        }
        static void Main(string[] args)
        {
            float[] coord;
            int N;

            List<Point> poly = new List<Point>();
            Point point;
            do
            {
                Console.Write("Enter number of points in polygon: ");
                N = int.Parse(Console.ReadLine());

                Console.WriteLine("\nEnter coordinates of each point in the following format: x y\n");

                for (int i = 0; i < N; i++)
                {
                    coord = Console.ReadLine().Split().Select(float.Parse).ToArray();
                    poly.Add(new Point(coord[0], coord[1]));
                }
                Console.WriteLine("\nEnter coordinates of point you want to check\n");
                coord = Console.ReadLine().Split().Select(float.Parse).ToArray();

                point = new Point(coord[0], coord[1]);

                Console.WriteLine($"\nPoint is {(IsInside(poly, point) ? "in" : "out")}side");
                Console.WriteLine("\n--------------------------\n");
            } while (true);
        }
    }
}
