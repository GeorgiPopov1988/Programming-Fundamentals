namespace _5.String_Commander
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static string stringToManipulate = Console.ReadLine();

        public static void Main()
        {
            string inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                string[] tokens = inputLine
                    .Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries);

                int times = 0;
                string command = tokens[0];

                switch (command)
                {

                    case "Left":
                        times = int.Parse(tokens[1]);
                        MoveToTheLeft(times);
                        break;

                    case "Right":
                        times = int.Parse(tokens[1]);
                        MoveToTheRight(times);
                        break;

                    case "Insert":
                        int index = int.Parse(tokens[1]);
                        string stringToInsert = tokens[2];
                        InsertString(index, stringToInsert);
                        break;

                    case "Delete":
                        int startIndex = int.Parse(tokens[1]);
                        int endIndex = int.Parse(tokens[2]);
                        DeleteFromTo(startIndex, endIndex);
                        break;

                }

                inputLine = Console.ReadLine();
            }

            Console.WriteLine(stringToManipulate);

        }


        static void DeleteFromTo(int start, int end)
        {
            stringToManipulate = stringToManipulate.Remove(start, end - start + 1);
        }
        
        static void InsertString(int index, string stringToInsert)
        {
            stringToManipulate = stringToManipulate.Insert(index, stringToInsert);
        }
        
        static void MoveToTheRight(int times)
        {

            //times %= stringToManipulate.Length;

            //stringToManipulate = stringToManipulate
            //               .Substring(stringToManipulate.Length - times) 
            //               + stringToManipulate.Substring(0, stringToManipulate.Length - times);

            for (int i = 0; i < times; i++)
            {
                stringToManipulate = stringToManipulate
                    .Remove(stringToManipulate.Length - 1, 1)
                    .Insert(0, stringToManipulate.Last()
                    .ToString());
            }

        }
        
        static void MoveToTheLeft(int times)
        {
            //times %= stringToManipulate.Length;

            //stringToManipulate = stringToManipulate
            //    .Substring(times) + stringToManipulate.Substring(0, times);

            for (int i = 0; i < times; i++)
            {
                stringToManipulate = stringToManipulate
                    .Remove(0, 1)
                    .Insert(stringToManipulate.Length - 1, stringToManipulate.First()
                    .ToString());
            }
        }
    }
}
