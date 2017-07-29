namespace _01_Exercises
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
            List<Exercisess> exercisess = new List<Exercisess>();

            string input = Console.ReadLine();

            var result = AddExercises(exercisess, input);

            Print(exercisess);
        }

        static string AddExercises(List<Exercisess> exercisess, string input)
        {
            while (input != "go go go")
            {
                string[] inputTokens = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

                string topic = inputTokens[0];
                string courseName = inputTokens[1];
                string link = inputTokens[2];
                List<string> problems = inputTokens[3]
                    .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                Exercisess newExercise = new Exercisess
                {
                    Topic = topic,
                    CourseName = courseName,
                    JudgeContestLink = link,
                    Problems = problems
                };
                exercisess.Add(newExercise);

                input = Console.ReadLine();
            }

            return input;
        }

        static void Print(List<Exercisess> exercisess)
        {
            foreach (var exercise in exercisess)
            {
                Console.WriteLine($"Exercises: {exercise.Topic}");
                Console.WriteLine($"Problems for exercises and homework for the \"{exercise.CourseName}\" course @ SoftUni.");
                Console.WriteLine($"Check your solutions here: {exercise.JudgeContestLink}");

                for (int cnt = 0; cnt < exercise.Problems.Count; cnt++)
                {
                    Console.WriteLine($"{cnt + 1}. {exercise.Problems[cnt]}");
                }
            }
        }
    }

    public class Exercisess
    {
        public string Topic { get; set; }
        public string CourseName { get; set; }
        public string JudgeContestLink { get; set; }
        public List<string> Problems { get; set; }

    }
}
