namespace _05_Closest_Two_Points
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
            int n = int.Parse(Console.ReadLine());
            List<Point> points = new List<Point>();
            double minDist = double.MaxValue;
            Point[] bestPoint = new Point[2];  //size 2!!!

            for (int cnt = 0; cnt < n; cnt++)
            {
                Point currentPoint = Point.ParsePoint(Console.ReadLine());
                points.Add(currentPoint);
            }
            for (int prevPoint = 0; prevPoint < points.Count; prevPoint++)
            {
                for (int currentPoint = prevPoint + 1; currentPoint < points.Count; currentPoint++)
                {
                    double distance = CalculateDistance(points[prevPoint], points[currentPoint]);

                    if (distance < minDist)
                    {
                        minDist = distance;
                        bestPoint[0] = points[prevPoint];
                        bestPoint[1] = points[currentPoint];
                    }
                }
            }

            Console.WriteLine($"{minDist:F3}");
            Console.WriteLine(bestPoint[0]);
            Console.WriteLine(bestPoint[1]);
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
        public override String ToString()
        {
            return String.Format($"({X}, {Y})");
        }
    }
}
