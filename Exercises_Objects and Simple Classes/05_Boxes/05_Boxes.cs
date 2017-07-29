namespace _05_Boxes
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
            List<Box> boxes = new List<Box>();
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input.Split(" :|".ToArray(), StringSplitOptions.RemoveEmptyEntries);

                Poiont upLeft = new Poiont()
                {
                    X = int.Parse(tokens[0]),
                    Y = int.Parse(tokens[1])    
                };
                Poiont upRight = new Poiont()
                {
                    X = int.Parse(tokens[2]),
                    Y = int.Parse(tokens[3])    
                };
                Poiont downLeft = new Poiont()
                {
                    X = int.Parse(tokens[4]),
                    Y = int.Parse(tokens[5])    
                };
                Poiont downRight = new Poiont()
                {
                    X = int.Parse(tokens[6]),
                    Y = int.Parse(tokens[7])    
                };

                Box newBox = new Box()
                {
                    UpLeft = upLeft,
                    UpRight = upRight,
                    DownLeft = downLeft,
                    DownRight = downRight
                };
                boxes.Add(newBox);

                input = Console.ReadLine();
            }
            foreach (var box in boxes)
            {
                int width = Poiont.CalculateDistance(box.UpLeft, box.UpRight);
                int height = Poiont.CalculateDistance(box.UpLeft, box.DownLeft);
                int perimeter = Box.CalculatePerimeter(width, height);
                int area = Box.CalculateArea(width, height);

                Console.WriteLine($"Box: {width}, {height}");
                Console.WriteLine($"Perimeter: {perimeter}");
                Console.WriteLine($"Area: {area}");
            }
        }
    }
    public class Poiont
    {
        public int X { get; set; }
        public int Y { get; set; }

        public static int CalculateDistance(Poiont one, Poiont two)
        {
            double sideA = Math.Pow((one.X - two.X), 2);
            double sideB = Math.Pow((one.Y - two.Y), 2);

            int distance = (int)Math.Sqrt(sideA + sideB);

            return distance;
        }
    }
    public class Box
    {
        public Poiont UpLeft { get; set; }
        public Poiont UpRight { get; set; }
        public Poiont DownLeft { get; set; }
        public Poiont DownRight { get; set; }

        public static int CalculatePerimeter(int width, int height)
        {
            var perimeter = (2 * width + 2 * height);
            return perimeter;
        }
        public static int CalculateArea(int width, int height)
        {
            var area = (width * height);
            return area;
        }
    }
}
