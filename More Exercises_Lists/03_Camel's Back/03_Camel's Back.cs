namespace _03_Camel_s_Back
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
            var list = Console.ReadLine()
                .Split( ' ' )
                .Select(int.Parse)
                .ToList();

            var backSize = int.Parse(Console.ReadLine());
            var rounds = 0;

            if (backSize >= list.Count)
            {
                Console.WriteLine($"already stable: {string.Join(" ", list)}");
                return;
            }

            else
            {
                while (backSize != list.Count)
                {
                    rounds++;
                    list.RemoveAt(0);
                    list.RemoveAt(list.Count - 1);

                }
                Console.WriteLine($"{rounds} rounds");
                Console.WriteLine("remaining: " + string.Join(" ", list));

            }
        }
    }
}
