namespace _06._Strings_And_Objects
{
    using System;
    class StartUp
    {
        static void Main()
        {
            string firstname = Console.ReadLine();
            string lasLine = Console.ReadLine();
            object firstandlastname = firstname + " " + lasLine;
            string result = (string)firstandlastname;
            Console.WriteLine(result);
        }
    }
}
