using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Debugging_Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMultiplyOfOddsAndEvens(Math.Abs(num)));
        }

        static int GetMultiplyOfOddsAndEvens(int num)
        {
            int sumOfOdds = GetSumOfOdds(num);
            int sumOfEvens = GetSumOfEvens(num);

            int multiplyOfOddsAndEvens = sumOfEvens * sumOfOdds;

            return multiplyOfOddsAndEvens;
        }

        static int GetSumOfEvens(int num)
        {
            int sumOfEvens = 0;

            while (num > 0)
            {
                int lastDigitOfNum = num % 10;

                if (lastDigitOfNum % 2 == 0)
                {
                    sumOfEvens += lastDigitOfNum;
                }
                num /= 10;
            }
            return sumOfEvens;
        }

        static int GetSumOfOdds(int num)
        {
            int sumOfOdds = 0;

            while (num > 0)
            {
                int lastDigitOfNum = num % 10;
                if (lastDigitOfNum % 2 != 0)
                {
                    sumOfOdds += lastDigitOfNum;
                }
                num /= 10;
            }
            return sumOfOdds;
        }
    }
}
