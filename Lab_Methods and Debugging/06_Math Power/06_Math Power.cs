using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());

            double poweredNum = NumOnPower(num, power);
            Console.WriteLine(poweredNum);
        }

        static double NumOnPower(double num, double power)
        {
            double result = 1.0;
            for (double i = 0; i < power; i++)
            {
                result *= num;
            }
            return result;
        }
    }
}
