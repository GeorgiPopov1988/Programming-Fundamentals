using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08__String_Encryption
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int charCnt = int.Parse(Console.ReadLine());
            string result = string.Empty;

            for (int cnt = 0; cnt < charCnt; cnt++)
            {
                char currentChar = char.Parse(Console.ReadLine());

                var encrypted = Encrypt(currentChar);

                result += encrypted;
            }
            Console.WriteLine(result);

        }

        static string Encrypt(char currentChar)
        {
            var asciiCode = (int)currentChar;
            var firstDigit = GetFirstDigit(asciiCode);
            var lastDigit = GetLastDigit(asciiCode);

            var firstPart = (char)(asciiCode + lastDigit);   
            var secondPart = (char)(asciiCode - firstDigit);

            var result = $"{firstPart}{firstDigit}{lastDigit}{secondPart}";

            return result.ToString();
        }

        private static int GetLastDigit(int asciiCode)
        {
            return asciiCode % 10;
        }

        static int GetFirstDigit(int asciiCode)
        {
            var firstDigit = asciiCode;

            while (firstDigit >= 10)
            {
                firstDigit /= 10;
            }
            return firstDigit;
        }
    }
}
