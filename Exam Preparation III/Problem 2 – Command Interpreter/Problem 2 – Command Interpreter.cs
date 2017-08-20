namespace Problem_2___Command_Interpreter
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
            List<string> collection = Console.ReadLine()
                 .Split(" ".ToCharArray()
                 , StringSplitOptions.RemoveEmptyEntries)
                 .ToList();

            string inputCommand = Console.ReadLine();

            while (inputCommand != "end")
            {
                string[] commandTokens = inputCommand
                    .Split(" ".ToCharArray()
                    , StringSplitOptions.RemoveEmptyEntries);

                string command = commandTokens[0];


                switch (command)
                {
                    case "reverse":
                        {
                            int from = int.Parse(commandTokens[2]);
                            int count = int.Parse(commandTokens[4]);
                            Reverse(collection, from, count);
                            break;
                        }
                    case "sort":
                        {
                            int from = int.Parse(commandTokens[2]);
                            int count = int.Parse(commandTokens[4]);
                            Sort(collection, from, count);
                            break;
                        }
                    case "rollLeft":
                        {
                            int count = int.Parse(commandTokens[1]) % collection.Count;
                            RollLeft(collection, count);
                            break;
                        }
                    case "rollRight":
                        {
                            int count = int.Parse(commandTokens[1]) % collection.Count;
                            RollRight(collection, count);
                            break;
                        }
                }

                inputCommand = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", collection)}]");
        }

        private static void RollRight(List<string> collection, int count)
        {
            if (count < 0)
            {
                Console.WriteLine("Invalid input parameters.");
                return;
            }
            for (int i = 0; i < count; i++)
            {
                string lastElement = collection[collection.Count - 1];
                collection.RemoveAt(collection.Count - 1);
                collection.Insert(0, lastElement);
            }

        }

        static void RollLeft(List<string> collection, int count)
        {
            if (count < 0)
            {
                Console.WriteLine("Invalid input parameters.");
                return;
            }

            for (int i = 0; i < count; i++)
            {
                string firstElement = collection[0];
                collection.RemoveAt(0);
                collection.Add(firstElement);
            }
        }

        static void Sort(List<string> collection, int from, int count)
        {
            if (from < 0 
                || from >= collection.Count 
                || count < 0 
                || from + count > collection.Count)
            {
                Console.WriteLine("Invalid input parameters.");
                return;
            }
            collection.Sort(from, count, StringComparer.InvariantCulture);
            //List<string> sort = collection.Skip(from).Take(count).OrderBy(s => s).ToList();

            //for (int i = from; i < from + count; i++)
            //{
            //    collection[i] = sort[i - from];
            //}
        }

        static void Reverse(List<string> collection, int from, int count)
        {
            if (from < 0
                || from >= collection.Count
                || count < 0
                || from + count > collection.Count)
            {
                Console.WriteLine("Invalid input parameters.");
                return;
            }
            collection.Reverse(from, count);
            //List<string> reverse = collection.Skip(from).Take(count).Reverse().ToList();

            //for (int i = from; i < from + count; i++)
            //{
            //    collection[i] = reverse[i - from];
            //}
        }
    }
}
