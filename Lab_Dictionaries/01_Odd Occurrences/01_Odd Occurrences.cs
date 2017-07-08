namespace _01_Odd_Occurrences
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
            var words = Console.ReadLine()
                .ToLower()
                .Split(' ')
                .ToList();

            var wordCnt = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (!wordCnt.ContainsKey(word))
                {
                    wordCnt[word] = 0;
                }

                wordCnt[word]++;

            }

            var result = new List<string>();

            foreach (var item in wordCnt)
            {

                if (item.Value %2 != 0)
                {
                    result.Add(item.Key);
                }
                
            }
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
