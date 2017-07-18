namespace _03_Short_Words_Sorted
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
            char[] delimeters = ".,:;()[]\"'/\\!? ".ToCharArray();

            string[] words = Console.ReadLine()
                .ToLower()
                .Split(delimeters,StringSplitOptions.RemoveEmptyEntries)
                .Distinct()
                .Where(w => w.Length < 5)
                .OrderBy(w => w)
                .ToArray();

            Console.WriteLine(string.Join(", ", words));
        }
    }
}
