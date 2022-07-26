using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingMethodology.Exercise1
{
    internal class LinesOnPlane
    {
        private List<Point2D> pointsOnPlane;

        public LinesOnPlane(List<Point2D> pointsOnPlane)
        {
            this.pointsOnPlane = pointsOnPlane;
        }

        public List<Point2D> PointsOnPlane { get { return pointsOnPlane; }  set { pointsOnPlane = value; } }

        /// <summary>
        /// Gets Vertical Lines on a plane where points at both side of the lines are equal
        /// </summary>
        /// <returns>A hashmap which shows the number of vertical lines of which points at both sides of the lines are equal
        /// if hashmap count is zero, it means no vertical line was found where points at both sides are equal
        /// Hashmap format (Key -> X coordinate, Value -> List of Y coordinates)</returns>
        public Dictionary<int, List<int>> VerticalLine()
        {
            Dictionary<int, List<int>> points = MapPointsInHashMap(true);
            Dictionary<int, List<int>> LinesWithEqualPointsAtSides = new Dictionary<int, List<int>>();

            foreach (var point in points)
            {
                if(PointsEqualAtSidesOfLine(points, point.Key))
                {
                    LinesWithEqualPointsAtSides[point.Key] = point.Value;
                }
            }

            return LinesWithEqualPointsAtSides;
        }

        /// <summary>
        /// Gets Horizontal Lines on a plane where points at both side of the lines are equal
        /// </summary>
        /// <returns>A hashmap which shows the number of horizontal lines of which points at both sides of the lines are equal
        /// if hashmap count is zero, it means no horizontal line was found where points at both sides are equal
        /// Hashmap format (Key -> Y coordinate, Value -> List of X coordinates)</returns>
        public Dictionary<int, List<int>> HorizontalLine()
        {
            Dictionary<int, List<int>> points = MapPointsInHashMap(false);
            Dictionary<int, List<int>> LinesWithEqualPointsAtSides = new Dictionary<int, List<int>>();

            foreach (var point in points)
            {
                if (PointsEqualAtSidesOfLine(points, point.Key))
                {
                    LinesWithEqualPointsAtSides[point.Key] = point.Value;
                }
            }

            return LinesWithEqualPointsAtSides;
        }

        /// <summary>
        /// Stores List of points to a Hashmap
        /// </summary>
        /// <param name="verticalLines">This parameter indicates if we are arranging the hashmap to find 
        /// Vertical lines or horizontal lines.</param>
        /// <returns>Returns a hashmap with points having one coordinate as a key and a list of coordinate as a value</returns>
        private Dictionary<int, List<int>> MapPointsInHashMap(bool verticalLines)
        {
            Dictionary<int, List<int>> points = new Dictionary<int, List<int>>();

            foreach (var point in pointsOnPlane)
            {
                if (verticalLines)
                {
                    if (points.ContainsKey(point.X))
                    {
                        points[point.X].Add(point.Y);
                    }
                    else
                    {
                        points[point.X] = new List<int>();
                        points[point.X].Add(point.Y);
                    }
                }
                else
                {
                    if (points.ContainsKey(point.Y))
                    {
                        points[point.Y].Add(point.X);
                    }
                    else
                    {
                        points[point.Y] = new List<int>();
                        points[point.Y].Add(point.X);
                    }
                }
            }

            return points;
        }

        /// <summary>
        /// This method is used for test to confirm mapping the list of point to HashMap was 
        /// done correctly in the method MapPointsInHashMap(bool verticalLines)
        /// </summary>
        /// <param name="points">Mapped Points</param>
        private void PrintHasMapPoints(Dictionary<int, List<int>> points)
        {
            foreach (var point in points)
            {
                Console.Write("{0}: ", point.Key);

                foreach(var value in point.Value)
                {
                    Console.Write("{0} ", value);
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Used for testing. It shows if points at both side of the line are equal or not
        /// </summary>
        /// <param name="key">current line we are checking</param>
        /// <param name="isEqualAtBothSides">Bool telling if points at both side of lines are equal</param>
        private void PrintLineEqualityStatus(int key, bool isEqualAtBothSides)
        {
            Console.WriteLine("{0} : {1}", key, isEqualAtBothSides);
        }

        /// <summary>
        /// Returns a bool that says if the currently selected line has equal number of points at both side of the line
        /// </summary>
        /// <param name="points">Hashmap containing all points</param>
        /// <param name="currentKey">Current line we are checking for equality of point at bothSide</param>
        /// <returns>True if points at both side of lines are equal, otherwise false</returns>
        private bool PointsEqualAtSidesOfLine(Dictionary<int, List<int>> points, int currentKey)
        {
            int preLinePointCount = 0;
            int postLinePointCount = 0;

            foreach(var point in points)
            {
                if(point.Key != currentKey && point.Key < currentKey)
                {
                    preLinePointCount += point.Value.Count;
                }
                else if(point.Key != currentKey && point.Key > currentKey)
                {
                    postLinePointCount += point.Value.Count;
                }
            }

            if(preLinePointCount == postLinePointCount)
            {
                return true;
            }

            return false;
        }
    }
}
