using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numCounter = 0;

            try
            {
                while (true)
                {
                    var numInput = int.Parse(Console.ReadLine());
                    numCounter++;
                }

            }
            catch (Exception)
            {
                Console.WriteLine(numCounter);

            }



        }
    }
}
