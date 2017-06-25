using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Multiply_an_Array_of_Doubles
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double multipler = double.Parse(Console.ReadLine());

            string[] inputElements = input.Split(' ');
            double[] arrayNumbers = new double[inputElements.Length];

            for (int cnt = 0; cnt < arrayNumbers.Length; cnt++)
            {
                arrayNumbers[cnt] = double.Parse(inputElements[cnt]);
                arrayNumbers[cnt] *= multipler;
            }

            for (int cnt2 = 0; cnt2 < arrayNumbers.Length; cnt2++)
            {
                Console.Write(arrayNumbers[cnt2] + " ");
            }
            Console.WriteLine();
        }
    }
}
