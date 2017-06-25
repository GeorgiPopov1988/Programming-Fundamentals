using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new char[] { ' ' },
                 StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            for (int cnt = 0; cnt < input.Count - 1; cnt++)
            {

                if (input[cnt] == input[cnt + 1])
                {
                    var sum = input[cnt] + input[cnt + 1];

                    input[cnt + 1] = sum;

                    input.RemoveAt(cnt);

                    cnt = -1;

                }


            }
            Console.WriteLine(string.Join(" ", input));

        }
    }
}
