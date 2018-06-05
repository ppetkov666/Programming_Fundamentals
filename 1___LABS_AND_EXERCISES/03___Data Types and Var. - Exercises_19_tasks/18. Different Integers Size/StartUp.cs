namespace _18._Different_Integers_Size
{
    using System;
    class StartUp
    {
        static void Main()
        {
            string inputLine = Console.ReadLine();

            try
            {
                long number = long.Parse(inputLine);
                Console.WriteLine(number + " can fit in:");
                if (number >= sbyte.MinValue && number <= sbyte.MaxValue)
                {

                    Console.WriteLine("* sbyte");
                }
                if (number >= byte.MinValue && number <= byte.MaxValue)
                {

                    Console.WriteLine("* byte");
                }
                if (number >= short.MinValue && number <= short.MaxValue)
                {

                    Console.WriteLine("* short");
                }
                if (number >= ushort.MinValue && number <= ushort.MaxValue)
                {

                    Console.WriteLine("* ushort");
                }
                if (number >= int.MinValue && number <= int.MaxValue)
                {

                    Console.WriteLine("* int");
                }
                if (number >= uint.MinValue && number <= uint.MaxValue)
                {

                    Console.WriteLine("* uint");
                }
                if (number >= long.MinValue)
                {
                    Console.WriteLine("* long");
                }
            }
            catch (Exception)
            {
                Console.WriteLine(inputLine + " can't fit in any type");

            }
        }
    }
}
