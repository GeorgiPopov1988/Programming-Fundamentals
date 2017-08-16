namespace _3.Text_filter
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
            List<string> banList = Console.ReadLine()
                .Split(new string[] { ", " }
                , StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string text = Console.ReadLine();

            foreach (var word in banList)
            {
                if (text.Contains(word))
                {
                    text = text.Replace(word, new string('*', word.Length));
                }

            }
            Console.WriteLine(text);
        }
    }
}