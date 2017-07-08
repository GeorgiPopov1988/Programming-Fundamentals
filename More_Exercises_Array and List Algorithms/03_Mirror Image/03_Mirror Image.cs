namespace _03_Mirror_Image
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            while (true)
            {
                string borderPosition = Console.ReadLine();

                if (borderPosition == "Print")
                {
                    break;
                }

                int currentIndex = int.Parse(borderPosition);

                for (int i = 0; i < currentIndex / 2; i++)
                {
                    var temp = input[i];
                    input[i] = input[currentIndex - i - 1];
                    input[currentIndex - i - 1] = temp;

                }

                Array.Reverse(input);

                for (int i = 0; i < (input.Length - 1 - currentIndex) / 2; i++)
                {
                    var temp = input[i];
                    input[i] = input[input.Length - 2 - currentIndex - i];
                    input[input.Length - 2 - currentIndex - i] = temp;

                }

                Array.Reverse(input);
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
