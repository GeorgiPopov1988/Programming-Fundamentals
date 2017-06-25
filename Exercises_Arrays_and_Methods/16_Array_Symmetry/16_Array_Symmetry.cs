using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Array_Symmetry
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var lenght = text.Length / 2;
            var result = "Yes";

            for (int cnt = 0; cnt < lenght; cnt++)
            {
                var firstPart = text[cnt];
                var secondPart = text[text.Length - 1 - cnt];

                if (firstPart != secondPart)
                {
                    result = "No";
                    break;
                }
            }

            Console.WriteLine(result);
        }
    }
}
