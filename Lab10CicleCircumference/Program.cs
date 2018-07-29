using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometry.Library;

namespace Excersise43CalcDistance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Post-continue what was the number of circles built?
            int CirclesBuilt = 0;

            var Repeat = true;
            while (Repeat)
            {
                //Enter a radius plz
                Console.WriteLine("I make circles from radius inputs, gimme a radius");
                string RadiusInput = Console.ReadLine();

                if (!double.TryParse(RadiusInput, out var radius))
                {
                    //What's this data? INVALID!
                    Console.WriteLine($"hey now, {RadiusInput} isn't a number I can use for making circles\nTry again please");
                    continue;
                }

                var Circle = new Circle(radius);
                Console.WriteLine($"the area is: {Circle.CalculateFormattedArea()}");
                Console.WriteLine($"the circumference is: {Circle.CalculateFormattedCircumference()}");

                Repeat = RetryPrompt.Retry();

                CirclesBuilt ++;
                Console.WriteLine($"Number of circles built:{CirclesBuilt}");
                Console.ReadLine();
            }
        }
    }
}
