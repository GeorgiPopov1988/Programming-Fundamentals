namespace _06_Winecraft
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        static List<int> grapeInput;
        public static void Main(string[] args)
        {
            grapeInput = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

            var maxRoundCounts = int.Parse(Console.ReadLine());

            do
            {
                for (int cnt = 0; cnt < maxRoundCounts; cnt++)
                {
                    BloomGrapes();
                }

                KillGrapesWeakerOfBorder(maxRoundCounts);

            } while (LargerGrapesAreLargerOREqualThanBorder(maxRoundCounts));

            PrintAllLiveGrapes();

        }
        
        static bool LargerGrapesAreLargerOREqualThanBorder(int border)
        {
            //var strongGrapeCount = 0;

            //for (int cnt = 0; cnt < grapeInput.Count; cnt++)
            //{
            //    if (grapeInput[cnt] > border)
            //    {
            //        strongGrapeCount++;
            //    }
            //}
            //return (strongGrapeCount >= border);

            return grapeInput.Where(e => e > border).Count() >= border;

        }

        static void KillGrapesWeakerOfBorder(int border)
        {
            for (int cnt = 0; cnt < grapeInput.Count; cnt++)
            {
                if (grapeInput[cnt] <= border)
                {
                    grapeInput[cnt] = 0;
                }
            }

        }

        static void PrintAllLiveGrapes()
        {
            for (int index = 0; index < grapeInput.Count; index++)
            {
                if (IsAliveGrape(index))
                {
                    Console.Write(grapeInput[index] + " ");
                }
            }
            Console.WriteLine();
        }

        static bool IsAliveGrape(int index)
        {
            if (index < 0 || index >= grapeInput.Count)
            {
                return false;
            }
            return grapeInput[index] > 0;
        }

        static void BloomGrapes()
        {
            for (int index = 0; index < grapeInput.Count; index++)
            {
                if (!IsAliveGrape(index))
                {
                    continue;
                }

                if (IsGreaterGrape(index))
                {
                    grapeInput[index]++;
                    if (IsAliveGrape(index -1))
                    {
                        grapeInput[index]++;
                        grapeInput[index - 1]--;
                    }

                    if (IsAliveGrape(index + 1))
                    {
                        grapeInput[index]++;
                        grapeInput[index + 1]--;
                    }

                }
                else if (IsLesserGrape(index))
                {
                    //grapeInput[index]--;
                }
                else
                {
                    //noramal grape
                    grapeInput[index]++;
                }
            }
        }

        static bool IsGreaterGrape(int index)
        {
            if (index <= 0 || index >= (grapeInput.Count - 1))
            {
                return false;
            }

            return (grapeInput[index] > grapeInput[index - 1] &&
                grapeInput[index] > grapeInput[index + 1]);
        }

        static bool IsLesserGrape(int index)
        {
            return (IsGreaterGrape(index - 1) ||
                    IsGreaterGrape(index + 1));
        }
    }
}
