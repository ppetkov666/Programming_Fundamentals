namespace _05._Boolean_Variable
{
    using System;
    class StartUp
    {
        static void Main()
        {
            bool istrue = bool.Parse(Console.ReadLine());
            if (istrue)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
