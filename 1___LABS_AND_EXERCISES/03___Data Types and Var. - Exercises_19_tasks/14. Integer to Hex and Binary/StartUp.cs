namespace _14._Integer_to_Hex_and_Binary
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            string bynary = Convert.ToString(number, 2);
            string hexadecimal = Convert.ToString(number, 16).ToUpper();
            Console.WriteLine(hexadecimal);
            Console.WriteLine(bynary);
        }
    }
}
