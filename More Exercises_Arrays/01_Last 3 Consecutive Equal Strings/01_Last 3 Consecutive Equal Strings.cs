using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Last_3_Consecutive_Equal_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            string output = string.Empty;

            for (int cnt = 0; cnt < input.Length - 2; cnt++)
            {
                if (input[cnt] == input[cnt + 1] && input[cnt] == input[cnt + 2])
                {
                    output = input[cnt];
                }
            }

            Console.WriteLine("{0} {0} {0}", output);
        }
    }
}


