namespace _05._Special_Numbers
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int num = 1; num <= n; num++)
            {
                int sumofdigits = 0;
                int currentnum = num;
                while (currentnum > 0)
                {
                    sumofdigits += currentnum % 10;
                    currentnum = currentnum / 10;
                }
                bool isspecial = (sumofdigits == 5 || sumofdigits == 7 || sumofdigits == 11);
                Console.WriteLine($"{num}->{isspecial}");
            }
        }
    }
}
