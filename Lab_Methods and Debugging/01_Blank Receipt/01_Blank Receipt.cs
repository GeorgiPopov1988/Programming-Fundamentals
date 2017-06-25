using System;


namespace _01_Blank_Receipt
{
    static class Program
    {
        static void Main(string[] args)
        {
            PrintReceipt();
        }

        private static void PrintReceipt()
        {
            PrintReceiptHeader();
            PrintReceiptBody();
            PrintReceiptFooter();
        }

        private static void PrintReceiptFooter()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("© SoftUni");
        }

        private static void PrintReceiptBody()
        {
            Console.WriteLine(@"Charged to____________________");
            Console.WriteLine("Received by___________________");
        }

        private static void PrintReceiptHeader()
        {
            Console.WriteLine(@"CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }
    }
}
