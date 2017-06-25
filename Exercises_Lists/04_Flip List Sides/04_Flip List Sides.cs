using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Flip_List_Sides
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var firstNumber = inputList[0];
            var lastNumber = inputList[inputList.Count - 1];

            inputList.RemoveAt(0);
            inputList.RemoveAt(inputList.Count - 1);

            inputList.Reverse();

            inputList.Add(lastNumber);
            inputList.Insert(0, firstNumber);

            Console.WriteLine(string.Join(" ", inputList));

        }
    }
}
