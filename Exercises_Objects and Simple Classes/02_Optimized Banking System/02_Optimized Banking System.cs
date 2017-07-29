namespace _02_Optimized_Banking_System
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
            List<BankAccount> bankAccounts = new List<BankAccount>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input
                    .Split(new string[] { " | " }
                    ,StringSplitOptions.RemoveEmptyEntries);

                string bankName = tokens[0];
                string accName = tokens[1];
                decimal balance = decimal.Parse(tokens[2]);

                BankAccount newBankAcc = new BankAccount
                {
                    Bank = bankName,
                    AccName = accName,
                    AccBalance = balance
                };

                bankAccounts.Add(newBankAcc);

                input = Console.ReadLine();
            }

            bankAccounts = bankAccounts
                .OrderByDescending(b => b.AccBalance)
                .ThenBy(bn => bn.Bank.Length)
                .ToList();

            foreach (var client in bankAccounts)
            {
                Console.WriteLine($"{client.AccName} -> {client.AccBalance} ({client.Bank})");
            }
        }
    }

    public class BankAccount
    {
        public string Bank { get; set; }
        public string AccName { get; set; }
        public decimal AccBalance { get; set; }
    }
}
