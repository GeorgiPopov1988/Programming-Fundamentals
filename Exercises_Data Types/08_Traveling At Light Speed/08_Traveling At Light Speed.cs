using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Traveling_At_Light_Speed
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal lightYearsInput = decimal.Parse(Console.ReadLine());

            decimal lightYearInKm = 9450000000000M;
            decimal speedOfLight = 300000M;

            decimal total = (lightYearInKm / speedOfLight) * lightYearsInput;


            TimeSpan time = TimeSpan.FromSeconds((double)total);
            string formatted = string.Format(
                  CultureInfo.CurrentCulture,
                  "{0} weeks\n{1} days\n{2} hours\n{3} minutes\n{4} seconds\n",
                  time.Days / 7,
                  time.Days % 7,
                  time.Hours,
                  time.Minutes,
                  time.Seconds);

            Console.WriteLine(formatted);
        }
    }
}
