
namespace _01_Average_Student_Grades
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
            var studetData = new Dictionary<string, List<double>>();

            int inputCnt = int.Parse(Console.ReadLine());

            for (int cnt = 0; cnt < inputCnt; cnt++)
            {
                string[] currentInput = Console.ReadLine().Split(' ');

                string name = currentInput[0];
                double grade = double.Parse(currentInput[1]);

                if (!studetData.ContainsKey(name))
                {
                    studetData.Add(name, new List<double>());
                }

                studetData[name].Add(grade);
            }
            foreach (var currentStudent in studetData)
            {
                string name = currentStudent.Key;
                List<double> grades = currentStudent.Value;
                double avg = grades.Average();

                Console.Write($"{name} -> ");
                foreach (var grade in grades)
                {
                    Console.Write($"{grade:F2} ");
                }
                Console.WriteLine($"(avg: {avg:F2})");

            }
            

        }
    }
}
