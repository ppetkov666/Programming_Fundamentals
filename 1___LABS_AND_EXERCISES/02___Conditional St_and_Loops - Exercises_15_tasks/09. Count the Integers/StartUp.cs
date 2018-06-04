namespace _09._Count_the_Integers
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int temp;
            int counter = 0;

            for (int i = 0; i < 100; i++)
            {
                string n = Console.ReadLine();
                if (int.TryParse(n, out temp))
                {
                    counter++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
