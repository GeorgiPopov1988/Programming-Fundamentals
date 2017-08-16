namespace _3.Serialize_String
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
            char[] input = Console.ReadLine().ToCharArray();

            Dictionary<char, List<string>> result = new Dictionary<char, List<string>>();

            for (int index = 0; index < input.Length; index++)
            {
                char theChar = input[index];

                if (!result.ContainsKey(theChar))
                {
                    result[theChar] =  new List<string>();
                }

                result[theChar].Add(index.ToString());
            }

            foreach (var @char in result)
            {
                Console.WriteLine($"{@char.Key}:{string.Join("/", @char.Value)}");
            }
        }
    }
}
