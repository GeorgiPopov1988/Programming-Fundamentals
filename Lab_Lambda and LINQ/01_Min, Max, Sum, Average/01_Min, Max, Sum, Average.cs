namespace _01_Min__Max__Sum__Average
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
            int n = int.Parse(Console.ReadLine());

            List<int> numbers = new List<int>();

            for (int cnt = 0; cnt < n; cnt++)
            {
                int numToAdd = int.Parse(Console.ReadLine());

                numbers.Add(numToAdd);
            }

            Console.WriteLine("Sum = " + numbers.Sum());
            Console.WriteLine("Min = " + numbers.Min());
            Console.WriteLine("Max = " + numbers.Max());
            Console.WriteLine("Average = " + numbers.Average());



        }
    }
}
