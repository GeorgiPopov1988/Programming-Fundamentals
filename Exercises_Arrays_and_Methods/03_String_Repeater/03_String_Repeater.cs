using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_String_Repeater
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int strCounter = int.Parse(Console.ReadLine());
            string repeatetString = RepeatetString(input, strCounter);

            Console.WriteLine(repeatetString);
            
        }

        static string RepeatetString(string input, int strCounter)
        {
            string resultString = string.Empty;

            for (int i = 0; i < strCounter; i++)
            {
                resultString += input;
            }

            return resultString;
        }
    }
}
