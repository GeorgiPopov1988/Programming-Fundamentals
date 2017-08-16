namespace _2.Diamond_Problem
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
            string input = Console.ReadLine();
            bool isFound = false;

            int startIndex = -1;
            int endIndex = -1;

            while ((startIndex = input.IndexOf('<', startIndex + 1)) > - 1
                  && (endIndex = input.IndexOf('>', startIndex + 1)) > - 1)
            {
                string diamond = input.Substring(startIndex + 1, endIndex - startIndex - 1);
                int carats = FindCarats(diamond);
                Console.WriteLine($"Found {carats} carat diamond");
                isFound = true;
            }

            if (!isFound)
            {
                Console.WriteLine("Better luck next time");
            }

        }

        private static int FindCarats(string diamond)
        {
            int carats = 0;

            foreach (char theChar in diamond)
            {
                if (char.IsDigit(theChar))
                {
                    carats += int.Parse(theChar.ToString());
                }
            }

            return carats;
        }
    }
}
