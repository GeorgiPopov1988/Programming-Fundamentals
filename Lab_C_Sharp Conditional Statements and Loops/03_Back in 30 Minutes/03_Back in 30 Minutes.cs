using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Back_in_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());

            var add30min = 30;
            var minutesResult = minutes + add30min;

            var timeResult = string.Empty;

            if (minutesResult > 59)
            {
                hours++;
                minutesResult -= 60;
            }
            else if (minutesResult == 60)
            {
                hours++;
                minutesResult = 00;
            }

            if (hours > 23)
            {
                hours = 0;
            }

            Console.WriteLine($"{hours}:{minutesResult:D2}");
        }
    }
}
