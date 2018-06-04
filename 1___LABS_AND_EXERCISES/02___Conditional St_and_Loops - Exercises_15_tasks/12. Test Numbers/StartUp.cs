namespace _12._Test_Numbers
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());

            int counter = 0;
            int sum = 0;
            for (int a = n; a >= 1; a--)
            {
                for (int b = 1; b <= m; b++)
                {
                    counter++;
                    sum += (a * b) * 3;
                    if (sum >= x)
                    {
                        Console.WriteLine(counter + " combinations");
                        Console.WriteLine($"Sum: {sum} >= {x}");
                        return;
                    }
                }
            }
            Console.WriteLine(counter + " combinations");
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
