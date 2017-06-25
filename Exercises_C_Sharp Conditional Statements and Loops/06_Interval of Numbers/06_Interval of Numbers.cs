using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Interval_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numOne = int.Parse(Console.ReadLine());
            var numTwo = int.Parse(Console.ReadLine());

            var biggerNum = 0;
            var smallNum = 0;

            if (numOne > numTwo)
            {
                biggerNum = numOne;
                smallNum = numTwo;
            }
            else
            {
                biggerNum = numTwo;
                smallNum = numOne;
            }

            for (int i = smallNum; i <= biggerNum; i++)
            {
                Console.WriteLine(i);
            }


        }
    }
}

