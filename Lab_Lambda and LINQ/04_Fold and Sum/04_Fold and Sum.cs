
namespace _04_Fold_and_Sum
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
            int[] userInputNumbers = Console.ReadLine()
           .Split(' ')
           .Select(int.Parse)
           .ToArray();

            int k = userInputNumbers.Length / 4;

            List<int> leftPart = userInputNumbers.Take(k).Reverse().ToList();
            List<int> rightPart = userInputNumbers.Reverse().Take(k).ToList();

            int[] downArr = userInputNumbers.Skip(k).Take(2 * k).ToArray();
            int[] upperPart = leftPart.Concat(rightPart).ToArray();

            for (int cnt = 0; cnt < downArr.Length; cnt++)
            {
                downArr[cnt] += upperPart[cnt];
            }

            Console.WriteLine(string.Join(" ", downArr));


        }
    }
}
