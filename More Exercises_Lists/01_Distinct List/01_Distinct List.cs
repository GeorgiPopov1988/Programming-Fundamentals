namespace _01_Distinct_List
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
            var inputNumbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList()
                .Distinct();

            //var result = DistinctedList(inputNumbers);
            //Console.WriteLine(string.Join(" ", result));

            Console.WriteLine(string.Join(" ", inputNumbers));
        }

        ////static List<int> DistinctedList(List<int> inputNumbers)
        //{
        //    for (int cnt1 = 0; cnt1 < inputNumbers.Count; cnt1++)
        //    {
        //        for (int cnt2 = 0; cnt2 < inputNumbers.Count; cnt2++)
        //        {
        //            var numOne = inputNumbers[cnt1];
        //            var numTwo = inputNumbers[cnt2];

        //            if (cnt1 == cnt2)
        //            {
        //                continue;
        //            }

        //            if (numOne == numTwo)
        //            {
        //                inputNumbers.RemoveAt(cnt2);
        //                cnt2--;
        //            }

        //        }
        //    }
        //    return inputNumbers;
        //}
    }
}
