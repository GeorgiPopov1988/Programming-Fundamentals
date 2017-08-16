namespace _2_Placeholders
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
            string userInput = Console.ReadLine();

            while (userInput != "end")
            {
                string[] tokens = userInput
                                  .Split(new string[] { " -> " }
                                  , StringSplitOptions.RemoveEmptyEntries);
                string result = tokens[0];
                string[] replaceTokens = tokens[1]
                    .Split(new string[] { ", " }
                    , StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                for (int cnt = 0; cnt < replaceTokens.Length; cnt++)
                {
                    string placeHoler = $"{"{" + cnt + "}"}";
                    string replacingWord = replaceTokens[cnt];

                    if (result.Contains(placeHoler))
                    {
                        result = result.Replace(placeHoler, replacingWord);
                    }
                }

                Console.WriteLine(result);

                userInput = Console.ReadLine();
            }
        }
    }
}
