namespace _04_SoftUni_Beer_Pong
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
            var teamsRezults = new Dictionary<string, Dictionary<string, int>>();

            string userInput = Console.ReadLine();

            while (userInput != "stop the game")
            {
                string[] inputTokens = userInput
                    .Split(new char[] { '|' },
                    StringSplitOptions.RemoveEmptyEntries);

                string playerName = inputTokens[0];
                string teamName = inputTokens[1];
                int points = int.Parse(inputTokens[2]);

                if (!teamsRezults.ContainsKey(teamName))
                {
                    teamsRezults[teamName] = new Dictionary<string, int>();
                }

                if (teamsRezults[teamName].Count < 3)
                {
                    teamsRezults[teamName][playerName] = points;
                }

                userInput = Console.ReadLine();
            }

            teamsRezults = teamsRezults
                .Where(v => v.Value.Keys.Count == 3)
                .ToDictionary(k => k.Key, v => v.Value)
                .OrderByDescending(v => v.Value.Values.Sum())
                .ToDictionary(k => k.Key, v => v.Value);

            int index = 1;

            foreach (var team in teamsRezults)
            {
                Console.WriteLine($"{index}. {team.Key}; Players:");

                var currentPlayer = team.Value
                    .OrderByDescending(v => v.Value)
                    .ToDictionary(k => k.Key, v => v.Value);

                foreach (var personalData in currentPlayer)
                {
                    Console.WriteLine($"###{personalData.Key}: {personalData.Value}");
                }

                index++;
            }
        }
    }
}
