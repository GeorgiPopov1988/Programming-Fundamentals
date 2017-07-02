
namespace _03_Sort_Array_of_Strings
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
            string[] randomWords = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Array.Sort(randomWords);

            Console.WriteLine(string.Join(" ", randomWords));
        }
    }
}
