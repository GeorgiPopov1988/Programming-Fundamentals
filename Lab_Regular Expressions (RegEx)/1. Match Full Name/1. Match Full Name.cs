namespace _1.Match_Full_Name
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Text.RegularExpressions;


    public class Program
    {
        public static void Main()
        {
            Regex regex = new Regex(@"\b[A-Z][a-z]+\s[A-Z][a-z]+\b");

            string text = Console.ReadLine();
            var matches = regex.Matches(text);

            foreach (Match match in matches)
            {
                Console.WriteLine(match + " ");
            }
        }
    }
}
