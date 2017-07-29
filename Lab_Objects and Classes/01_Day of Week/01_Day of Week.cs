namespace _01_Day_of_Week
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main()
        {
            DateTime inputData = DateTime.ParseExact(
                Console.ReadLine(),
                "d-M-yyyy",
                CultureInfo.InvariantCulture);

            Console.WriteLine(inputData.DayOfWeek);

        }
    }
}
