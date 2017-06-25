using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_BPM_Counter
{
    class Program
    {
        static void Main()
        {
            double bpm = double.Parse(Console.ReadLine());
            double beats = double.Parse(Console.ReadLine());

            int minutes = 0;
            int seconds = 0;

            seconds = (int)((beats / bpm) * 60);

            minutes = seconds / 60;
            seconds = seconds % 60;

            double bars = beats / 4.0;

            Console.WriteLine($"{Math.Round(bars, 1)} bars - {minutes}m {seconds}s");

        }
    }
}
