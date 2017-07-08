namespace _01_Rabbit_Hole
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
            List<string> searchStages = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            int currentEnergy = int.Parse(Console.ReadLine());
            int currentPosition = 0;
            bool bombed = false;

            while (true)
            {
                string[] currentTask = searchStages[currentPosition]
                    .Split('|');

                switch (currentTask[0].ToLower())
                {
                    case "right":
                        currentPosition =
                                (currentPosition + int.Parse(currentTask[1]) % searchStages.Count);
                        currentEnergy -= int.Parse(currentTask[1]);
                        break;

                    case "left":
                        currentEnergy -= int.Parse(currentTask[1]);
                        currentPosition = 
                                Math.Abs(currentPosition - int.Parse(currentTask[1])) % searchStages.Count;
                        break;

                    case "bomb":
                        int energyTaken = int.Parse(currentTask[1]);
                        currentEnergy -= energyTaken;
                        searchStages.RemoveAt(currentPosition);
                        currentPosition = 0;
                        bombed = true;
                        break;

                    case "rabbithole":
                        Console.WriteLine("You have 5 years to save Kennedy!");
                        return;
                }

                if (currentEnergy <= 0)
                {
                    if (bombed)
                    {
                        Console.WriteLine("You are dead due to bomb explosion!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("You are tired. You can't continue the mission.");
                        break;
                    }
                }
                 
                if (searchStages[searchStages.Count - 1] != "RabbitHole")
                {
                    searchStages.RemoveAt(searchStages.Count - 1);
                }

                searchStages.Add("Bomb|" + currentEnergy);


            }


        }
    }
}
