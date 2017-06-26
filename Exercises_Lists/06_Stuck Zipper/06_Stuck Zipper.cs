namespace _06_Stuck_Zipper
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
            var inputOne = Console.ReadLine()
                .Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var inputTwo = Console.ReadLine()
                .Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();


            var shrotestDigit = LenghtOfDigit(inputOne, inputTwo);
            var resultZippedList = ZippedList(inputOne, inputTwo, shrotestDigit);

            Console.WriteLine(string.Join(" ", resultZippedList));

        }

        static List<int> ZippedList(List<int> inputOne, List<int> inputTwo, int shrotestDigit)
        {
            var listOne = new List<int>();
            var listTwo = new List<int>();
            

            foreach (var currentNum in inputOne)
            {
                var numInString = Math.Abs(currentNum).ToString();

                if (numInString.Length == shrotestDigit)
                {
                    listOne.Add(currentNum);
                }
            }

            foreach (var currentNum in inputTwo)
            {
                var numInString = Math.Abs(currentNum).ToString();

                if (numInString.Length == shrotestDigit)
                {
                    listTwo.Add(currentNum);
                }
            }

            var result = ZipListOneAndListTwo(listOne, listTwo);
            return result;
        }

        static List<int> ZipListOneAndListTwo(List<int> listOne, List<int> listTwo)
        {
            var listResult = new List<int>();
            var resultLenght = listOne.Count + listTwo.Count;

            for (int i = 0; i < resultLenght; i++)
            {
                var numberOfListOne = 0;
                var numberOfListTwo = 0;

                if (listTwo.Count > i)
                {
                    numberOfListTwo = listTwo[i];
                    listResult.Add(numberOfListTwo);
                }
                if (listOne.Count > i)
                {
                    numberOfListOne = listOne[i];
                    listResult.Add(numberOfListOne);
                }
            }
            return listResult;

        }

        static int LenghtOfDigit(List<int> inputOne, List<int> inputTwo)
        {
            var digit = int.MaxValue;
            

            foreach (var currentNumber in inputOne)
            {
                var shortestNum = Math.Abs(currentNumber).ToString();

                if (shortestNum.Length < digit)
                {
                    digit = shortestNum.Length;
                }

            }
            foreach (var currentNumber in inputTwo)
            {
                var shortestNum = Math.Abs(currentNumber).ToString();

                if (shortestNum.Length < digit)
                {
                    digit = shortestNum.Length;
                }

            }
            return digit;
        }
    }
}
