namespace _04._Variable_in_Hex_Format
{
    using System;
    class StartUp
    {
        static void Main()
        {
            string hexanumber = Console.ReadLine();
            Console.WriteLine(Convert.ToInt32(hexanumber, 16));
        }
    }
}
