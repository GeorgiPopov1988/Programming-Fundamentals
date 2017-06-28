namespace _04_Ununion_Lists
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
            var primalList = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var inputCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputCount; i++)
            {
                var inputList = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

                for (int cnt = 0; cnt < inputList.Count; cnt++)
                {
                    var currentNum = inputList[cnt];

                    if (primalList.Contains(currentNum))
                    {
                        primalList.Remove(currentNum);
                    }
                    else
                    {
                        primalList.Add(currentNum);
                    }
                }
            }

            primalList.Sort();
            Console.WriteLine(string.Join(" ", primalList));
        }
    }
}
