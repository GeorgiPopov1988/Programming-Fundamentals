namespace _4.Palindromes
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
            List<string> input = Console.ReadLine()
                .Split(new char[] { ' ', ',', '.', '?', '!' }
                , StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> result = new List<string>();

            foreach (var word in input)
            {
                string reversedWored = ReverseWord(word);

                if (reversedWored == word &&
                    !result.Contains(reversedWored))
                {
                    result.Add(reversedWored);
                }
            }
            result = result.OrderBy(w => w).ToList();
            Console.WriteLine(string.Join(", ", result));
        }

        static string ReverseWord(string word)
        {
            var result = word.ToCharArray().Reverse().ToArray();
            return new string(result);
        }
    }
}
