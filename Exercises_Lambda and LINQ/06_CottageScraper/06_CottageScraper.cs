namespace _06_CottageScraper
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
            var data = new List<KeyValuePair<string, int>>();

            string userInput = Console.ReadLine();
            while (userInput != "chop chop")
            {
                string[] inputTokens = userInput
                    .Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

                string woodType = inputTokens[0];
                int woodHeight = int.Parse(inputTokens[1]);
                
                data.Add(new KeyValuePair<string, int>(woodType, woodHeight));



                userInput = Console.ReadLine();
            }


            string wantedType = Console.ReadLine();
            int minHeight = int.Parse(Console.ReadLine());

            double usedLogsValue = data
                .Where(d => d.Key == wantedType && d.Value >= minHeight)
                .Sum(d => d.Value);

            double unUsedLogsValue = data
                .Where(d => d.Key != wantedType || d.Value < minHeight)
                .Sum(d => d.Value);

            double pricePerMeter = Math.Round(data.Average(d => d.Value), 2);

            usedLogsValue = Math.Round(usedLogsValue * pricePerMeter, 2);
            unUsedLogsValue = Math.Round(unUsedLogsValue * pricePerMeter * 0.25, 2);
            double totalPrice = usedLogsValue + unUsedLogsValue;

            Console.WriteLine($"Price per meter: ${pricePerMeter:F2}");
            Console.WriteLine($"Used logs price: ${usedLogsValue:F2}");
            Console.WriteLine($"Unused logs price: ${ unUsedLogsValue:F2}");
            Console.WriteLine($"CottageScraper subtotal: ${totalPrice:F2}");

        }
    }
}
