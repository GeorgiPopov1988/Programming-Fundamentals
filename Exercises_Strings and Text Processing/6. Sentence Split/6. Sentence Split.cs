namespace _6.Sentence_Split
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
            string delimeter = Console.ReadLine();

            string[] result = input
                .Split(new string[] { delimeter }
                , StringSplitOptions.None)
                .ToArray();

            Console.WriteLine("[" + string.Join(", ", result) + "]");
        }
    }
}
