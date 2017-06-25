using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Triangle_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {

                for (int y = 1; y <= i; y++)
                {

                    Console.Write(" " + i);
                }
                Console.WriteLine();
            }



        }
    }
}
