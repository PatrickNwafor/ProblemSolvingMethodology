using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingMethodology.Exercise1
{
    internal static class LinesOnPlaneTest
    {
        public static void GetVerticalLineTest()
        {
            List<Point2D> points = new List<Point2D>();
            points.Add(new Point2D(-2, 1));
            points.Add(new Point2D(0, 1));
            points.Add(new Point2D(2, 2));
            points.Add(new Point2D(-1, -1));
            points.Add(new Point2D(2, -2));

            LinesOnPlane lines = new LinesOnPlane(points);
            Dictionary<int, List<int>> dictionary = lines.VerticalLine();
            PrintHasMapPoints(dictionary);
        }

        public static void GetHorizontalLineTest()
        {
            List<Point2D> points = new List<Point2D>();
            points.Add(new Point2D(-2, 1));
            points.Add(new Point2D(0, 3));
            points.Add(new Point2D(2, 2));
            points.Add(new Point2D(-1, -1));
            points.Add(new Point2D(2, -2));

            LinesOnPlane lines = new LinesOnPlane(points);
            Dictionary<int, List<int>> dictionary = lines.HorizontalLine();
            PrintHasMapPoints(dictionary);
        }

        private static void PrintHasMapPoints(Dictionary<int, List<int>> points)
        {
            foreach (var point in points)
            {
                Console.Write("{0}: ", point.Key);

                foreach (var value in point.Value)
                {
                    Console.Write("{0} ", value);
                }
                Console.WriteLine();
            }
        }

        public static void TestPointsListToHashMap()
        {
            Random random = new Random();
            List<Point2D> points = new List<Point2D>();

            for(int i = 0; i < 10; i++)
            {
                int x = random.Next(-10, 10);
                int y = random.Next(-10, 10);
                points.Add(new Point2D(x, y));
            }

            LinesOnPlane lines = new LinesOnPlane(points);
            lines.VerticalLine();
        }

        public static void EqualityAtBothSideOfLineTest()
        {
            List<Point2D> points = new List<Point2D>();
            points.Add(new Point2D(-2, 1));
            points.Add(new Point2D(0, 1));
            points.Add(new Point2D(2, 2));
            points.Add(new Point2D(-1, -1));
            points.Add(new Point2D(2, -2));

            LinesOnPlane lines = new LinesOnPlane(points);
            lines.VerticalLine();
        }
    }
}
