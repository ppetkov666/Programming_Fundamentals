namespace _10.Cube_Properties
{
    using System;
    class StartUp
    {
        static void Main()
        { 
            double inputside = double.Parse(Console.ReadLine());
            string cubeproperties = Console.ReadLine();

            CubeProperties(inputside, cubeproperties);
        }

        private static void CubeProperties(double inputside, string cubeproperties)
        {
            if (cubeproperties == "face")
            {
                double facediagonals = (inputside * Math.Sqrt(2));
                Console.WriteLine($"{facediagonals:f2}");

            }
            if (cubeproperties == "space")
            {
                double spacediagonals = (inputside * Math.Sqrt(3));
                Console.WriteLine($"{spacediagonals:f2}");
            }
            if (cubeproperties == "volume")
            {
                double volume = (Math.Pow(inputside, 3));
                Console.WriteLine($"{volume:f2}");
            }
            if (cubeproperties == "area")
            {
                double area = (inputside * inputside) * 6;
                Console.WriteLine($"{area:f2}");
            }

        }
    }
}
