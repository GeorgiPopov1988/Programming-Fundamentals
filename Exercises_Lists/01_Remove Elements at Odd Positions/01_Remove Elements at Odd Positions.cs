using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Remove_Elements_at_Odd_Positions
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputString = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var result = new List<string>();

            for (int cnt = 1; cnt < inputString.Count; cnt += 2)
            {
                result.Add(inputString[cnt]);
            }

            Console.WriteLine(string.Join("", result));
        }
    }
}
