namespace _09._Refactor_Special_Numbers
{
    using System;
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int num = 1; num <= n; num++)
            {
                int sumofdigit = 0;
                int currentnumber = num;
                while (currentnumber > 0)
                {
                    sumofdigit += currentnumber % 10;
                    currentnumber = currentnumber / 10;
                }
                bool special = (sumofdigit == 5 || sumofdigit == 7 || sumofdigit == 11);
                Console.WriteLine($"{num} -> {special}");
            }
        }
    }
}
