using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingMethodology.Exercise1
{
    internal class Point2D: IComparable<Point2D>
    {
        public int X { get; set; }  
        public int Y { get; set; }

        public Point2D()
        {
        }

        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int CompareTo(Point2D? other)
        {
            if (X == other.X)
            {
                return 0;
            }
            else if (X > other.X)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }
    }
}
