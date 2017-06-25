using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numN = int.Parse(Console.ReadLine());
            var numM = int.Parse(Console.ReadLine());
            var maxSum = int.Parse(Console.ReadLine());

            var combinationsCounter = 0;
            var sum = 0;

            for (int x = numN; x >= 1; x--)
            {

                for (int y = 1; y <= numM; y++)

                {
                    combinationsCounter++;
                    sum += (x * y) * 3;

                    if (sum >= maxSum)
                    {

                        Console.WriteLine($"{combinationsCounter} combinations");
                        Console.WriteLine($"Sum: {sum} >= {maxSum}");

                        return;
                    }

                }
            }
            Console.WriteLine($"{combinationsCounter} combinations");
            Console.WriteLine($"Sum: {sum}");

        }
    }
}
