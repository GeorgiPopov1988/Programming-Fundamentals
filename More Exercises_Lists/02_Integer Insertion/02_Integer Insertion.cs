namespace _02_Integer_Insertion
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
            var inputNumbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var currentInput = Console.ReadLine();

            while (currentInput != "end")
            {
                var firstDigitForIndex = int.Parse(currentInput[0].ToString());
                var stringToNumberInput = int.Parse(currentInput);

                inputNumbers.Insert(firstDigitForIndex, stringToNumberInput);

                currentInput = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", inputNumbers));
        }
    }
}
