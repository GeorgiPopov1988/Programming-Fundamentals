using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var theIntegr = int.Parse(Console.ReadLine());
            var startOf = int.Parse(Console.ReadLine());

            if (startOf <= 10)
            {
                for (int i = startOf; i <= 10; i++)
                {

                    var times = i;
                    var product = theIntegr * times;
                    Console.WriteLine($"{theIntegr} X {times} = {product}");

                }
            }
            else
            {
                var times = startOf;
                var product = theIntegr * times;
                Console.WriteLine($"{theIntegr} X {times} = {product}");
            }


        }
    }
}

