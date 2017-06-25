using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Count_of_Negative_Elements_in_Array
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int arrayCounter = int.Parse(Console.ReadLine());

            int[] arr = new int[arrayCounter];

            for (int cnt = 0; cnt < arrayCounter; cnt++)
            {
                int currentInput = int.Parse(Console.ReadLine());
                arr[cnt] = currentInput;
            }

            int negativeCounter = 0;
            for (int cnt = 0; cnt < arr.Length; cnt++)
            {
                if (arr[cnt] < 0)
                {
                    negativeCounter++;
                }
            }
            Console.WriteLine(negativeCounter);
        }
    }
}
