using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Draw_a_Filled_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            PrintHeaderRow(num);

            for (int i = 0; i < num - 2; i++)
            {
                PrintMiddleRow(num);
            }

            PrintHeaderRow(num);

        }

        private static void PrintMiddleRow(int num)
        {
            Console.Write('-');

            for (int cnt = 1; cnt < num; cnt++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine('-');
        }

        private static void PrintHeaderRow(int num)
        {
            Console.WriteLine(new string('-', num * 2));
        }
    }
}
