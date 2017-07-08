namespace _06_Extremums
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
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string comand = Console.ReadLine();

            if (comand == "Min")
            {
                GetMin(input);
                
            }
            if (comand == "Max")
            {
               GetMax(input);
                
            }
        }

        static void GetMax(List<int> input)
        {
            List<int> resultMax = new List<int>();
            int maxValue = int.MinValue;
            int sum = 0;

            for (int i = 0; i < input.Count; i++)
            {
                int digit = input[i];
                string strElement = digit.ToString();

                int count = 0
                    ;
                while (count <= strElement.Length)
                {
                    if (digit > maxValue)
                    {
                        maxValue = digit;
                    }
                    strElement = ShiftString(strElement);
                    digit = int.Parse(strElement);
                    count++;
                }
                resultMax.Add(maxValue);
                sum += maxValue;
                maxValue = int.MinValue;
            }
            Console.WriteLine(string.Join(", ", resultMax));
            Console.WriteLine(sum);
        }

        static void GetMin(List<int> input)
        {
            List<int> resultMiн = new List<int>();
            int minValue = int.MaxValue;
            int sum = 0;

            for (int i = 0; i < input.Count; i++)
            {
                int digit = input[i];
                string strElement = digit.ToString();

                int count = 0;

                while (count <= strElement.Length)
                {
                    if (digit < minValue)
                    {
                        minValue = digit;
                    }

                    strElement = ShiftString(strElement);
                    digit = int.Parse(strElement);
                    count++;
                }
                resultMiн.Add(minValue);
                sum += minValue;
                minValue = int.MaxValue;
            }
            Console.WriteLine(string.Join(", ", resultMiн));
            Console.WriteLine(sum);
        }

        static string ShiftString(string str)
        {
            string firstCahr = str.Substring(0, 1);
            return str.Substring(1) + firstCahr;
        }
    }
    
}
