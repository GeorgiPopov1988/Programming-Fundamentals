namespace Problem_4.Files
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
            Dictionary<string, Dictionary<string, string>> result =
                               new Dictionary<string, Dictionary<string, string>>();
            Dictionary<string, string> fileData = new Dictionary<string, string>();

            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split(';').ToArray();
                string[] folderTokens = tokens[0]
                    .Split('\\').ToArray();
                string fileNameAndExtension = folderTokens[folderTokens.Length - 1];

                string fileSize = tokens[tokens.Length - 1];
                string root = folderTokens[0];
                //string fileName = fileNameAndExtension[0];
                //string fileExtension = fileNameAndExtension[1];

                if (result.ContainsKey(root))
                {
                    result[root].Add(fileNameAndExtension, fileSize);
                    // result[root][fileName] = fileSize;
                }
                else
                {
                    fileData = new Dictionary<string, string>();
                    fileData[fileNameAndExtension] = fileSize;

                    result[root] = fileData;
                }
            }

            string[] subject = Console.ReadLine()
                .Split();

            string fileTypeSubject = subject[0];
            string rootSubject = subject[2];

            fileData = result[rootSubject]
                .OrderByDescending(id => id.Value)
                .ThenBy(id => id.Key)
                .ToDictionary(id => id.Key, id => id.Value);

            bool haveResult = false;

            foreach (KeyValuePair<string, string> file in fileData)
            {
                string[] fileNameAndType = file.Key.Split('.');
                string fileType = fileNameAndType[1];

                if (fileType.Equals(fileTypeSubject))
                {
                    haveResult = true;
                    Console.WriteLine($"{file.Key} - {file.Value} KB");
                }
            }
            if (!haveResult)
            {
                Console.WriteLine("No");
            }
        }
    }
}
