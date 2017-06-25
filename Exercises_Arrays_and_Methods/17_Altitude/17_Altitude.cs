using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Altitude
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var currentHeight = double.Parse(input[0]);
            var result = string.Empty;

            for (int cnt = 1; cnt < input.Count; cnt += 2)
            {
                var comand = input[cnt];
                var heightChange = double.Parse(input[cnt + 1]);

                switch (comand)
                {
                    case "up":
                        currentHeight += heightChange;
                        break;
                    case "down":
                        currentHeight -= heightChange;
                        break;
                }

                if (currentHeight <= 0)
                {
                    result = "crashed";
                }
            }
            if (currentHeight > 0)
            {
                result = $"got through safely. current altitude: {currentHeight}m";
            }

            Console.WriteLine(result);
        }
    }
}
