namespace Problem_3.Trainegram
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main()
        {
            List<string> results = new List<string>();
            string input = Console.ReadLine();

            var rgxTrain = @"^(\<\[[^a-zA-Z0-9]*\]\.){1}(\.{1}\[[a-zA-Z0-9]*\]\.{1})*$";
            Regex regexTrain = new Regex(rgxTrain);

            while (input != "Traincode!")
            {
                MatchCollection trainsMaches = regexTrain.Matches(input);

                foreach (Match train in trainsMaches)
                {
                    var trainResult = train.ToString();
                    results.Add(trainResult);
                }

                input = Console.ReadLine();
                
            }
            Console.WriteLine(string.Join(Environment.NewLine, results));
        }
    }
}
