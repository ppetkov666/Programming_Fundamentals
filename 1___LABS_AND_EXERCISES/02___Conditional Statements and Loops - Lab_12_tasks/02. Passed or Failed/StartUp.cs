namespace _02._Passed_or_Failed
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double grade = double.Parse(Console.ReadLine());

            if (grade >= 3)
            {
                Console.WriteLine("Passed!");
            }
            else if (grade < 3)
            {
                Console.WriteLine("Failed!");
            }
        }
    }
}
