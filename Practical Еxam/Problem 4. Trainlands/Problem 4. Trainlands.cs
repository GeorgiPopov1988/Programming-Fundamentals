namespace Problem_4.Trainlands
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
            Dictionary<string, Dictionary<string, int>> trainData
                = new Dictionary<string, Dictionary<string, int>>();

            //Dictionary<string, int> wagonData = new Dictionary<string, int>();

            string input = Console.ReadLine();

            while (input != "It's Training Men!")
            {
                string[] tokens = input.Split();
                if (tokens.Length > 3)
                {
                    string trainName = tokens[0];
                    string wagonName = tokens[2];
                    int power = int.Parse(tokens[4]);

                    //wagonData.Add(wagonName, power);

                    if (!trainData.ContainsKey(trainName))
                    {
                        trainData.Add(trainName, new Dictionary<string, int>());
                    }
                    if (!trainData[trainName].ContainsKey(wagonName))
                    {
                        trainData[trainName].Add(wagonName, 0);
                    }
                    trainData[trainName][wagonName] = power;

                }
                else
                {
                    string first = tokens[0];
                    string second = tokens[2];
                    string command = tokens[1];

                    switch (command)
                    {
                        case "->":
                            {
                                RemovalAndDestruction(trainData, first, second);
                                break;
                            }
                        case "=":
                            {
                                Duplication(trainData, first, second);
                                break;
                            }
                    }

                }

                input = Console.ReadLine();
            }
            foreach (var train in trainData
                                  .OrderByDescending(p => p.Value.Values.Sum())
                                  .ThenBy(w => w.Value.Count))
            {
                Console.WriteLine($"Train: {train.Key}");
                var wagons = train.Value;
            
                foreach (var wagon in wagons
                                      .OrderByDescending(p => p.Value))
                {
                    string wagonName = wagon.Key;
                    int wagonPwr = wagon.Value;

                    Console.WriteLine($"###{wagonName} - {wagonPwr}");
                }
            }

        }

        public static void Duplication(Dictionary<string,
                                       Dictionary<string, int>> trainData, string first, string second)
        {
            Dictionary<string, int> duplicater = trainData[second];
            int duplicateWagPower = 0;
            string duplicWagName = string.Empty;
            if (!trainData.ContainsKey(first))
            {
                trainData.Add(first, new Dictionary<string, int>());
            }

            trainData[first].Clear();


            foreach (var duplicateWagon in duplicater)
            {
                duplicWagName = duplicateWagon.Key;
                duplicateWagPower = duplicateWagon.Value;
            
                trainData[first][duplicWagName] = duplicateWagPower;
            }

        }

        public static void RemovalAndDestruction(Dictionary<string,
                                                  Dictionary<string, int>> trainData, string accepter, string destroyed)
        {
            Dictionary<string,int> destroyedTrain = trainData[destroyed];
            int destPower = 0;
            string destWagName = string.Empty;

            foreach (var destWagon in destroyedTrain)
            {
                destWagName = destWagon.Key;
                destPower = destWagon.Value;
                if (!trainData.ContainsKey(accepter))
                {
                    trainData.Add(accepter, new Dictionary<string, int>());

                }
                if (!trainData[accepter].ContainsKey(destWagName))
                {
                    trainData[accepter].Add(destWagName, destPower);
                }
                trainData[accepter][destWagName] = destPower;
            }

            trainData.Remove(destroyed);

        }
    }
}

