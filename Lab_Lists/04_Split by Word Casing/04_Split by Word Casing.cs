using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Split_by_Word_Casing
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new char[] { ',', ';', ' ', '.', ':', '!', '(', ')', '"', '\'', '\\', '/', '[', ']' },
                StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var lowerCaseResult = new List<string>();
            var upperCaseResult = new List<string>();
            var mixedCaseResult = new List<string>();

            for (int cnt = 0; cnt < input.Count; cnt++)
            {
                if (input[cnt].All(char.IsLower))
                {
                    lowerCaseResult.Add(input[cnt]);
                }
                else if (input[cnt].All(char.IsUpper))
                {
                    upperCaseResult.Add(input[cnt]);
                }
                else
                {
                    mixedCaseResult.Add(input[cnt]);
                }
            }
            Console.WriteLine($"Lower-case: {string.Join(", ", lowerCaseResult)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixedCaseResult)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upperCaseResult)}");
        }
    }
}

