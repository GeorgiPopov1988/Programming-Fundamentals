namespace _04_Phone
{
    using System;

    public class Program
    {
        static string[] numbers;
        static string[] names;

        public static void Main()
        {
            numbers = Console.ReadLine().Split(' ');
            names = Console.ReadLine().Split(' ');

            string[] input = Console.ReadLine().Split(' ');

            while (input[0] != "done")
            {
                string comand = input[0];
                string argument = input[1];

                string name;
                string number;
                string output;

                if (IsNumber(argument))
                {
                    name = GetEntry(argument);
                    number = argument;
                    output = name;
                }
                else
                {
                    name = argument;
                    number = GetEntry(argument);
                    output = number;
                }
                int digitsSum = GetDigitSum(number);
                if (comand == "call")
                {
                    Console.WriteLine("calling {0}...", output);

                    if (digitsSum % 2 == 1)
                    {
                        Console.WriteLine("no answer");
                    }
                    else
                    {
                        int min = digitsSum / 60;
                        int sec = digitsSum % 60;
                        Console.WriteLine($"call ended. duration: {min:D2}:{sec:D2}");
                    }

                }
                else if (comand == "message")
                {
                    Console.WriteLine("sending sms to {0}...", output);

                    if (digitsSum % 2 == 1)
                    {
                        Console.WriteLine("busy");
                    }
                    else
                    {
                        Console.WriteLine("meet me there");
                    }

                }

                input = Console.ReadLine().Split(' ');
            }
        }

        static int GetDigitSum(string telephoneNumber)
        {
            int sum = 0;
            for (int cnt = 0; cnt < telephoneNumber.Length; cnt++)
            {
                if (IsDigit(telephoneNumber[cnt]))
                {
                    sum += telephoneNumber[cnt] - '0';
                }
            }
            return sum;
        }

        static string GetEntry(string input)
        {
            for (int cnt = 0; cnt < numbers.Length; cnt++)
            {
                if (numbers[cnt] == input)
                {
                    return names[cnt];
                }
                else if (names[cnt] == input)
                {
                    return numbers[cnt];
                }
            }
            return string.Empty;
        }

        static bool IsNumber(string input)
        {
            for (int cnt = 0; cnt < input.Length; cnt++)
            {
                if (IsDigit(input[cnt]))
                {
                    return true;
                }
            }
            return false;
        }

        static bool IsDigit(char symbol)
        {
            return (symbol >= '0' && symbol <= '9');
        }

    }
}




