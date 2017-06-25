using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            int operandOne = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            int operandTwo = int.Parse(Console.ReadLine());
            int result = 0;

            switch (operation)
            {
                case "+":
                    result = operandOne + operandTwo;
                    break;
                case "-":
                    result = operandOne - operandTwo;
                    break;
                case "*":
                    result = operandOne * operandTwo;
                    break;
                case "/":
                    result = operandOne / operandTwo;
                    break;
            }
            Console.WriteLine($"{operandOne} {operation} {operandTwo} = {result}");
        }
    }
}
