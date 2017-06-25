using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Count_of_Capital_Letters_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var stringArr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var singleLetter = stringArr
                .Where(single => single.Length == 1)
                .ToArray();

            var counter = 0;

            foreach (var letters in singleLetter)
            {
                var currentChar = char.Parse(letters);

                if (currentChar >= 65 && currentChar <= 90)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
