namespace _3_Word_Count
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main()
        {
            string[] words = File.ReadAllText("words.txt").ToLower().Split();
            string[] textInput = File.ReadAllText("text.txt")
                                .ToLower()
                                .Split(new char[] { '\n', '\r', ' ', '.', ',', '!', '?', '-' }
                                ,StringSplitOptions.RemoveEmptyEntries);

            var wordCount = new Dictionary<string, int>();

            foreach (string word in words)
            {
                wordCount[word] = 0;

                foreach (var item in textInput)
                {
                    if (wordCount.ContainsKey(item))
                    {
                        wordCount[word]++;
                    }
                }

            }


        }
    }
}
