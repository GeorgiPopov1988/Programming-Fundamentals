namespace _5_Folder_Size
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
            string[] files = Directory.GetFiles("TestFolder");
            double sum = 0;

            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                sum += fileInfo.Length;
            }

            sum = sum / 1024 / 1024; // convert ot Mb's

            File.WriteAllText("оutput.txt", sum.ToString());
        }
    }
}
