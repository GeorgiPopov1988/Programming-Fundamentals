namespace _02_Append_Lists
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
            var input = Console.ReadLine()
                .Split('|')
                .ToList();

            var result = new List<string>();

            for (int i = input.Count - 1; i >= 0; i--)
            {
                result.Add(input[i].Trim());
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
