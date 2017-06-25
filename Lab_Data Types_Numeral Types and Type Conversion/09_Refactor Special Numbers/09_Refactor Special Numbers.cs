using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int cnt = 1; cnt <= num; cnt++)
            {
                int sum = 0;
                int currentNum = cnt;

                while (currentNum > 0)
                {
                    sum += currentNum % 10;
                    currentNum = currentNum / 10;
                }

                bool specialOrNot = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{cnt} -> {specialOrNot}");
            }
        }
    }
}
