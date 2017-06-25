using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int cnt = 1; cnt <= num; cnt++)
            {
                int result = 0;
                int currentDigit = cnt;

                while (currentDigit > 0)
                {
                    result += currentDigit % 10;
                    currentDigit /= 10;
                }

                bool special = (result == 5) || (result == 7) || (result == 11);

                Console.WriteLine($"{cnt} -> {special}");
            }
        }
    }
}
