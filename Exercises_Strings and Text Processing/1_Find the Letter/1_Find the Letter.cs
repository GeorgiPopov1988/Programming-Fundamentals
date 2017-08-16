namespace _1_Find_the_Letter
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
            string input = Console.ReadLine();
            string[] findTokens = Console.ReadLine().Split(' ');

            char letterToFind = char.Parse(findTokens[0]);
            int maxIndex = int.Parse(findTokens[1]);

            int index = input.IndexOf(letterToFind, 0);

            while (maxIndex != 1)
            {
                index = input.IndexOf(letterToFind, index + 1);

                maxIndex--;
            }

            if (index >= 0)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("Find the letter yourself!");
            }
        }
    }
}
