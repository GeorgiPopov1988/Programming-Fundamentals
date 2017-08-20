namespace Problem_2.Ladybugs
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
            int size = int.Parse(Console.ReadLine());

            int[] indexes = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .Where(i => i >= 0 && i < size)
                .ToArray();

            int[] ladyBugs = new int[size];

            for (int i = 0; i < indexes.Length; i++)
            {
                int currentLadyBugIndex = indexes[i];
                ladyBugs[currentLadyBugIndex] = 1;

            }

            string inputCommand = Console.ReadLine();
            while (inputCommand != "end")
            {
                string[] command = inputCommand
                    .Split(' ');

                int ladyBugIndex = int.Parse(command[0]);
                string direction = command[1];
                int flyLength = int.Parse(command[2]);

                if (ladyBugIndex < 0 || ladyBugIndex >= ladyBugs.Length)
                {
                    inputCommand = Console.ReadLine();
                    continue;
                }
                if (ladyBugs[ladyBugIndex] == 0)
                {
                    inputCommand = Console.ReadLine();
                    continue;
                }

                MoveLadyBug(ladyBugs, ladyBugIndex, flyLength, direction);
            


                inputCommand = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", ladyBugs));
        }

        private static void MoveLadyBug
                            (int[] ladyBugs, int ladyBugIndex, int flyLength, string direction)
        {
            ladyBugs[ladyBugIndex] = 0;

            bool leftArrayOrFoundPlace = false;
            while (!leftArrayOrFoundPlace)
            {
                switch (direction)
                {
                    case "right":
                        {
                            ladyBugIndex += flyLength;
                            break;
                        }
                    case "left":
                        {
                            ladyBugIndex -= flyLength;
                            break;
                        }
                }

                if (ladyBugIndex < 0 || ladyBugIndex >= ladyBugs.Length)
                {
                    leftArrayOrFoundPlace = true; // Left array!!!
                    continue;
                }

                if (ladyBugs[ladyBugIndex] == 1)
                {
                    continue; // stepped over another ladybug keef fly
                }

                if (ladyBugs[ladyBugIndex] == 0)
                {
                    ladyBugs[ladyBugIndex] = 1;
                    leftArrayOrFoundPlace = true; // found our place in the array
                    continue;
                }

            }
        }   
    }
}
