using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Neighbour_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            var peshoDamage = int.Parse(Console.ReadLine());
            var goshoDamage = int.Parse(Console.ReadLine());

            var attacker = string.Empty;        // Pesho -> roundCounter %2 != 0; Gosho -> roundCounter %2 =0; 
            var attacked = string.Empty;
            var attackName = string.Empty;      // Pesho = "Roundhouse kick"; Gosho = "Thunderous fist";

            var peshoHP = 100;
            var goshoHP = 100;

            var roundCounter = 0;

            for (int i = 1; ; i++)
            {

                if (roundCounter % 2 == 0)
                {

                    attacker = "Pesho";
                    attacked = "Gosho";
                    attackName = "Roundhouse kick";

                    goshoHP -= peshoDamage;

                    if (goshoHP <= 0)

                    {
                        roundCounter++;
                        Console.WriteLine($"Pesho won in {roundCounter}th round.");
                        break;
                    }

                    Console.WriteLine($"{attacker} used {attackName} " +
                                      $"and reduced {attacked} to " +
                                      $"{goshoHP} health.");

                    roundCounter++;

                    if (roundCounter % 3 == 0)
                    {
                        peshoHP += 10;
                        goshoHP += 10;
                    }

                }
                else
                {

                    attacker = "Gosho";
                    attacked = "Pesho";
                    attackName = "Thunderous fist";

                    peshoHP -= goshoDamage;

                    if (peshoHP <= 0)
                    {
                        roundCounter++;
                        Console.WriteLine($"Gosho won in {roundCounter}th round.");
                        break;
                    }

                    Console.WriteLine($"{attacker} used {attackName} " +
                                      $"and reduced {attacked} to " +
                                      $"{peshoHP} health.");

                    roundCounter++;

                    if (roundCounter % 3 == 0)
                    {
                        peshoHP += 10;
                        goshoHP += 10;
                    }
                }
            }
        }
    }
}
