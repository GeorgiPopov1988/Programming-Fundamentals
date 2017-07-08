namespace _05_Decode_Radio_Frequencies
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
            var input = Console.ReadLine()
                .Split( ' ' )
                .ToArray();

            var outputMessage = new List<char>();

            for (int cnt = 0; cnt < input.Length; cnt++)
            {
                var currentString = input[cnt].Split('.');
                int firstElement = int.Parse(currentString[0]);
                int secondElement = int.Parse(currentString[1]);

                char firstLetter = (char)firstElement;
                char secondLetter = (char)secondElement;

                if (firstElement != 0)
                {
                    outputMessage.Insert(cnt, firstLetter);
                }
                if (secondElement != 0)
                {
                    outputMessage.Insert(outputMessage.Count - 1 - cnt, secondLetter);
                }
            }

            outputMessage.Reverse();

            Console.WriteLine(string.Join("", outputMessage));

        }
    }
}
