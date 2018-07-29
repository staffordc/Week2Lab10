using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersise43CalcDistance
{
    public class Circle
    {

        double Radius { get; set; }

        public Circle (double radius)
        {
            Radius = radius;
        }

        public double CalculateCircumference()
        {
            return 2 * Math.PI * Radius;
        }
        public string CalculateFormattedCircumference()
        {
            return FormatNumber(CalculateCircumference());
        }
        public double CalculateArea()
        {
            return Math.PI*(Radius * Radius);
        }
        public string CalculateFormattedArea()
        {
            return FormatNumber(CalculateArea());
        }
        private string FormatNumber(double x) 
        {
            return x.ToString("N2");
        }
    }
}
