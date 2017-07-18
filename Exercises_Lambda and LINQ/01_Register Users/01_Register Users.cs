namespace _01_Register_Users
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
       // static DateTime date;

        public static void Main()
        {
            string userInput = Console.ReadLine();

            var userData = new Dictionary<string, DateTime>();

            while (userInput != "end")
            {
                string[] input = userInput.Split(new string[] { " -> " },
                    StringSplitOptions.RemoveEmptyEntries);

                string name = input[0];
                DateTime date = DateTime.ParseExact(input[1], "dd/MM/yyyy", CultureInfo.InvariantCulture);

                if (!userData.ContainsKey(name))
                {
                    userData.Add(name, new DateTime());
                }
                userData[name] = date;

                

                userInput = Console.ReadLine();
            }
            var result = userData
                    .Reverse()
                    .OrderBy(user => user.Value)
                    .Take(5)
                    .OrderByDescending(user => user.Value)
                    .ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in result)
            {
                Console.WriteLine(item.Key);

            }

        }
    }
}
