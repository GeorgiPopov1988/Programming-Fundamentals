using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Number_checker
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var numInput = int.Parse(Console.ReadLine());

                Console.WriteLine("It is a number.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid input!");

            }


        }
    }
}
