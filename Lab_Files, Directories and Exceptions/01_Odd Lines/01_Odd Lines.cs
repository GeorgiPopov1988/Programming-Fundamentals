namespace _01_Odd_Lines
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main()
        {
            string[] text = File.ReadAllLines("input.txt");

            for (int i = 1; i < text.Length; i += 2)
            {
                Console.WriteLine(text[i]);
            }

            //string[] lines = File.ReadAllLines("lines.txt");
            //var oddLines = lines.Where((line, index) => index % 2 == 1);
            //File.WriteAllLines("odd-lines.txt", oddLines);

            //string[] lines = File.ReadAllLines("lines.txt");
            //File.Delete("odd-lines.txt");
            //for (int i = 1; i < lines.Length; i += 2)
            //    File.AppendAllText("odd-lines.txt",
            //      lines[i] + Environment.NewLine);


        }
    }
}
