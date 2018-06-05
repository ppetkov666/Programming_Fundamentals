namespace _17._Print_Part_Of_ASCII_Table
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int numberA = int.Parse(Console.ReadLine());
            int numberB = int.Parse(Console.ReadLine());

            for (int i = numberA; i <= numberB; i++)
            {
                Console.Write((char)i + " ");
            }
            Console.WriteLine();
        }
    }
}
