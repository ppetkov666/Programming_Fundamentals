namespace _07._Exchange_Variable_Values
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int a = 5;
            int b = 10;
            Console.WriteLine($"Before: \na = {a} \nb = {b}");
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"After: \na = {a} \nb = {b}");
        }
    }
}
