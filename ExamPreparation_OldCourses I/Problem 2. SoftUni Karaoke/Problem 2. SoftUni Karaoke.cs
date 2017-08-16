namespace Problem_2.SoftUni_Karaoke
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main()
        {
            Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();

            string[] participants = Console.ReadLine()
                .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(p => p.Trim())
                .ToArray();

            string[] songs = Console.ReadLine()
                .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(p => p.Trim())
                .ToArray();

            string input = Console.ReadLine();
            while (input != "dawn")
            {
                string[] tokens = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(t => t.Trim())
                    .ToArray();

                string participant = tokens[0];
                string song = tokens[1];
                string award = tokens[2];

                if (participants.Contains(participant) 
                    && songs.Contains(song))
                {
                    if (!result.ContainsKey(participant))
                    {
                        result.Add(participant, new List<string>());
                    }

                    if (!result[participant].Contains(award))
                    {
                        result[participant].Add(award);
                    }
                }

                input = Console.ReadLine();
            }
            if (!result.Any())
            {
                Console.WriteLine("No awards");
            }

            foreach (var item in result
                                .OrderByDescending(awardsCount => awardsCount.Value.Count)
                                .ThenBy(participantName => participantName.Key))
            {

                string participant = item.Key;
                
                Console.WriteLine($"{item.Key}: {item.Value.Count} awards");
                Console.WriteLine($"--{string.Join(Environment.NewLine + "--", item.Value.OrderBy(n => n))}");
            }
        }
    }
}
