namespace _04_Most_Valued_Customer
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
            var assortment = new Dictionary<string, decimal>();

            while (input != "Shop is open")
            {
                string[] tokens = input
                    .Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries);

                string productName = tokens[0];
                decimal productPrice = decimal.Parse(tokens[1]);

                if (!assortment.ContainsKey(productName))
                {
                    assortment[productName] = 0;
                }
                assortment[productName] = productPrice;

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            var buyers = new Dictionary<string, List<string>>();

            while (input != "Print")
            {
                if (input != "Discount")
                {
                    string[] purchasesTokens = input
                   .Split(new string[] { ": ", ", " }, StringSplitOptions.RemoveEmptyEntries);

                    string buyerName = purchasesTokens[0];
                    string currnetProduct = string.Empty;

                    buyers.Add(buyerName, new List<string>());

                    for (int cnt = 1; cnt < purchasesTokens.Length; cnt++)
                    {
                        currnetProduct = purchasesTokens[cnt];
                        buyers[buyerName].Add(currnetProduct);
                    }
                }

                else // input == "Discount"
                {
                    List<KeyValuePair<string, decimal>> topThreeProducts = assortment
                                                        .OrderByDescending(p => p.Value)
                                                        .Take(3)
                                                        .ToList();

                    foreach (var kvp in topThreeProducts)
                    {
                        string name = kvp.Key;
                        decimal currnetPrice = kvp.Value;

                        // Find the reduced price.
                        assortment[name] = currnetPrice - (currnetPrice * 0.10M); 
                    }
                }

                input = Console.ReadLine();
            }

            // After command "print"
            // Take total sum for all buyers

            var bestBuyer = new Dictionary<string, decimal>();

            string currentBuyer = string.Empty;

            //Take name of the current buyer

            foreach (var kvp in buyers)
            {
                decimal total = 0;
                currentBuyer = kvp.Key;
                List<string> boughtProduct = kvp.Value;

                // Take the price of each product one by one

                foreach (string product in boughtProduct)
                {
                    total += assortment[product];
                }

                bestBuyer.Add(currentBuyer, total);

            }

            // Printing
            // Take best buyer data
            bestBuyer = bestBuyer
                .OrderByDescending(v => v.Value).Take(1).ToDictionary(k => k.Key, v => v.Value);

            // Take best buyer name

            foreach (var item in bestBuyer)
            {
                string nameOfBuyer = item.Key;
                Console.WriteLine($"Biggest spender: {nameOfBuyer}");
                Console.WriteLine("^Products bought:");

                // Take unique products in buying of the best buyer

                List<string> purchases = buyers[nameOfBuyer].Distinct().ToList();

                var result = new Dictionary<string, decimal>();

                // Add the price for each product

                for (int i = 0; i < purchases.Count; i++)
                {
                    result[purchases[i]] = assortment[purchases[i]];
                }
                
                // Print

                foreach (var product in result.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"^^^{product.Key}: {product.Value:f2}");
                }

                Console.WriteLine("Total: {0:f2}", item.Value);

            }
        }
    }
}
