using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3_Miles_to_Kilometers
{
    class Problem3_Miles_to_Kilometers
    {
        static void Main(string[] args)
        {
            //1 mile == 1.60934 kilometers

            double miles = double.Parse(Console.ReadLine());

            double milesToKilometers = miles * 1.60934;

            Console.WriteLine($"{milesToKilometers:F2}");
        }
    }
}
