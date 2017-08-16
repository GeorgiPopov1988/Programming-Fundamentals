namespace _2.Count_substring_occurrences
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
            string text = Console.ReadLine().ToLower();
            string find = Console.ReadLine().ToLower();

            int cnt = 0;
            int index = text.IndexOf(find);

            while (index != -1)
            {

                cnt++;
                index = text.IndexOf(find, index + 1);
            }

            Console.WriteLine(cnt);
        }
    }
}
