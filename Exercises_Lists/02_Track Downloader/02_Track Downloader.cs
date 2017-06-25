using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Track_Downloader
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] blackList = Console.ReadLine()
                .Split(' ');

            string song = Console.ReadLine();

            List<string> playList = new List<string>();



            while (song != "end")
            {
                bool isContains = false;
                for (int cnt = 0; cnt < blackList.Length; cnt++)
                {
                    if (song.Contains(blackList[cnt]))
                    {
                        isContains = true;
                    }
                }

                if (!isContains)
                {
                    playList.Add(song);
                }

                song = Console.ReadLine();
            }
            playList.Sort();

            Console.WriteLine(string.Join(Environment.NewLine, playList));

        }
    }
}
