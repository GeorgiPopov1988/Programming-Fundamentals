namespace _4.JSON_Parse
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int[] Grades { get; set; }

        public Student(string name, int age, int[] grades)
        {
            this.Name = name;
            this.Age = age;
            this.Grades = grades;
        }
    }

    public class Program
    {
        public static void Main()
        {
            List<String> studens = new List<string>();

            string input = Console.ReadLine();
            input = input.Substring(2, input.Length - 2 - 2); // remove [{ in begin and  }] in end
            string[] tokens = input
                .Split(new string[] { "},{" },
                StringSplitOptions.RemoveEmptyEntries);

            foreach (string token in tokens)
            {
                string[] studentData = token
                    .Split(new string[] { ",age:", ",grades:" },
                    StringSplitOptions.RemoveEmptyEntries);

                string name = studentData[0]
                    .Substring(6, studentData[0].Length - 6 - 1); // or -> studentData = token.Split( name:\""
                string age = studentData[1];
                string grades = studentData[2]
                    .Substring(1, studentData[2].Length - 1 - 1); // remove ![! grades !]!

                if (grades == string.Empty)
                {
                    grades = "None";
                }
                Console.WriteLine("{0} : {1} -> {2}",
                    name, age, grades);
            }
        }
    }
}
