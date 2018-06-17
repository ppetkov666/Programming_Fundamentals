namespace _06.Rectangle_Position
{
    using System;
    using System.Linq;
    public class Rectangle
    {
        public int Top { get; set; }
        public int Left { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Bottom
        {
            get
            {
                return Top - Height;
            }
        }
        public int Area => Width * Height;
        public int Right => Left + Width;
    }
    class StartUp
    {
        static void Main(string[] args)
        {
            var firstRectangle = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            var first = new Rectangle();
            first.Left = firstRectangle[0];
            first.Top = firstRectangle[1];
            first.Width = firstRectangle[2];
            first.Height = firstRectangle[3];
            var secondRectangle = Console.ReadLine().Split(' ')
                .Select(int.Parse)
                .ToArray();
            var second = new Rectangle();
            second.Left = secondRectangle[0];
            second.Top = secondRectangle[1];
            second.Width = secondRectangle[2];
            second.Height = secondRectangle[3];
            var result = FirstInsideSecond(first,second);
            if (result==true) Console.WriteLine("Inside");
            else Console.WriteLine("Not inside");
        }
        public static bool FirstInsideSecond(Rectangle first, Rectangle second)
        {
            var leftisInside = first.Left >= second.Left;
            var rightidInside = first.Right <= second.Right;
            var topisInside = first.Top <= second.Top;
            var bottomisInside = first.Bottom >= second.Bottom;
            return leftisInside && rightidInside && topisInside && bottomisInside;
        }
    }   
}
