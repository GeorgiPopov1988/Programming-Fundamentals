using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Megapixels
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            double result = (width * height) / 1000000.0;

            Console.WriteLine($"{width}x{height} => {Math.Round(result, 1)}MP");

        }
    }
}
