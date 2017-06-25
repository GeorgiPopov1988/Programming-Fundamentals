using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Count_Occurrences_of_Larger_Numbers_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine()
                     .Split(' ')
                     .Select(double.Parse)
                     .ToArray();

            var num = double.Parse(Console.ReadLine());
            var counter = 0;
            for (int cnt = 0; cnt < arr.Length; cnt++)
            {
                if (arr[cnt] > num)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
