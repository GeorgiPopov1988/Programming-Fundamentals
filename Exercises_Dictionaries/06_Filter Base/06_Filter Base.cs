namespace _06_Filter_Base
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main(string[] args)
        {
            var ages = new Dictionary<string, int>();
            var salaries = new Dictionary<string, double>();
            var positions = new Dictionary<string, string>();

            string[] input = Console.ReadLine()
                .Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "filter")
            {
                string name = input[0];
                string values = input[1];

                int age;
                double salary;

                if (int.TryParse(values, out age))
                {
                    ages[name] = age;
                }
                else if(double.TryParse(values, out salary))
                {
                    salaries[name] = salary;
                }
                else
                {
                    positions[name] = values;
                }

                input = Console.ReadLine()
                .Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

            }

            string condition = Console.ReadLine().ToLower();

            if (condition == "position")
            {
                foreach (var item in positions)
                {
                    Console.WriteLine($"Name: {item.Key}");
                    Console.WriteLine($"Position: {item.Value}");
                    Console.WriteLine(new string('=', 20));


                }

            }

            else if (condition == "age")
            {
                foreach (var item in ages)
                {
                
                Console.WriteLine($"Name: {item.Key}");
                Console.WriteLine($"Age: {item.Value}");
                Console.WriteLine(new string('=', 20));

                }
            }

            else
            {
                foreach (var item in salaries)
                {

                Console.WriteLine($"Name: {item.Key}");
                Console.WriteLine($"Salary: {item.Value:F2}");
                Console.WriteLine(new string('=', 20));

                }
            }
        }
    }
}
