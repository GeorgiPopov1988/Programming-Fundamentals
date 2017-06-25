using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Power_Plants
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] plantsLiveDuration = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            int daysInSeason = plantsLiveDuration.Length;
            int daysCnt = 0;
            int seasons = 0;

            while (HaveTheySurvived(plantsLiveDuration))
            {
                for (int cnt = 0; cnt < plantsLiveDuration.Length; cnt++)
                {
                    if (plantsLiveDuration[cnt] != 0)
                    {
                        if ((daysCnt % daysInSeason) != cnt)
                        {
                            plantsLiveDuration[cnt]--;
                        }

                    }
                }

                daysCnt++;

                if (daysCnt % daysInSeason == 0)
                {
                    for (int cnt = 0; cnt < plantsLiveDuration.Length; cnt++)
                    {
                        if (plantsLiveDuration[cnt] != 0)
                        {
                            plantsLiveDuration[cnt]++;
                        }
                    }
                    seasons++;
                }

            }

            string seasonFormat = "seasons";
            if (seasons == 1 || seasons == 0)
            {
                seasonFormat = "season";
            }

            Console.WriteLine($"survived {daysCnt} days ({seasons} {seasonFormat})");
        }

        static bool HaveTheySurvived(int[] plantsLiveDuration)
        {
            for (int cnt = 0; cnt < plantsLiveDuration.Length; cnt++)
            {
                if (plantsLiveDuration[cnt] > 0)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
