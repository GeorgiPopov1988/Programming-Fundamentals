using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Vapor_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());
            double startinBalance = balance;

            Dictionary<string, double> data = new Dictionary<string, double>();
            data["OutFall 4"] = 39.99;
            data["CS: OG"] = 15.99;
            data["Zplinter Zell"] = 19.99;
            data["Honored 2"] = 59.99;
            data["RoverWatch"] = 29.99;
            data["RoverWatch Origins Edition"] = 39.99;

            string input = Console.ReadLine();

            while (input != "Game Time")
            {
                if (!data.ContainsKey(input))
                {
                    Console.WriteLine("Not Found");
                }
                else
                {
                    double currentPrice = data[input];
                    if (currentPrice <= balance)
                    {
                        Console.WriteLine($"Bought {input}");
                        balance -= currentPrice;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }

                if (balance <= 0) // if (Math.Abs(balance) < 0.0000000...1)
                {
                    Console.WriteLine("Out of money!");

                    return;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total spent: ${startinBalance - balance:F2}. Remaining: ${balance:F2}");

        }
    }
}
