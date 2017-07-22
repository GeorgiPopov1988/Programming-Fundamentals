namespace _02_String_Decryption
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
            int[] skipAndTake = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int m = skipAndTake[0];
            int n = skipAndTake[1];

            List<char> result = numbers
                .Where(num => (num > 64 && num < 91))
                .Skip(m)
                .Take(n)
                .Select(num => (char)num)
                .ToList();

            Console.WriteLine(string.Join("", result));




        }
    }
}
