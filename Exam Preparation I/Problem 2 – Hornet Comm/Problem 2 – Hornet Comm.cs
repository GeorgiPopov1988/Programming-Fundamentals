namespace Problem_2___Hornet_Comm
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

            List<string> messages = new List<string>();
            List<string> broadcasts = new List<string>();


            while (input != "Hornet is Green")
            {
                string[] tokens = input
                    .Split(new string[] { " <-> " }
                    , StringSplitOptions.RemoveEmptyEntries);

                if (tokens.Length < 2)
                {
                    input = Console.ReadLine();
                    continue;
                }

                string leftPart = tokens[0];
                string rightPart = tokens[1];

                if (leftPart.All(char.IsDigit) &&
                    rightPart.All(char.IsLetterOrDigit))
                {
                    string reversed = Reverse(leftPart);
                    messages.Add($"{reversed} -> {rightPart}");
                }

                else if (!(leftPart.All(char.IsDigit)) &&
                    rightPart.All(char.IsLetterOrDigit))
                {
                    string changedLetters = ChangeLetters(rightPart);
                    broadcasts.Add($"{changedLetters} -> {leftPart}");
                }

                input = Console.ReadLine();
            }
            Console.WriteLine("Broadcasts:");
            Console.WriteLine(broadcasts.Count == 0 ? "None" :
                string.Join(Environment.NewLine, broadcasts));

            Console.WriteLine("Messages:");
            Console.WriteLine(messages.Count == 0 ? "None" :
                string.Join(Environment.NewLine, messages));
        }

        private static string Reverse(string leftPart)
        {
            char[] result = leftPart.ToCharArray();
            Array.Reverse(result);
            return new string(result);
        }

        private static string ChangeLetters(string rightPart)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < rightPart.Length; i++)
            {
                if (char.IsUpper(rightPart[i]))
                {
                    result.Append(char.ToLower(rightPart[i]));
                }

                else if (char.IsLower(rightPart[i]))
                {
                    result.Append(char.ToUpper(rightPart[i]));
                }
                else
                {
                    result.Append(rightPart[i]);
                }
            }
            return result.ToString();
        }
    }
}
