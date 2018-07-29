using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Library
{
    public class Line
    {
        public Point Start;
        public Point End;
        public Line(Point start, Point end)
        {
            Start = start;
            End = end;
        }
        public double CalculateLength()
        {
            var xDiff = End.X - Start.X;
            var yDiff = End.Y - Start.Y;
            return Math.Sqrt(Math.Pow(xDiff, 2) + Math.Pow(yDiff, 2));
        }
    }
}
