using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Circle_Perimeter_12DigitsPrecision
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());

            double circlePerimeter = 2 * Math.PI * radius;

            Console.WriteLine("{0:F12}", circlePerimeter);
        }
    }
}

