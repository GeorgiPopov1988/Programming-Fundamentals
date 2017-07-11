namespace _04_Exam_Shopping
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
            var assortiment = AddProducts();

            var productLeft = BuyProductsAndPrintThatLeft(assortiment);

            foreach (var item in productLeft)
            {
                if (item.Value > 0)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value}");
                }

            }
        }

        static Dictionary<string, int> BuyProductsAndPrintThatLeft(Dictionary<string, int> assortiment)
        {

            string[] inputStock = Console.ReadLine()
                 .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            while (inputStock[0] != "exam")
            {
                string product = inputStock[1];
                int quantity = int.Parse(inputStock[2]);

                if (!assortiment.ContainsKey(product))                  // If product not exist
                {
                    Console.WriteLine($"{product} doesn't exist");
                }
                else
                {

                    if (assortiment[product] <= 0)
                    {
                        assortiment[product] = 0;
                        Console.WriteLine($"{product} out of stock");
                    }
                    else if (assortiment[product] > 0)
                    {
                        assortiment[product] -= quantity;
                    }
                }
               
                inputStock = Console.ReadLine()
                                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }
            return assortiment;

        }

        static Dictionary<string, int> AddProducts()
        {
            string[] inputStock = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var assortiment = new Dictionary<string, int>();

            while (inputStock[0] != "shopping")
            {
                string product = inputStock[1];
                int quantity = int.Parse(inputStock[2]);

                if (!assortiment.ContainsKey(product))
                {
                    assortiment[product] = 0;
                }

                assortiment[product] += quantity;

                inputStock = Console.ReadLine()
                 .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }

            return assortiment;

        }
    }
}
