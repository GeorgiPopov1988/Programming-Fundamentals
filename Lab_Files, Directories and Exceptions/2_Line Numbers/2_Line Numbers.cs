namespace _2_Line_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO;

    public class Program
    {
        public static void Main()
        {
            string[] textInput = File.ReadAllLines("input.txt");
            var result = textInput.Select((line, index) => $"{index + 1}. {line}");

            File.WriteAllLines("result.txt", result);

            for (int i = 0; i < textInput.Length; i++)
            {
                File.AppendAllText("ress.txt", $"{(i + 1)}. {textInput[i]}\r\n");
            }
        }
    }
}
