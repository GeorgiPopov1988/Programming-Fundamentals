namespace _3_JSON_Stringify
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
            string input = Console.ReadLine();
            StringBuilder builder = new StringBuilder();

            builder.Append("[");

            while (input != "stringify")
            {
                string[] inputTokens = input
                    .Split(new string[] { " : ", " ->" }, 
                    StringSplitOptions.RemoveEmptyEntries);

                //string[] inputTokens = input
                //.Split(new string[] { " : ", " ->" },
                //       StringSplitOptions.RemoveEmptyEntries);

                //string[] inputTokens = input
                //    .Split(" ,:->".ToCharArray(),
                //    StringSplitOptions.RemoveEmptyEntries);

                string name = inputTokens[0];
                string age = inputTokens[1];

                string[] grades = new string[] { };
                if (inputTokens.Length > 2)
                {
                    grades = inputTokens[2]
                   .Split(new string[] { ", ", ",", " " },
                   StringSplitOptions.RemoveEmptyEntries);
                }

                // builder.Append("["); // escape {} or duble {{ for escape
                builder.Append(string.Format("{{name:\"{0}\",age:{1},grades:[{2}]}},",
                                            name, age, string.Join(", ", grades)));
                //  builder.Append("]");
               
                input = Console.ReadLine();
            }

            builder.Remove(builder.Length - 1, 1);
            builder.Append("]");

            Console.WriteLine(builder.ToString());
        }
    }
}
