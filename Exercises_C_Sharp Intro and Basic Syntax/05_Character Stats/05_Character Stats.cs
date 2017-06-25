using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5_Character_Stats
{
    class Problem5_Character_Stats
    {
        static void Main(string[] args)
        {
            string characterName = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            int healthLeftToMax = maxHealth - currentHealth;
            int energyLeftToMax = maxEnergy - currentEnergy;

            Console.WriteLine("Name: " + characterName);
            Console.WriteLine("Health: |" + new string('|', currentHealth) +
                                            new string('.', healthLeftToMax) + "|");
            Console.WriteLine("Energy: |" + new string('|', currentEnergy) +
                                            new string('.', energyLeftToMax) + "|");

        }
    }
}

