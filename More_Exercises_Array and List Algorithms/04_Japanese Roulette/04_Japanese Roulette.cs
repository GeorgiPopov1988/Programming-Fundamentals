namespace _04_Japanese_Roulette
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main(string[] args)
        {
            int[] bullets = Console.ReadLine()
                .Split( ' ' )
                .Select(int.Parse)
                .ToArray();

            string[] players = Console.ReadLine()
                .Split( ' ' );

            bool isDead = false;
            int indexOfBullet = 0;

            for (int i = 0; i < bullets.Length; i++)
            {
                if (bullets[i] == 1)
                {
                    indexOfBullet = i;
                    break;
                }
            }

            for (int i = 0; i < players.Length; i++)
            {
                string[] tokens = players[i].Split(',');
                string directions = tokens[1];
                int power = int.Parse(tokens[0]);

                switch (directions)
                {
                    case "Right":
                        indexOfBullet = (indexOfBullet + power) % bullets.Length; 
                        break;

                    case "Left":
                        if (indexOfBullet - power < 0)
                        {
                            indexOfBullet = bullets.Length - (Math.Abs(indexOfBullet - power) % bullets.Length);
                        }
                        else
                        {
                            indexOfBullet = indexOfBullet - power;
                        }
                        break;
                }

                if (indexOfBullet == 2)
                {
                    Console.WriteLine($"Game over! Player {i} is dead.");
                    isDead = true;
                    break;
                }

                indexOfBullet = indexOfBullet + 1 == bullets.Length ? 0 : indexOfBullet = 1;

            }
            if (!isDead)
            {
                Console.WriteLine("Everybody got lucky!");
            }

        }
    }
}
