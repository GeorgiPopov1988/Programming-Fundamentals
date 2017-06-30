
namespace _01_Shoot_List_Elements
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
            var currentInput = Console.ReadLine();

            var list = new List<int>();
            var lastSybmol = 0;

            do
            {

                var itIsNumber = ItIsNumber(currentInput);

                if (itIsNumber)
                {
                    var input = int.Parse(currentInput);
                    list.Insert(0, input);
                }

                if (list.Count == 0)
                {
                    Console.WriteLine($"nobody left to shoot! last one was {lastSybmol}");
                }


                if (currentInput == "bang")
                {
                    BangTheList(list);

                    DecrementEverything(list);

                    if (list.Count == 1)
                    {
                        lastSybmol = list[0];
                    }
                   
                }
                
                currentInput = Console.ReadLine();

            } while (currentInput != "stop");

            if (list.Count == 0)
            {
                Console.WriteLine($"you shot them all. last one was {lastSybmol}");
            }
            else
            {
                Console.WriteLine($"survivors: {string.Join(" ", list)}");
            }

        }

        static void DecrementEverything(List<int> list)
        {
            for (int cnt1 = 0; cnt1 < list.Count; cnt1++)
            {
                list[cnt1] = list[cnt1] - 1;
            }
            
        }

        static void BangTheList(List<int> list)
        {
            var average = FindAverage(list);                      //list.Average();

            for (int cnt = 0; cnt < list.Count; cnt++)
            {
                var currentNum = list[cnt];

                if (currentNum <= average)
                {
                    list.RemoveAt(cnt);

                    Console.WriteLine($"shot {currentNum}");
                    return;
                }

            }


        }

        static double FindAverage(List<int> list)
        {
            var sumOfDigits = 0.0;


            foreach (var num in list)
            {
                sumOfDigits += num;
            }
            return sumOfDigits / list.Count;

        }

        static bool ItIsNumber(string currentInput)
        {
            var firstLetter = (int)currentInput[0];

            return (firstLetter >= '0' && firstLetter <= '9');
        }
    }
}
