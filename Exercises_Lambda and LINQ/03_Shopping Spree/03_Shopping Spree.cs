namespace _03_Shopping_Spree
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
            decimal budget = decimal.Parse(Console.ReadLine());

            string @PeshoInput = Console.ReadLine();

            var @PeshoRequest = new Dictionary<string, decimal>();

            while (PeshoInput != "end")
            {
                string[] input = PeshoInput.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string food = input[0];
                decimal price = decimal.Parse(input[1]);

                if (!PeshoRequest.ContainsKey(food))
                {
                    PeshoRequest[food] = price;
                }
                else
                {
                    if (PeshoRequest[food] > price)
                    {
                        PeshoRequest[food] = price;
                    }
                }


                PeshoInput = Console.ReadLine();
            }

            decimal totalPrice = PeshoRequest.Values.Sum();

            if (budget >= totalPrice)
            {
                PeshoRequest = PeshoRequest
                    .OrderByDescending(v => v.Value)
                    .ThenBy(k => k.Key.Length)
                    .ToDictionary(k => k.Key, v => v.Value);

                foreach (var food in PeshoRequest)
                {
                    Console.WriteLine($"{food.Key} coasts {food.Value:F2}");
                }
            }
            else
            {
                Console.WriteLine("Need more money… Just buy banichka");
            }
        }
    }
}
