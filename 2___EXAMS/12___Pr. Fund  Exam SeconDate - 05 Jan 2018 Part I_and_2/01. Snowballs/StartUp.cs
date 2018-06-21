namespace _01.Snowballs
{
    using System;
    using System.Numerics;
    class StartUp
    {
        static void Main(string[] args)
        {
            var numOfsnowballs = int.Parse(Console.ReadLine());
            var arrayStorage = new double[3];
            BigInteger minvalue = 0;
            BigInteger result = 0;
            for (int i = 0; i < numOfsnowballs; i++)
            {
                var snowballSnow = int.Parse(Console.ReadLine());
                var snowballTime = int.Parse(Console.ReadLine());
                var snowballQuality = int.Parse(Console.ReadLine());
                result = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);

                if (result > minvalue)
                {
                    minvalue = result;
                    arrayStorage[0] = snowballSnow;
                    arrayStorage[1] = snowballTime;
                    arrayStorage[2] = snowballQuality;
                }

            }
            Console.WriteLine($"{arrayStorage[0]} : {arrayStorage[1]} = {minvalue} ({arrayStorage[2]})");
        }
    }
}
