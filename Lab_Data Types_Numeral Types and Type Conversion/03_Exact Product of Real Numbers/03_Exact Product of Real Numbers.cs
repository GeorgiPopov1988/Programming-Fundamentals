using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Exact_Product_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numCnt = int.Parse(Console.ReadLine());

            decimal result = 1;

            for (int cnt = 0; cnt < numCnt; cnt++)
            {
                decimal numForExact = decimal.Parse(Console.ReadLine());

                result *= numForExact;
            }
            Console.WriteLine(result);
        }
    }
}
