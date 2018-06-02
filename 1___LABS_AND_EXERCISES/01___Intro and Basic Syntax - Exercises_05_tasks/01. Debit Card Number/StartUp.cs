namespace _01._Debit_Card_Number
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int firstint = int.Parse(Console.ReadLine());
            int secondint = int.Parse(Console.ReadLine());
            int thirdint = int.Parse(Console.ReadLine());
            int forthint = int.Parse(Console.ReadLine());

            Console.WriteLine($"{firstint:d4} {secondint:d4} {thirdint:d4} {forthint:d4}");
        }
    }
}
