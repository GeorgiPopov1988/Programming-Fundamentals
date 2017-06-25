using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            int b = int.Parse(Console.ReadLine());

            //Console.WriteLine($"{a}\n{b}");

            int c = b;
            b = a;
            a = c;

            Console.WriteLine($"{a}\n{b}");
        }
    }
}

