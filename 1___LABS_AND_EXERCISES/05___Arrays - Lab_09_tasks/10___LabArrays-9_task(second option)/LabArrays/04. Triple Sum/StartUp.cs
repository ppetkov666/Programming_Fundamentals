namespace _04.Triple_Sum
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] splitedInput = input.Split();
            var arrayInput = new int[splitedInput.Length];
            for (int i = 0; i < splitedInput.Length; i++)
            {
                arrayInput[i] = int.Parse(splitedInput[i]);
            }
            
            var counter = 0;
            for (int i = 0; i < arrayInput.Length; i++)
            {
                for (int a = i + 1; a < arrayInput.Length; a++)
                {
                    var result = arrayInput[i] + arrayInput[a];
                    if (arrayInput.Contains(result))
                    {
                        Console.WriteLine($"{arrayInput[i]} + {arrayInput[a]} == {result}");
                        counter++;
                    }
                }

            }
            if (counter == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
