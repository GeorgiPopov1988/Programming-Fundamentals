using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_From_Terabytes_to_Bits
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal imputNuminTerabytes = decimal.Parse(Console.ReadLine());

            decimal numInBytes = Math.Round(imputNuminTerabytes * (1024m * 1024m * 1024m * 1024m * 8m));

            Console.WriteLine(numInBytes);
        }
    }
}

