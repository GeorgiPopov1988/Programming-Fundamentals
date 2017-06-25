using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Smallest_Element_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfNumbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            double smallest = double.MaxValue;

            for (int cnt = 0; cnt < arrayOfNumbers.Length; cnt++)
            {
                if (arrayOfNumbers[cnt] < smallest)
                {
                    smallest = arrayOfNumbers[cnt];
                }

            }
            Console.WriteLine(smallest);

        }
    }
}
