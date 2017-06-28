namespace _06_Winecraft
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main(string[] args)
        {
            var grapeInput = Console.ReadLine()
                .Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var maxRoundCounts = int.Parse(Console.ReadLine());

            var rounds = 0;

            for (int cnt = 0; cnt < maxRoundCounts; cnt++)
            {


            }



        }
    }
}
