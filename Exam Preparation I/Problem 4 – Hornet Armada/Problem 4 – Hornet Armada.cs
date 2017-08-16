namespace Problem_4___Hornet_Armada
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
            Dictionary<string, int> legionActivity = new Dictionary<string, int>();
            Dictionary<string, Dictionary<string, long>> soldiers = 
                                new Dictionary<string, Dictionary<string, long>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split(new char[] { '=', '-', '>', ':', ' ' }
                    , StringSplitOptions.RemoveEmptyEntries);

                int activity = int.Parse(tokens[0]);
                string legionName = tokens[1];
                string type = tokens[2];
                long count = long.Parse(tokens[3]);

                if (!legionActivity.ContainsKey(legionName))
                {
                    legionActivity.Add(legionName, activity);
                    soldiers.Add(legionName, new Dictionary<string, long>());
                }

                if (!soldiers[legionName].ContainsKey(type))
                {
                    soldiers[legionName][type] = 0;
                }

                if (legionActivity[legionName] < activity)
                {
                    legionActivity[legionName] = activity;
                }

                soldiers[legionName][type] += count;
            }

            string[] conditions = Console.ReadLine()
                .Split('\\');

            if (conditions.Length == 1)
            {
                string soldiersType = conditions[0];

                foreach (var legion in legionActivity.OrderByDescending(l => l.Value))
                {
                    if (soldiers[legion.Key].ContainsKey(soldiersType))
                    {
                        Console.WriteLine($"{legion.Value} : {legion.Key}");
                    }
                }
            }
            else
            {
                int searchedActivity = int.Parse(conditions[0]);
                string searcherdSoldiers = conditions[1];

                foreach (var legion in soldiers
                    .Where(l => l.Value.ContainsKey(searcherdSoldiers))
                    .OrderByDescending(l => l.Value[searcherdSoldiers]))
                {
                    if (legionActivity[legion.Key] < searchedActivity)
                    {
                        Console.WriteLine($"{legion.Key} -> {legion.Value[searcherdSoldiers]}");
                    }
                    
                }
            }

        }
    }
}
