using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Array_Elements_Equal_to_Their_Index
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputNumbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            for (int cnt = 0; cnt < inputNumbers.Length; cnt++)
            {
                if (inputNumbers[cnt] == cnt)
                {
                    if (cnt == inputNumbers.Length - 1)
                    {
                        Console.Write($"{inputNumbers[cnt]}");
                        break;
                    }

                    Console.Write($"{inputNumbers[cnt]} ");
                }
            }
            Console.WriteLine();
        }
    }
}
