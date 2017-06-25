using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(' ');
            string[] names = Console.ReadLine().Split(' ');

            string findName = Console.ReadLine();

            while (findName != "done")
            {
                for (int cnt = 0; cnt < names.Length; cnt++)
                {
                    if (names[cnt] == findName)
                    {
                        Console.WriteLine($"{names[cnt]} -> {numbers[cnt]}");
                    }
                }
                findName = Console.ReadLine();
            }
        }
    }
}
