namespace _02.Max_Method
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            var initialtwonumbers = Getmax(num1, num2);
            Getmax(initialtwonumbers, num3);
            Console.WriteLine(Getmax(Getmax(num1, num2), num3));
        }
        private static int Getmax(int num1, int num2)
        {
            if (num1 < num2)
            {
                return num2;
            }
            else
            {
                return num1;
            }
        }
    }
}
