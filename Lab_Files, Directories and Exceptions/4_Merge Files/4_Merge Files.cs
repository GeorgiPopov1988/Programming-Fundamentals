namespace _4_Merge_Files
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
            string[] inputOne = File.ReadAllText("FileOne.txt").Split();
            string[] inputTwo = File.ReadAllText("FileTwo.txt").Split();

            File.WriteAllText("result.txt", "");

            for (int i = 0; i < inputOne.Length; i++)
            {
                File.AppendAllText("result.txt", inputOne[i] + "\r\n" + inputTwo[i]);
            }
        }
    }
}
