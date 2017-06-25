using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Increasing_Sequence_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var bigger = int.MinValue;

            for (int cnt = 0; cnt < arr.Length; cnt++)
            {
                if (bigger < arr[cnt])
                {
                    bigger = arr[cnt];
                }
                else
                {
                    Console.WriteLine("No");
                    return;
                }
            }
            Console.WriteLine("Yes");
        }
    }
}
