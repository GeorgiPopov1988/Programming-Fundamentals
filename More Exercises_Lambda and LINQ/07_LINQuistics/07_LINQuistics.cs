namespace _07_LINQuistics
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
            string inputLine = Console.ReadLine();
            var data = new Dictionary<string, List<string>>();

            while (inputLine != "exit")
            {
                string[] tokens = inputLine
                    .Split(new string[] { ".", "()" }, StringSplitOptions.RemoveEmptyEntries);

                string collectionName = tokens[0];

                int lenght = 0;
                if (tokens.Length == 1)
                {
                    try
                    {
                        lenght = int.Parse(collectionName);
                        //int.TryParse(collectionName,out lenght);

                        string[] restrictedMetods = data.Values
                            .OrderByDescending(c => c.Count)
                            .First()//Take firs string[], for current colletionName
                            .ToArray()
                            .OrderBy(l => l.Length)
                            .Take(lenght)
                            .ToArray();
                        for (int cnt = 0; cnt < restrictedMetods.Length; cnt++)
                        {
                            Console.Write("* ");
                            Console.WriteLine(restrictedMetods[cnt]);
                        }
                    }
                    catch (Exception)
                    {
                        if (!data.ContainsKey(collectionName))
                        {
                            //Console.WriteLine("Invalid input!");
                        }
                        else
                        {
                            string[] methods = data[collectionName]
                           .OrderByDescending(l => l.Length)
                           .ThenByDescending(d => d.Distinct().Count())
                           .ToArray();

                            for (int cnt = 0; cnt < methods.Length; cnt++)
                            {
                                Console.Write("* ");
                                Console.WriteLine(methods[cnt]);
                            }
                        }
                    }
                }

                else
                {
                    if (!data.ContainsKey(collectionName))
                    {
                        data.Add(collectionName, new List<string>());
                    }
                    for (int cnt = 1; cnt < tokens.Length; cnt++)
                    {
                        if (!data[collectionName].Contains(tokens[cnt]))
                        {
                            data[collectionName].Add(tokens[cnt]);
                        }
                    }
                }

                inputLine = Console.ReadLine();
            }

            inputLine = Console.ReadLine();

            string[] command = inputLine.Split(' ');

            string methodName = command[0];
            string lastCommand = command[1];

            if (lastCommand == "collection")
            {
                var dataCollections = data.Where(v => v.Value.Contains(methodName))
                                          .OrderByDescending(v => v.Value.Count)
                                          .ThenBy(mv => mv.Value.Min());

                foreach (var collections in dataCollections)
                {
                    Console.WriteLine(collections.Key);
                }

            }
            else if (lastCommand == "all")
            {
                var dataCollections = data.Where(v => v.Value.Contains(methodName))
                                          .OrderByDescending(v => v.Value.Count)
                                          .ThenByDescending(mv => mv.Value.Min());

                foreach (var collections in dataCollections)
                {
                    Console.WriteLine(collections.Key);

                    List<string> methods = collections.Value
                    .OrderByDescending(l => l.Length)
                    .ToList();

                    for (int cnt = 0; cnt < methods.Count; cnt++)
                    {
                        Console.WriteLine($"* {methods[cnt]}");
                    }
                }
            }
        }
    }
}
