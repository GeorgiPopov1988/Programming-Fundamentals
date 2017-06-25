using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2_Add_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numA = int.Parse(Console.ReadLine());
            int numB = int.Parse(Console.ReadLine());

            var sum = numA + numB;

            Console.WriteLine($"{numA} + {numB} = {sum}");
        }
    }
}
