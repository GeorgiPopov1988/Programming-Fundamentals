using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Odd_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = 0;

            while (true)
            {
                num = Math.Abs(int.Parse(Console.ReadLine()));

                if (num % 2 == 1)
                {
                    Console.WriteLine($"The number is: {num}");
                    break;
                }
                Console.WriteLine("Please write an odd number.");
            }


        }
    }
}
