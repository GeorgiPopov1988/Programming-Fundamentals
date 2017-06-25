using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputNumbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(decimal.Parse)
                .ToList();

            inputNumbers.Sort();

            for (int cnt = 0; cnt < inputNumbers.Count; cnt++)
            {
                if (cnt == inputNumbers.Count - 1)
                {
                    Console.WriteLine(inputNumbers[cnt]);
                    break;
                }

                Console.Write($"{inputNumbers[cnt]} <= ");
            }


        }
    }
}
