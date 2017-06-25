using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_SMS_Typing
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputCnt = int.Parse(Console.ReadLine());

            for (int cnt = 0; cnt < inputCnt; cnt++)
            {
                string input = Console.ReadLine();
                int currentDigit = 0;
                if (input.Length > 0)
                {
                    currentDigit = input[0] - '0';  // Взимаме пътвия символ от масива (string-a) input. -0 или - 48.
                }
                else
                {
                    Debug.Assert(false);
                }

                int charIndex = (currentDigit - 2) * 3 + (input.Length - 1);

                if (currentDigit == 8 || currentDigit == 9)
                {
                    charIndex += 1;
                }
                if (currentDigit == 0)
                {
                    Console.Write(' ');
                }
                else
                {
                    Console.Write((char)(charIndex + 'a')); // Може да се напише и "+ 97" защото а = 97 в АСКИ
                }
            }
            Console.WriteLine();
        }
    }
}
