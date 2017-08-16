namespace _4.Deserialize_String
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
            SortedDictionary<int, char> lettersIdexes = new SortedDictionary<int, char>();
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input.Split(':');

                char theChar = tokens[0][0];
                int[] indexes = tokens[1]
                    .Split('/')
                    .Select(int.Parse)
                    .ToArray();

                foreach (int index in indexes)
                {
                    lettersIdexes[index] = theChar;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(lettersIdexes.Values.ToArray());
        }
    }
}
