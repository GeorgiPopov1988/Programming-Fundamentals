using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int cnt1 = 0; cnt1 < num; cnt1++)
            {

                for (int cnt2 = 0; cnt2 < num; cnt2++)
                {

                    for (int cnt3 = 0; cnt3 < num; cnt3++)
                    {
                        char letter1 = (char)('a' + cnt1);
                        char letter2 = (char)('a' + cnt2);
                        char letter3 = (char)('a' + cnt3);

                        Console.WriteLine($"{letter1}{letter2}{letter3}");
                    }
                }
            }

        }
    }
}

