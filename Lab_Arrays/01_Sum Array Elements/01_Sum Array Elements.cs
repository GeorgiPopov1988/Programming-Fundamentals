using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Sum_Array_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int elementsQuantity = int.Parse(Console.ReadLine());

            int[] array = new int[elementsQuantity];

            for (int cnt = 0; cnt < array.Length; cnt++)
            {
                array[cnt] = int.Parse(Console.ReadLine());
            }

            int sum = 0;

            for (int cnt = 0; cnt < array.Length; cnt++)
            {
                sum += array[cnt];
            }
            Console.WriteLine(sum);
        }
    }
}
