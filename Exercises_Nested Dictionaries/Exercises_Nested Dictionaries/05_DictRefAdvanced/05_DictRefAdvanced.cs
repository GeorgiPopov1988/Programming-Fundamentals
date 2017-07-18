
namespace _05_DictRefAdvanced
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
            string inputStr = Console.ReadLine();

            var result = new Dictionary<string, List<int>>();

            while (inputStr != "end")
            {
                string[] input = inputStr
                    .Split(new string[] { " -> " },
                     StringSplitOptions.RemoveEmptyEntries);

                var name = input[0];

                string[] evaluation = input[1]
                                     .Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                int num = 0;

                if (int.TryParse(evaluation[0], out num))
                {
                    if (!result.ContainsKey(name))
                    {
                        result[name] = new List<int>();

                    }

                    for (int cnt = 0; cnt < evaluation.Length; cnt++)
                    {
                        result[name].Add(int.Parse(evaluation[cnt]));
                    }

                }
                else
	            {
                    if (result.ContainsKey(evaluation[0]))

                    {
                        result[name] = new List<int>(result[evaluation[0]]);
                    }

                }

                inputStr = Console.ReadLine();

            }
            foreach (var name in result)

            {

                Console.WriteLine($"{name.Key} === {string.Join(", ", name.Value)}");

            }

        }
    }
}
