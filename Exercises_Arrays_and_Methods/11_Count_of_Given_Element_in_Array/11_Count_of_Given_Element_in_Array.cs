using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Count_of_Given_Element_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine()
                     .Split(' ')
                     .Select(int.Parse)
                     .ToArray();

            int element = int.Parse(Console.ReadLine());
            var counter = 0;

            for (int cnt = 0; cnt < arr.Length; cnt++)
            {
                if (arr[cnt] == element)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
