namespace _7.Capitalize_Words
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
            string input = Console.ReadLine().ToLower();

            while (input != "end")
            {
                char[] delimeterSymbols = new char[] { '.', ',', '-', '_', '!', '"', '?', ':', ';', '(', ')',
                '{', '}', '[', ']', '§', '$', '%', '&', '/', '\\', '=',
                '|', '^', '°', '*', '#', '+', '~', '²', '³', '<', '>', ' '};

                List<string> result = new List<string>();


                string[] words = input.Split(delimeterSymbols,StringSplitOptions.RemoveEmptyEntries);

                foreach (var word in words)
                {
                    string upperedWord = string.Empty;

                    for (int cnt = 0; cnt < word.Length; cnt++)
                    {
                        string currentChar = word[cnt].ToString();

                        if (cnt == 0)
                        {
                            currentChar = currentChar.ToUpper();
                        }

                        upperedWord += currentChar;
                    }
                    result.Add(upperedWord);
                }

                Console.WriteLine($"{string.Join(", ", result)}");

                input = Console.ReadLine().ToLower();
            }
        }
    }
}
