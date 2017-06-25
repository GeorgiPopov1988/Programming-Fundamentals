
namespace _05_Char_Rotation
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

            var chars = Console.ReadLine()
                .ToCharArray();


            var numbersInput = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();


            var result = string.Empty;


            for (int cnt = 0; cnt < numbersInput.Length; cnt++)
            {

                if (numbersInput[cnt] % 2 != 0)
                {
                    result += (char)(numbersInput[cnt] + chars[cnt]);
                }

                else
                {
                    result += (char)(chars[cnt] - numbersInput[cnt]);
                }
            }
            Console.WriteLine(result);
        }
    }
}