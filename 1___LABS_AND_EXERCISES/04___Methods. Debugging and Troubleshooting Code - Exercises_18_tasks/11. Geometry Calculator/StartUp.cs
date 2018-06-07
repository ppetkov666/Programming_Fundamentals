namespace _11.Geometry_Calculator
{
    using System;
    class StartUp
    {
        static void Main()
        {
            string typeofthefigure = Console.ReadLine().ToLower();
            switch (typeofthefigure)
            {
                case "triangle":
                    PrintTriangleArea();
                    break;
                case "square":
                    PrintSquareArea();
                    break;
                case "rectangle":
                    PrintRectangleArea();
                    break;
                case "circle":
                    PrintCircleArea();
                    break;
            }
        }

        static void PrintTriangleArea()
        {
            double sidea = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = (sidea * height) / 2;
            Console.WriteLine("{0:f2}", area);
            
        }
        static void PrintSquareArea()
        {
            var a = double.Parse(Console.ReadLine());
            var area = Math.Pow(a, 2);
            Console.WriteLine("{0:f2}", area);
        }
        static void PrintRectangleArea()
        {
            double w = double.Parse(Console.ReadLine());
            double hRec = double.Parse(Console.ReadLine());
            var area =  w * hRec;
            Console.WriteLine("{0:f2}", area);
        }
        static void PrintCircleArea()
        {
            double r = double.Parse(Console.ReadLine());
            var area = Math.PI * Math.Pow(r, 2);
            Console.WriteLine("{0:f2}", area);
        }
    }
}
