namespace _01_Wardrobe
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
            var data = new Dictionary<string, Dictionary<string, int>>();

            int linesCnt = int.Parse(Console.ReadLine());

            for (int cnt = 0; cnt < linesCnt; cnt++)
            {
                string[] input = Console.ReadLine().Split(new string[] {" -> "}, StringSplitOptions.RemoveEmptyEntries);

                string color = input[0];
                string[] clothes = input[1].Split(',');

                if (!data.ContainsKey(color))
                {
                    data.Add(color, new Dictionary<string, int>());
                }

                foreach (string cloth in clothes)
                {
                    Dictionary<string, int> clothDb = data[color];

                    if (!clothDb.ContainsKey(cloth))
                    {
                        clothDb.Add(cloth, 0);
                    }
                    clothDb[cloth]++;
                }
            }

            string[] search = Console.ReadLine().Split(' ');
            string searchedColor = search[0];
            string searchedCloth = search[1];

            foreach (var colorData in data)
            {
                string color = colorData.Key;
                Dictionary<string, int> clothesData = colorData.Value;

                Console.WriteLine($"{color} clothes:");

                foreach (var clothData in clothesData)
                {
                    string cloth = clothData.Key;
                    int quantity = clothData.Value;

                    Console.Write($"* {cloth} - {quantity}");

                    if (color == searchedColor &&
                        cloth == searchedCloth)
                    {
                        Console.Write(" (found!)");
                    }
                
                        Console.WriteLine();
          
                }
            }

        }
    }
}
