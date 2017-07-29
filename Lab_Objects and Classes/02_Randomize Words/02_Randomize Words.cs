namespace _02_Randomize_Words
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
            string[] words = Console.ReadLine().Split(' ');

            Random rnd = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int index = rnd.Next(0, words.Length);

                string temp = words[i];
                words[i] = words[index];
                words[i] = temp;
            }

            words.ToList().ForEach(Console.WriteLine);

        }
    }
}
