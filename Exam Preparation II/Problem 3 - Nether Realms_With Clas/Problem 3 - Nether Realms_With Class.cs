namespace Proble_3___Nether_Realms_With_Class
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
            var demons = Console.ReadLine()
               .Split( ", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
               .Select(Demon.Parse)
               .OrderBy(n => n.Name)
               .ToArray();

            foreach (var demon in demons)
            {
                Console.WriteLine
                    ($"{demon.Name} - {demon.Helth} health, {demon.Damage:F2} damage");
            }
            
        }
    }

    class Demon
    {
        public string Name { get; set; }
        public decimal Helth { get; set; }
        public decimal Damage { get; set; }

        public static Demon Parse(string demonName)
        {
            var demon = new Demon();
            demon.Name = demonName;
            demon.Helth = CalculateHealth(demonName);
            demon.Damage = CalculateDamege(demonName);


            return demon;
        }

        private static decimal CalculateDamege(string demonName)
        {
            decimal damage = 0;

            string damagePattern = @"[+-]?\d+(?:\.?\d+)?";
            var damageNumbers = Regex.Matches(demonName, damagePattern);

            foreach (Match match in damageNumbers)
            {
                damage += decimal.Parse(match.Value);
            }

            char[] modifires = demonName
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

            return damage;
        }

        private static decimal CalculateHealth(string demonName)
        {
            decimal health = 0;
            var healthRegex = @"[^0-9+\-*\/\.]";
            var healthChars = Regex.Matches(demonName, healthRegex);

            foreach (Match match in healthChars)
            {
                health += char.Parse(match.Value);
            }

            return health;
        }
    }
}
