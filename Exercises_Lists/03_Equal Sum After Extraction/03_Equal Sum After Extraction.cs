using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Equal_Sum_After_Extraction
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var secondList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var sum1 = 0;
            var sum2 = 0;

            for (int cnt1 = 0; cnt1 < firstList.Count; cnt1++)
            {

                for (int cnt2 = 0; cnt2 < secondList.Count; cnt2++)
                {
                    if (firstList[cnt1] == secondList[cnt2])
                    {
                        secondList.RemoveAt(cnt2);
                    }

                }
                sum1 += firstList[cnt1];
            }
            foreach (var numOfList2 in secondList)
            {
                sum2 += numOfList2;
            }

            if (sum1 == sum2)
            {
                Console.WriteLine($"Yes. Sum: {sum1}");
            }
            else
            {
                var diff = Math.Abs(sum1 - sum2);

                Console.WriteLine($"No. Diff: {diff}");
            }
        }
    }
}

