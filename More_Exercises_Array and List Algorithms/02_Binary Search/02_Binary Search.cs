namespace _02_Binary_Search
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
            List<int> list = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int numToFind = int.Parse(Console.ReadLine());

            int linearSearch = LinearSearch(list, numToFind);
            int binarySearch = BinarySearch(list, numToFind);

            if (list.Contains(numToFind))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            Console.WriteLine($"Linear search made {linearSearch} iterations");
            Console.WriteLine($"Binary search made {binarySearch} iterations");
        }

        static int BinarySearch(List<int> list, int numToFind)
        {
            list.Sort();
            
            int min = 0;
            int max = list.Count - 1;
            int counter = 0;

            while (min <= max)
            {
                counter++;

                int middle = (min + max) / 2;

                if (list[middle] < numToFind)
                {
                    min = middle + 1;
                }

                if (list[middle] > numToFind)
                {
                    max = middle - 1;
                }

                if (list[middle] == numToFind)
                {
                    break;
                }
            }
            return counter;

        }

        static int LinearSearch(List<int> list, int wantedDigit)
        {
            int counter = 0;

            foreach (var currentNum in list)
            {
                counter++;

                if (currentNum == wantedDigit)
                {
                    return counter;
                }
                
            }
            return counter;
        }
    }
}
