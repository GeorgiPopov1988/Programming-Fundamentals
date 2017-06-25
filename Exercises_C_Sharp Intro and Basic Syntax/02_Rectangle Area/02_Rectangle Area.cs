using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2_Rectangle_Area
{
    class Problem2_Rectangle_Area
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double rectangleAreaIs = RectangleArea(width, height);
            Console.WriteLine($"{rectangleAreaIs:F2}");
        }

        private static double RectangleArea(double width, double height)
        {
            double area = width * height;
            return area;
        }
    }
}
