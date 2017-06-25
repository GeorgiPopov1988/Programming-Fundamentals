using System;

namespace Numbers_to_Words
{
    class Numbers_to_Words
    {
        static void Main(string[] args)
        {
            int numCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < numCount; i++)
            {

                var currentNum = int.Parse(Console.ReadLine());

                // Valid ot not valid currentNum
                if (currentNum > 999)
                {
                    Console.WriteLine("too large");
                    continue;
                }
                else if (currentNum < -999)
                {
                    Console.WriteLine("too small");
                    continue;
                }
                else if (currentNum >= -99 && currentNum <= 99)
                {
                    continue;
                }
                var numConvertetToWords = (Letterize(Math.Abs(currentNum)));

                if (currentNum < 0)
                {
                    Console.WriteLine("minus " + numConvertetToWords);
                    continue;
                }
                else
                {
                    Console.WriteLine(numConvertetToWords);
                    continue;
                }
            }
        }
        static string Letterize(int currentNum)
        {
            var hundredPosition = FindHundredPositinInCurrentNum(currentNum);
            var tenthsAndSinglesPosition = FindTenthsAndSinglesPositionsInCurrentNum(currentNum);

            return hundredPosition + tenthsAndSinglesPosition;
        }
        static string FindTenthsAndSinglesPositionsInCurrentNum(int currentNum)
        {
            var tenthsDigitsOfCurrentNum = (Math.Abs(currentNum) / 10) % 10;
            var singlesDigitsOfCurrenrNum = Math.Abs(currentNum) % 10;

            var tenthsPositionResult = string.Empty;
            var singlesPositionResult = string.Empty;

            //Find the numbers up to 10
            if (tenthsDigitsOfCurrentNum != 1)
            {
                switch (singlesDigitsOfCurrenrNum)
                {
                    case 1:
                        singlesPositionResult = "one";
                        break;
                    case 2:
                        singlesPositionResult = "two";
                        break;
                    case 3:
                        singlesPositionResult = "three";
                        break;
                    case 4:
                        singlesPositionResult = "four";
                        break;
                    case 5:
                        singlesPositionResult = "five";
                        break;
                    case 6:
                        singlesPositionResult = "six";
                        break;
                    case 7:
                        singlesPositionResult = "seven";
                        break;
                    case 8:
                        singlesPositionResult = "eight";
                        break;
                    case 9:
                        singlesPositionResult = "nine";
                        break;
                }
            }
            // Detection of special cases in the case of tens
            else if (tenthsDigitsOfCurrentNum == 1)
            {
                switch (singlesDigitsOfCurrenrNum)
                {
                    case 0:
                        tenthsPositionResult = "ten";
                        break;
                    case 1:
                        tenthsPositionResult = "eleven";
                        break;
                    case 2:
                        tenthsPositionResult = "twelve";
                        break;
                    case 3:
                        tenthsPositionResult = "thirteen";
                        break;
                    case 4:
                        tenthsPositionResult = "fourteen";
                        break;
                    case 5:
                        tenthsPositionResult = "fifteen";
                        break;
                    case 6:
                        tenthsPositionResult = "sixteen";
                        break;
                    case 7:
                        tenthsPositionResult = "seventeen";
                        break;
                    case 8:
                        tenthsPositionResult = "eighteen";
                        break;
                    case 9:
                        tenthsPositionResult = "nineteen";
                        break;
                }
            }
            //Find the position of the tenths
            switch (tenthsDigitsOfCurrentNum)
            {
                case 2:
                    tenthsPositionResult = "twenty";
                    break;
                case 3:
                    tenthsPositionResult = "thirty";
                    break;
                case 4:
                    tenthsPositionResult = "forty";
                    break;
                case 5:
                    tenthsPositionResult = "fifty";
                    break;
                case 6:
                    tenthsPositionResult = "sixty";
                    break;
                case 7:
                    tenthsPositionResult = "seventy";
                    break;
                case 8:
                    tenthsPositionResult = "eighty";
                    break;
                case 9:
                    tenthsPositionResult = "ninety";
                    break;
            }
            if (tenthsDigitsOfCurrentNum == 0 && singlesDigitsOfCurrenrNum == 0)
            {
                return ""; // не работи continue
            }
            else if (tenthsDigitsOfCurrentNum == 0 && singlesDigitsOfCurrenrNum != 0)
            {
                return " and " + singlesPositionResult;
            }
            else if (tenthsDigitsOfCurrentNum != 0 && singlesDigitsOfCurrenrNum == 0)
            {
                return " and " + tenthsPositionResult;
            }
            else
            {
                return " and " + tenthsPositionResult + " " + singlesPositionResult;
            }
        }

        static string FindHundredPositinInCurrentNum(int currentNum)
        {
            var hundredDigitOfCurrentNum = (Math.Abs(currentNum) / 10) / 10;
            var hundredPositionResult = string.Empty;

            // Discovery of the hundreds
            switch (hundredDigitOfCurrentNum)
            {
                case 1:
                    hundredPositionResult = "one-hundred";
                    break;
                case 2:
                    hundredPositionResult = "two-hundred";
                    break;
                case 3:
                    hundredPositionResult = "three-hundred";
                    break;
                case 4:
                    hundredPositionResult = "four-hundred";
                    break;
                case 5:
                    hundredPositionResult = "five-hundred";
                    break;
                case 6:
                    hundredPositionResult = "six-hundred";
                    break;
                case 7:
                    hundredPositionResult = "seven-hundred";
                    break;
                case 8:
                    hundredPositionResult = "eight-hundred";
                    break;
                case 9:
                    hundredPositionResult = "nine-hundred";
                    break;
            }

            return hundredPositionResult;
        }
    }
}






