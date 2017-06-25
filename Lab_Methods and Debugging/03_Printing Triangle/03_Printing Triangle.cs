using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            PrintingTriangle(num);
        }

        private static void PrintingTriangle(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                PrintingLine(i);
            }
            for (int i = num - 1; i >= 1; i--)
            {
                PrintingLine(i);
            }
        }

        private static void PrintingLine(int i)
        {
            for (int cnt = 1; cnt <= i; cnt++)
            {
                Console.Write(cnt + " ");
            }
            Console.WriteLine();
        }
    }
}
