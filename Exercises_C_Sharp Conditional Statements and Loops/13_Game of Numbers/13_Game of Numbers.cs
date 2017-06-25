using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numN = int.Parse(Console.ReadLine());
            var numM = int.Parse(Console.ReadLine());
            var magicalNum = int.Parse(Console.ReadLine());

            var combinationsCounter = 0;
            var currentSum = 0;
            var sum = 0;
            var numOne = 0;
            var numTwo = 0;


            for (int i = numN; i <= numM; i++)
            {

                for (int x = numN; x <= numM; x++)
                {
                    currentSum = i + x;

                    if (currentSum == magicalNum)
                    {
                        numOne = i;
                        numTwo = x;
                        sum = currentSum;
                    }
                    combinationsCounter++;
                }

            }

            if (sum != 0)
            {
                Console.WriteLine($"Number found! {numOne} + {numTwo} = {magicalNum}");
            }
            else
            {
                Console.WriteLine($"{combinationsCounter} combinations - neither equals {magicalNum}");
            }

        }
    }
}
