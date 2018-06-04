namespace _08._Calories_Counter
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int counter = 0;
            for (int i = 1; i <= n; i++)
            {
                string ingridient = Console.ReadLine().ToLower();
                if (ingridient == "cheese") counter += 500;
                else if (ingridient == "tomato sauce") counter += 150;
                else if (ingridient == "salami") counter += 600;
                else if (ingridient == "pepper") counter += 50;
            }
            Console.WriteLine($"Total calories: {counter}");
        }
    }
}
