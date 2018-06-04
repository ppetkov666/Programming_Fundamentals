namespace _13._Game_of_Numbers
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int f = int.Parse(Console.ReadLine());
            int max = Math.Max(n, m);
            int min = Math.Min(n, m);

            int counter = 0;
            int counter2 = 0;
            int first = 0;
            int second = 0;
            for (int i = min; i <= max; i++)
            {
                for (int j = min; j <= max; j++)
                {
                    counter++;
                    if (i + j == f)
                    {
                        counter2++;
                        first = i;
                        second = j;
                    }
                }
            }
            if (counter2 == 0)
            {
                Console.WriteLine($"{counter} combinations - neither equals {f}");
            }

            else
            {
                Console.WriteLine($"Number found! {first} + {second} = {f}");
            }
        }
    }
}
