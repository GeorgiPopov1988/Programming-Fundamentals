using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Largest_Element_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var counter = int.Parse(Console.ReadLine());
            int[] arr = new int [counter];

            for (int i = 0; i < counter; i++)
            {
                int currentInput = int.Parse(Console.ReadLine());
                arr[i] = currentInput;
            }

            int biggest = int.MinValue;

            for (int cnt = 0; cnt < arr.Length; cnt++)
            {
                if (arr [cnt] > biggest)
                {
                    biggest = arr[cnt];
                }
            }
            Console.WriteLine(biggest);
        }
    }
}
