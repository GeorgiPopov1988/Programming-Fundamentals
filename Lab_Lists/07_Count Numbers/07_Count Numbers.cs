using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputNumers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            inputNumers.Sort();
            inputNumers.Add(int.MaxValue); // Or 37 line.

            var counter = 1;

            for (int cnt = 0; cnt < inputNumers.Count - 1; cnt++)
            {
                if (inputNumers[cnt] == inputNumers[cnt + 1])
                {
                    counter++;
                }
                else
                {
                    Console.WriteLine($"{inputNumers[cnt]} -> {counter}");
                    counter = 1;
                }

            }

            // Console.WriteLine($"{inputNumers[inputNumers.Count - 1]} -> {counter}");
        }
    }
}
