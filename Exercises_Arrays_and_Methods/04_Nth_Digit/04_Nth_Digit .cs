using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Nth_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            long numInput = long.Parse(Console.ReadLine());
            int index = int.Parse(Console.ReadLine());

            int result = FindNthDigit(numInput, index);

            Console.WriteLine(result);
        }

        static int FindNthDigit(long numInput, int index)
        {
            int currentIndex = 1;
            int result = 0;

            while (numInput > 0)
            {
                if (currentIndex == index)
                {
                    result = (int)numInput % 10;
                    
                }
                currentIndex++;
                numInput /= 10;
            }
            return result;
        }
    }
}
