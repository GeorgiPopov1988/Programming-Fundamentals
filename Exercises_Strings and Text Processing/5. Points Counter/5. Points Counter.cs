namespace _5.Points_Counter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Player
    {
        public string Name { get; set; }
        public int Points { get; set; }

        public Player(string name, int points)
        {
            this.Name = name;
            this.Points = points;
        }
        public override bool Equals(object obj)
        {
            if (obj is Player)
            {
                Player other = (Player)obj;
                return this.Name == other.Name;
            }
            return false;
        }
    }
    public class Program
    {
        public static void Main()
        {
            var data = new Dictionary<string, List<Player>>();

            string input = Console.ReadLine();

            while (input != "Result")
            {
                string[] tokens = input.Split('|');

                string teamName;
                string playerName;

                int points = int.Parse(tokens[2]);

                if (IsTeamName(tokens[0]))
                {
                    teamName = tokens[0];
                    playerName = tokens[1];
                }
                else
                {
                    teamName = tokens[1];
                    playerName = tokens[0];
                }

                teamName = CleanString(teamName);
                playerName = CleanString(playerName);

                if (!data.ContainsKey(teamName))
                {
                    data.Add(teamName, new List<Player>());
                }

                Player currentPlayer = new Player(playerName, points);

                if (!data[teamName].Contains(currentPlayer))
                {
                    data[teamName].Add(currentPlayer);
                    
                }
                else
                {
                    int index = data[teamName].IndexOf(currentPlayer);
                    data[teamName][index] = currentPlayer;
                }

                input = Console.ReadLine();
            }

            var orderedData = data
                .OrderByDescending(t => t.Value.Sum(p => p.Points));

            foreach (var teamData in orderedData)
            {
                string teamName = teamData.Key;
                List<Player> players = teamData.Value;

                int totalPts = players.Sum(p => p.Points);

                Player bestPlayer = players.OrderByDescending(p => p.Points).First();

                Console.WriteLine("{0} => {1}", 
                    teamName, totalPts);
                Console.WriteLine("Most points scored by {0}",
                    bestPlayer.Name);
            }

        }

        static string CleanString(string input)
        {
            input = input.Replace("@", "");
            input = input.Replace("%", "");
            input = input.Replace("$", "");
            input = input.Replace("*", "");

            return input;
        }
        

        static bool IsTeamName(string name)
        {
            return !name.Any(ch => char.IsLower(ch));

            //for (int index = 0; index < name.Length; index++)
            //{
            //    if (char.IsLower(name[index]))
            //    {
            //        return false;
            //    }
            //    return true;
            //}
        }
      
    }
}
