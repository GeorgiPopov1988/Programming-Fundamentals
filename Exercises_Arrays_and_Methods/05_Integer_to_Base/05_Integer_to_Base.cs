using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Integer_to_Base
{
    class Program
    {
        static void Main(string[] args)
        {
            int numInput = int.Parse(Console.ReadLine());
            int toBase = int.Parse(Console.ReadLine());

            var numToBase = IntegreToBase(numInput, toBase);

            Console.WriteLine(numToBase);

        }

        static string IntegreToBase(int numInput, int toBase)
        {
            string result = string.Empty;
            

            while (numInput > 0)
            {
                int reminder = numInput % toBase;
                result = reminder + result;
                numInput = numInput / toBase;
            }
            return result;
        }
    }
}
