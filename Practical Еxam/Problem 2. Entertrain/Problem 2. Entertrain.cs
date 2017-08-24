namespace Problem_2.Entertrain
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
            int locomotivePower = int.Parse(Console.ReadLine());
            List<int> wagons = new List<int>();
            int weight = 0;

            string input = Console.ReadLine();

            while (input != "All ofboard!")
            {
                int wagonWeight;

                int.TryParse(input, out wagonWeight);

                wagons.Add(wagonWeight);

                weight += wagonWeight;

                if (weight > locomotivePower)
                {
                    int number = (int)wagons.Average();// weight / wagons.Count();

                    //int closest = wagons.Where(numbers => numbers >= num || numbers <=  num).First();
                    //int closest = wagons.Aggregate((x, y) => Math.Abs(x - number) < Math.Abs(y - number) ? x : y);
                    int closest = wagons.OrderBy(n => Math.Abs(number - n)).First();
                    int index = wagons.IndexOf(closest);

                    wagons.RemoveAt(index);
                }

                input = Console.ReadLine();
            }

            wagons.Reverse();
            Console.WriteLine($"{string.Join(" ", wagons)} {locomotivePower}");
        }
    }
}
