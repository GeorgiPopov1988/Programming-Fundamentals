using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;


            for (int i = 1; i <= n; i++)
            {
                var resultForPrint = (i * 2) - 1;
                Console.WriteLine(resultForPrint);

                sum = sum + (i * 2) - 1;
            }

            Console.WriteLine("Sum: " + sum);

        }
    }
}
