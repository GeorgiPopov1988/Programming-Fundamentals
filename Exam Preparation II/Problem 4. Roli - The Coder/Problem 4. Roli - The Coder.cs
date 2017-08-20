namespace Problem_4.Roli___The_Coder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            Dictionary<int, string> idCheck = new Dictionary<int, string>();

            Dictionary<string, List<string>> events
                = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();
            while (input != "Time for Code")
            {
                string[] tokens = input
                    .Split(" ".ToCharArray()
                    , StringSplitOptions.RemoveEmptyEntries);

                int id = int.Parse(tokens[0]);
                string eventName = tokens[1];
                List<string> participiants = tokens
                                             .Skip(2)
                                             .Where(a => a!= string.Empty)
                                             .ToList();



                if (eventName[0] != '#')
                {
                    //input = Console.ReadLine();
                    //continue;
                }
                else
                {

                    if (!idCheck.ContainsKey(id))
                    {
                        idCheck[id] = eventName;
                        events[eventName] = new List<string>();

                        foreach (var name in participiants)
                        {
                            if (!events[eventName].Contains(name))
                            {
                                events[eventName].Add(name);
                            }

                        }
                    }
                    else if (idCheck.ContainsKey(id)
                        && idCheck[id] == eventName)
                    {
                        foreach (var name in participiants)
                        {
                            if (!events[eventName].Contains(name))
                            {
                                events[eventName].Add(name);
                            }
                        }
                    }
                }
                input = Console.ReadLine();
            }
            var sorted = events.OrderByDescending(p => p.Value.Count)
                               .ThenBy(n => n.Key);

            //foreach (var @event in sorted)
            //{
            //    string name = @event.Key.Remove(0, 1);
            //    int participantCount = @event.Value.Count();
            //    List<string> particiants = @event.Value.OrderBy(n => n).ToList();

            //    Console.WriteLine($"{name} - {participantCount}");
            //    Console.WriteLine(string.Join(Environment.NewLine, particiants));
            //}

            foreach (var @event in sorted)
            {
                Console.WriteLine($"{@event.Key.Remove(0, 1)} - {@event.Value.Count}");
                foreach (var name in @event.Value.OrderBy(x => x).Distinct())
                {
                    Console.WriteLine($"{name}");


                }
            }
        }
    }
}
