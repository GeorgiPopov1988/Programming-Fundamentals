using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Photo_Gallery
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int size = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            string resolution = string.Empty;
            double transformedSize = 0;
            string unit = string.Empty;
            string orientation = string.Empty;

            if (size < 1000)
            {
                transformedSize = size;
                unit = "B";
            }
            else if (size < 1000 * 1000)
            {
                transformedSize = size / 1000.0;
                unit = "KB";
            }
            else if (size < 1000 * 1000 * 1000)
            {
                transformedSize = size / (1000 * 1000.0);
                unit = "MB";
            }

            if (width > height)
            {
                orientation = "landscape";
            }
            else if (width < height)
            {
                orientation = "portrait";
            }
            else
            {
                orientation = "square";
            }


            Console.WriteLine($"Name: DSC_{number.ToString().PadLeft(4, '0')}.jpg");
            Console.WriteLine($"Date Taken: {day:D2}/{month:D2}/{year} {hour:D2}:{minutes:D2}");
            Console.WriteLine($"Size: {transformedSize}{unit}");
            Console.WriteLine($"Resolution: {width}x{height} ({orientation})");

        }
    }
}
