namespace _06_Rectangle_Position
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
            int[] firstRectData = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secondRectData = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Rectangle firstRect = new Rectangle
            {
                Left = firstRectData[0],
                Top = firstRectData[1],
                Width = firstRectData[2],
                Height = firstRectData[3]
            };
            Rectangle secondRect = new Rectangle
            {
                Left = secondRectData[0],
                Top = secondRectData[1],
                Width = secondRectData[2],
                Height = secondRectData[3]
            };

            if (firstRect.IsInside(secondRect))
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }
        }

        class Rectangle
        {
            public int Top { get; set; }
            public int Left { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }

            public int Bottom
            {
                get
                {
                    return Top + Height;
                }
            }
            public int Right
            {
                get
                {
                    return Left + Width;
                }
            }

            int CalcArea()
            {
                return Width * Height;
            }
            public bool IsInside (Rectangle other)
            {
                return Top >= other.Top && Left >= other.Left
                              && Bottom <= other.Bottom && Right <= other.Right;
            }
        }
    }
}
