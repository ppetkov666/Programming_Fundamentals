namespace _10._Multiplication_Table_2._0
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            for (int i = m; i <= 10; i++)
            {
                Console.WriteLine(n + " X " + i + " = " + n * i);
            }
            if (m > 10)
            {
                Console.WriteLine(n + " X " + m + " = " + n * m);
            }
        }
    }
}
