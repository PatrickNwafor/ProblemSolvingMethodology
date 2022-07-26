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
            Console.WriteLine("Get Vertical Line Test:");
            List<Point2D> points = new List<Point2D>();
            points.Add(new Point2D(-2, 1));
            points.Add(new Point2D(0, 1));
            points.Add(new Point2D(2, 2));
            points.Add(new Point2D(-1, -1));
            points.Add(new Point2D(2, -2));

            LinesOnPlane lines = new LinesOnPlane(points);
            Dictionary<int, List<int>> dictionary = lines.VerticalLine();
            if(dictionary.Count > 0)
            {
                PrintHasMapPoints(dictionary);
            }
            else
            {
                Console.WriteLine("No Vertical Line found that has equal number of points at both side of the line");
            }
        }

        public static void GetHorizontalLineTest()
        {
            Console.WriteLine("Get Horizontal Line Test:");
            List<Point2D> points = new List<Point2D>();
            points.Add(new Point2D(-2, 1));
            points.Add(new Point2D(0, 3));
            points.Add(new Point2D(2, 2));
            points.Add(new Point2D(-1, -1));
            points.Add(new Point2D(2, -2));

            LinesOnPlane lines = new LinesOnPlane(points);
            Dictionary<int, List<int>> dictionary = lines.HorizontalLine();
            if (dictionary.Count > 0)
            {
                PrintHasMapPoints(dictionary);
            }
            else
            {
                Console.WriteLine("No Horizontal Line found that has equal number of points at both side of the line");
            }
        }

        public static void PerformanceTest()
        {
            Console.WriteLine("Performance test with 100,000 points");
            DateTime startTime = DateTime.Now;
            Random random = new Random();
            List<Point2D> points = new List<Point2D>();

            for (int i = 0; i < 100000; i++)
            {
                int x = random.Next(-20, 20);
                int y = random.Next(-20, 20);
                points.Add(new Point2D(x, y));
            }

            LinesOnPlane lines = new LinesOnPlane(points);
            var dictionary = lines.VerticalLine();
            DateTime endTime = DateTime.Now;
            Console.WriteLine("Execution Time is: {0}", endTime - startTime);

            if (dictionary.Count > 0)
            {
                PrintHasMapPoints(dictionary);
            }
            else
            {
                Console.WriteLine("No Vertical Line found that has equal number of points at both side of the line");
            }
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
