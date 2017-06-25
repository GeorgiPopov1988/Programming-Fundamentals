using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Equal_Sequence_of_Elements_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var result = string.Empty;

            for (int cnt = 0; cnt < arr.Length; cnt++)
            {
                if (arr[0] == (arr[cnt]))
                {
                    result = "Yes";
                }
                else
                {
                    result = "No";
                }
            }
            Console.WriteLine(result);
        }
    }
}
