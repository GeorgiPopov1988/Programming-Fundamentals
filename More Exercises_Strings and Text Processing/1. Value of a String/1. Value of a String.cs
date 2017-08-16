namespace _1.Value_of_a_String
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
            string command = Console.ReadLine().ToUpper();
            int result = 0;

            switch (command)
            {
                case "UPPERCASE":
                    {
                        result = SumUpper(input);
                        break;
                    }
                case "LOWERCASE":
                    {
                        result = SumLower(input);
                        break;
                    }

            }

            Console.WriteLine($"The total sum is: {result}");
        }

        static int SumLower(char[] input)
        {
            int lowerResult = 0;

            foreach (var theChar in input)
            {
                if (theChar >= 'a' && theChar <= 'z')
                {
                    lowerResult += theChar;
                }
            }
            return lowerResult;
        }

        static int SumUpper(char[] input)
        {
            int upperResult = 0;

            foreach (var theChar in input)
            {
                if (theChar >= 65 && theChar <= 90)
                {
                    upperResult += theChar;

                }
            }
            return upperResult;
        }
    }
}
