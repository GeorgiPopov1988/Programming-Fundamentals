using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            var theIntegre = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                var times = i;
                var product = theIntegre * times;
                Console.WriteLine($"{theIntegre} X {times} = {product}");
            }


        }
    }
}
