using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greater_of_two_values
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();


            if (type == "int")
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());

                int result = GetMax(num1, num2);
                Console.WriteLine(result);
            }

            else if (type == "char")
            {
                char char1 = char.Parse(Console.ReadLine());
                char char2 = char.Parse(Console.ReadLine());

                char result = GetMax(char1, char2);
                Console.WriteLine(result);
            }

            else if (type == "string")
            {
                string str1 = Console.ReadLine();
                string str2 = Console.ReadLine();

                string result = GetMax(str1, str2);
                Console.WriteLine(result);
            }


        }

        static int GetMax(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1;
            }
            return num2;
        }

        static char GetMax(char char1, char char2)
        {
            if (char1 > char2)
            {
                return char1;
            }
            return char2;
        }

        static string GetMax(string str1, string str2)
        {
            if (str1.CompareTo(str2) >= 0)
            {
                return str1;
            }
            return str2;

        }
    }
}
