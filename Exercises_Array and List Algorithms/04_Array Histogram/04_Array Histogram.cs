namespace _04_Array_Histogram
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
            List<string> words = new List<string>();
            List<int> counts = new List<int>();

            var inputString = Console.ReadLine()
                .Split( ' ' )
                .ToArray();

            for (int cnt = 0; cnt < inputString.Length; cnt++)
            {
                if (!words.Contains(inputString[cnt]))
                {
                    words.Add(inputString[cnt]);
                    counts.Add(1);
                }
                else
                {
                    int index = words.IndexOf(inputString[cnt]);
                    counts[index]++;
                }
            }




            for (int firstUnsprted = 0; firstUnsprted < counts.Count - 1; firstUnsprted++)
            {
                var i = firstUnsprted + 1;

                while (i > 0)
                {
                    if (counts[i - 1] < counts[i])
                    {
                        int tempCount = counts[i];
                        counts[i] = counts[i - 1];
                        counts[i - 1] = tempCount;

                        string tempWords = words[i];
                        words[i] = words[i - 1];
                        words[i - 1] = tempWords;
                    }

                    i--;
                }
            }


            for (int cnt = 0; cnt < words.Count; cnt++)
            {
                double percentages = ((double)counts[cnt] / (double)inputString.Length) * 100;

                Console.WriteLine($"{words[cnt]} -> {counts[cnt]} times ({percentages:F2}%)");
            }
            
        }
    }
}
