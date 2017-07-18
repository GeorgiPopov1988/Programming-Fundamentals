namespace _02_Default_Values
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
            string userInput = Console.ReadLine();

            var inputData = new Dictionary<string, string>();

            while (userInput != "end")
            {
                string[] input = userInput.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

                string inputKey = input[0];
                string inputValue = input[1];

                inputData[inputKey] = inputValue;


                userInput = Console.ReadLine();
            }

            string inputDefaultValue = Console.ReadLine();

            var inputWintValues = inputData
                .Where(v => v.Value != "null")
                .OrderByDescending(v => v.Value.Length)
                .ToDictionary(k => k.Key, v => v.Value);

            var inputWithNullValues = inputData
                .Where(v => v.Value == "null")
                .ToDictionary(k => k.Key, v => inputDefaultValue);

            var result = inputWintValues
                .Concat(inputWithNullValues)
                .ToDictionary(k => k.Key, v => v.Value);

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} <-> {item.Value}");
            }
        }
    }
}
