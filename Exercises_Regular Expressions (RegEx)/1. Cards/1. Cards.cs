using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _1.Cards
{
    class Program
    {
        static void Main(string[] args)
        {
       
                string inputLine = Console.ReadLine();



                Regex validCards = new Regex(@"([1]?[0-9JQKA])([SHDC])");
                
                var matches = validCards.Matches(inputLine);

                List<string> output = new List<string>();
                foreach (Match match in matches)
                {

                    int power = 0;
                    if (int.TryParse(match.Groups[1].Value, out power))
                    {

                        if (power < 2 || power > 10)
                        {

                            continue;

                        }

                    }

                    output.Add(match.ToString());

                }

                Console.WriteLine(string.Join(", ", output));
        }
    }
 }
