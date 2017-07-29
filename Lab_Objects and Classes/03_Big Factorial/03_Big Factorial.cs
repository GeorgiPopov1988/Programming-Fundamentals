using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _03_Big_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            BigInteger result = 1;

            for (int cnt = 2; cnt <= n; cnt++)
            {
                result *= cnt;
            }

            Console.WriteLine(result);


        }
    }
}
