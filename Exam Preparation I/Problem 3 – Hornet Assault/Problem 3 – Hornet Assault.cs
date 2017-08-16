namespace Problem_3___Hornet_Assault
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main()
        {
            List<long> beeHives = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToList();

            List<long> hornets = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToList();

            

            for (int i = 0; i < beeHives.Count; i++)
            {

                if (hornets.Count <= 0)
                {
                    break;
                }

                if (hornets.Sum() > beeHives[i])
                {
                    beeHives.RemoveAt(i);
                    i--;
                }
                else
                {
                    beeHives[i] -= hornets.Sum();
                    hornets.RemoveAt(0);
                }
            }

            if (beeHives.Where(h => h > 0).ToList().Count > 0)
            {
                Console.WriteLine(string.Join(" ", beeHives.Where(h => h > 0)));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }

        }
    }
}
