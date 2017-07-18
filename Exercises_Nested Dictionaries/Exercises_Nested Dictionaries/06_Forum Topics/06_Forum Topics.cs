namespace _06_Forum_Topics
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
            string userInput = Console.ReadLine();

            Dictionary<string, List<string>> forum = AddingData(ref userInput);

            userInput = Console.ReadLine();

            PrintResult(userInput, forum);

        }

        static Dictionary<string, List<string>> AddingData(ref string userInput)
        {
            var forum = new Dictionary<string, List<string>>();

            while (userInput != "filter")
            {
                string[] input = userInput.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

                string topic = input[0];
                List<string> tags = input[1].Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();

                if (!forum.ContainsKey(topic))
                {
                    forum.Add(topic, new List<string>());
                }

                foreach (var tag in tags)
                {
                    forum[topic].Add(tag);
                }

                userInput = Console.ReadLine();

            }

            return forum;
        }

        static void PrintResult(string userInput, Dictionary<string, List<string>> forum)
        {
            string[] searchedTags = userInput.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var kvp in forum)
            {
                bool contains = true;
                var currentTags = kvp.Value;

                for (int cnt = 0; cnt < searchedTags.Length; cnt++)
                {
                    if (!currentTags.Contains(searchedTags[cnt]))
                    {
                        contains = false;
                        break;
                    }
                }

                if (contains)

                {

                    Console.WriteLine($"{kvp.Key} | #{string.Join(", #", kvp.Value)}");

                }


            }
        }
    }
}
