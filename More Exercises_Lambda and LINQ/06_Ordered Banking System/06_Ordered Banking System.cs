namespace _06_Ordered_Banking_System
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
            var data = new Dictionary<string, Dictionary<string, decimal>>();

            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] tokens = input
                    .Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

                string bank = tokens[0];
                string account = tokens[1];
                decimal balance = decimal.Parse(tokens[2]);

                if (!data.ContainsKey(bank))
                {
                    data.Add(bank, new Dictionary<string, decimal>());
                }
                if (!data[bank].ContainsKey(account))
                {
                    data[bank].Add(account, 0);
                }
                data[bank][account] += balance;

                input = Console.ReadLine();
            }
            // Sort

            var orderedData = data
                .OrderByDescending(bankData => bankData.Value
                .Sum(accountData => accountData.Value))
                .ThenByDescending(bankData => bankData.Value.Values.Max());



            foreach (var bankData in orderedData)
            {
                string bank = bankData.Key;
                Dictionary<string, decimal> accountsData = bankData.Value;

                var orderedAccountData = accountsData
                    .OrderByDescending(d => d.Value);

                foreach (var accountData in orderedAccountData)
                {
                    string account = accountData.Key;
                    decimal balance = accountData.Value;

                    Console.WriteLine($"{account} -> {balance} ({bank})");
                }
            }

        }
    }
}
