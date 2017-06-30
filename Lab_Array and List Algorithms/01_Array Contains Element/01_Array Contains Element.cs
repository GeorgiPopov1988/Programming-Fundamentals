namespace _01_Array_Contains_Element
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
            var searchElement = int.Parse(Console.ReadLine());

            var array = Console.ReadLine()
                .Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            bool containsElement = false;

            for (int cnt = 0; cnt < array.Length; cnt++)
            {
                if (array[cnt] == searchElement)
                {
                    containsElement = true;
                    break;
                }
            }

            if (containsElement)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
            
        }
    }
}
