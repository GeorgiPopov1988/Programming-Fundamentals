using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Magic_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstLetter = char.Parse(Console.ReadLine());
            var secondLetter = char.Parse(Console.ReadLine());
            var exceptLetter = char.Parse(Console.ReadLine());
            string result = string.Empty;

            for (char i = firstLetter; i <= secondLetter; i++)
            {
                for (char x = firstLetter; x <= secondLetter; x++)
                {
                    for (char y = firstLetter; y <= secondLetter; y++)
                    {

                        result = $"{i}{x}{y} ";
                        if (result.Contains(exceptLetter))
                        {
                            continue;
                        }
                        else
                        {
                            Console.Write(result);
                        }
                    }

                }
            }



        }
    }
}
