namespace Problem_3___Nether_Realms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main()
        {
            string[] demons = Console.ReadLine()
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(n => n.Trim())
                .OrderBy(n => n)
                .ToArray();

            


            foreach (var demon in demons)
            {
                decimal health = 0;
                decimal damage = 0;
                string damagePattern = @"[+-]?\d+(?:\.?\d+)?";
                var damageNumbers = Regex.Matches(demon, damagePattern);

                foreach (Match match in damageNumbers)
                {
                    damage += decimal.Parse(match.Value);
                }

                char[] modifires = demon
                    .Where(m => m == '*' || m == '/')
                    .ToArray();

                foreach (char modifier in modifires)
                {
                    switch (modifier)
                    {
                        case '*':
                            {
                                damage *= 2;
                                break;
                            }
                        case '/':
                            {
                                damage /= 2;
                                break;
                            }
                    }
                }

                for (int i = 0; i < demon.Length; i++)
                {
                    char current = demon[i];

                    if (char.IsLetter(current))
                    {
                        health += current;
                    }
                }

                Console.WriteLine($"{demon} - {health} health, {damage:F2} damage");
            }
        }
    }
}
