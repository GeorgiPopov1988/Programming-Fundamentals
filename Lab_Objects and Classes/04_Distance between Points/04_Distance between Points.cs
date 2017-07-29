namespace _04_Distance_between_Points
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
            Point firstPoint = Point.ParsePoint(Console.ReadLine());
            Point secondPoint = Point.ParsePoint(Console.ReadLine());

            double distance = CalculateDistance(firstPoint, secondPoint);

            Console.WriteLine($"{distance:F3}");
        }

        private static double CalculateDistance(Point firstPoint, Point secondPoint)
        {
            double sideA = Math.Pow((firstPoint.X - secondPoint.X), 2);
            double sideB = Math.Pow((firstPoint.Y - secondPoint.Y), 2);

            return Math.Sqrt(sideA + sideB);
        }
    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int xCoord, int yCoord)
        {
            X = xCoord;
            Y = yCoord;
        }

        public static Point ParsePoint(string input)
        {
            int[] inputData = input.Split(' ').Select(int.Parse).ToArray();

            return new Point(inputData[0], inputData[1]);
        }
    }
}