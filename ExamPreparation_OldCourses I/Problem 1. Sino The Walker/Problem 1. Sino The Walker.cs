namespace Problem_1.Sino_The_Walker
{
    using System;
    

    public class Program
    {
        public static void Main()
        {
            DateTime startTime = DateTime.Parse(Console.ReadLine());

            ulong steps = ulong.Parse(Console.ReadLine());
            ulong timeForOneStep = ulong.Parse(Console.ReadLine());

            ulong startTimeInSec = (ulong)(startTime.Hour * 60 * 60)
                                    + (ulong)(startTime.Minute * 60)
                                    + (ulong)startTime.Second;

            ulong secondsToGoHome = steps * timeForOneStep;

            ulong endTimeInSec = startTimeInSec + secondsToGoHome;

            var seconds = endTimeInSec % 60;
            var endMinutes = endTimeInSec / 60;
            var minutes = endMinutes % 60;
            var endHours = endMinutes / 60;
            var hours = endHours % 24;

            Console.WriteLine($"Time Arrival: {hours:00}:{minutes:00}:{seconds:00}");
            
        }
    }
}
