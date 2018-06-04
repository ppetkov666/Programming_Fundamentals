namespace _11._5_Different_Numbers
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int min = Math.Min(a, b);
            int max = Math.Max(a, b);
            int difference = Math.Abs(a - b);
            if (difference >= 5)
            {
                for (int n1 = min; n1 <= max; n1++)
                {
                    for (int n2 = min; n2 <= max; n2++)
                    {
                        for (int n3 = min; n3 <= max; n3++)
                        {
                            for (int n4 = min; n4 <= max; n4++)
                            {
                                for (int n5 = min; n5 <= max; n5++)
                                {
                                    if (min <= n1 && n1 < n2 && n2 < n3 && n3 < n4 && n4 < n5 && n5 <= max)
                                    {
                                        Console.WriteLine($"{n1} {n2} {n3} {n4} {n5}");
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
