using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Rotate_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(' ');

            string[] resultArr = new string[input.Length];


            for (int cnt = 0; cnt < input.Length - 1; cnt++)
            {
                resultArr[cnt + 1] = input[cnt];        // resultArr[(cnt + 1) % arr.Length] = input[cnt];
            }
            resultArr[0] = input[input.Length - 1];      // No need! ^^^

            Console.WriteLine(string.Join(" ", resultArr));
        }
    }
}
