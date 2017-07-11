namespace _03_Mixed_Phones
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
            string[] input = Console.ReadLine()
                .Split(new char[] { ' ', ':', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var result = new SortedDictionary<string, long>();

            while (input[0] != "Over")
            {
                string name = input[0];
                long phoneNumber;

                if(long.TryParse(input[1], out phoneNumber))
                {
                    result[name] = phoneNumber;
                   
                }
                else 
                {
                    name = input[1];
                    long.TryParse(input[0], out phoneNumber);
                    result[name] = phoneNumber;
                }

                input = Console.ReadLine()
                .Split(new char[] { ' ', ':', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }


        }
    }
}
