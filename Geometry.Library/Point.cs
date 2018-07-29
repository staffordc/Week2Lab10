using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Library
{
    public class Point
    {
        public int X;
        public int Y;
        
        public Point (int x, int y)
        {
            X = x;
            Y = y;
        }
       
        public double CalculateDistance()
        {
            //var distance = Math.Sqrt(Math.Pow(x) + Math.Pow(y - b));
            var distance = Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
            return distance;
        }
    }
}
