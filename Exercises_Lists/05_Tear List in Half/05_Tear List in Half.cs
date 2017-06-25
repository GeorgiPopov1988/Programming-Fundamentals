using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Tear_List_in_Half
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var result = new List<int>();

            var partOneOfNumbers = numbers
                .Take(numbers.Count / 2)
                .ToList();

            var partTwoOfNumbers = numbers
                .Skip(numbers.Count / 2)
                .ToList();

            for (int cnt = 0; cnt < partTwoOfNumbers.Count; cnt++)
            {
                var currentNumOne = partOneOfNumbers[cnt];
                var currentNumTwo = partTwoOfNumbers[cnt];

                var resultFirstPlace = currentNumTwo / 10;
                var resultLastPlace = currentNumTwo % 10;

                result.Add(resultFirstPlace);
                result.Add(currentNumOne);
                result.Add(resultLastPlace);

            }

            Console.WriteLine(string.Join(" ", result));

        }
    }
}
