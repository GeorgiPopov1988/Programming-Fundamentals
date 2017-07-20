namespace _01_Array_Data
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
            int[] input = Console.ReadLine()
                .Split( ' ' )
                .Select(int.Parse)
                .ToArray();

            var result = input
                .Where(num => num >= input.Average())
                .OrderBy(num => num);

            string comand = Console.ReadLine();

            switch (comand)
            {
                case "Max":
                    {
                        Console.WriteLine(result.Max());
                        break;
                    }
                case "Min":
                    {
                        Console.WriteLine(result.Min());
                        break;
                    }
                case "All":
                    {
                        Console.WriteLine(string.Join(" ", result));
                        break;
                    }

            }
        }
    }
}
