
namespace _02_Average_Character_Delimiter
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
            var listOfStrings = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            
            char separativeLetter = SumAllCharsAndFindSeparativeLetter(listOfStrings);

            

            for (int cnt = 0; cnt < listOfStrings.Count; cnt++)
            {

                if (cnt == listOfStrings.Count-1)
                {
                    Console.WriteLine(listOfStrings[cnt]);
                    return;
                }

                Console.Write(listOfStrings[cnt] + separativeLetter.ToString().ToUpper());
            }

            Console.WriteLine();
            
        }

        private static void PrintResult()
        {
            throw new NotImplementedException();
        }

       

        static char SumAllCharsAndFindSeparativeLetter(List<string> listOfStrings)
        {
            char separativeLetter = ' ';
            var sumOfChars = 0;
            var allChars = 0;

            for (int cnt1 = 0; cnt1 < listOfStrings.Count; cnt1++)
            {
                
                var currrentString = listOfStrings[cnt1];

                for (int cnt2 = 0; cnt2 < currrentString.Length; cnt2++)
                {
                    int cuurentChar = currrentString[cnt2];
                    sumOfChars += cuurentChar;
                    allChars++;
                }

            }
            separativeLetter = (char)(sumOfChars / allChars);
            return separativeLetter;
        }
    }
}
