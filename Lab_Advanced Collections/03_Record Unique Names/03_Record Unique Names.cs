namespace _03_Record_Unique_Names
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
            HashSet<string> names = new HashSet<string>();

            int inputCnt = int.Parse(Console.ReadLine());

            for (int cnt = 0; cnt < inputCnt; cnt++)
            {
                string currentName = Console.ReadLine();
                names.Add(currentName);
            }

            Console.WriteLine(string.Join(Environment.NewLine, names));

        }
    }
}
