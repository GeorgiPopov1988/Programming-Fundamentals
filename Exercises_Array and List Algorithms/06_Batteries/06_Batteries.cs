namespace _06_Batteries
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
            var capacity = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            var usagePerHour = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            var testHours = int.Parse(Console.ReadLine());
            var usedChargeForTest = UsedChargeForTest(capacity, usagePerHour, testHours);

            var chargeLeftAfterTest = BatteryChargeLeftAfterTest(capacity, usagePerHour, usedChargeForTest);
            ResultOutput(capacity, testHours, chargeLeftAfterTest);
        }

        static List<double> UsedChargeForTest(double[] capacity, double[] usagePerHour, int hours)
        {
            var usedChargeForTest = new List<double>();

            for (int mAh = 0; mAh < capacity.Length; mAh++)
            {
                var usage = usagePerHour[mAh] * (double)hours;

                usedChargeForTest.Insert(mAh, usage);
            }
            return usedChargeForTest;
        }

        static void ResultOutput(double[] capacity, int hours, List<double> chargeLeft)
        {
            for (int cnt = 0; cnt < chargeLeft.Count; cnt++)
            {
                var battery = chargeLeft[cnt];

                if (battery > hours)
                {
                    var percentage = (battery * 100) / capacity[cnt];
                    Console.WriteLine($"Battery {cnt + 1}: {battery:f2} mAh ({percentage:f2})%");
                }
                else
                {
                    Console.WriteLine($"Battery {cnt + 1}: dead (lasted {battery} hours)");
                }
            }
        }

        static List<double> BatteryChargeLeftAfterTest(double[] capacity, double[] usagePerHour, List<double> batteryCharge)
        {
            var chargeLeft = new List<double>();

            for (int cnt = 0; cnt < capacity.Length; cnt++)
            {
                if (capacity[cnt] >= batteryCharge[cnt])
                {
                    var resultCapacity = capacity[cnt] - batteryCharge[cnt];
                    chargeLeft.Insert(cnt, resultCapacity);
                }
                else if (capacity[cnt] < batteryCharge[cnt])
                {
                    var deadHours = Math.Ceiling(capacity[cnt] / usagePerHour[cnt]);
                    chargeLeft.Insert(cnt, deadHours);
                }
            }
            return chargeLeft;
        }
    }
    
}
