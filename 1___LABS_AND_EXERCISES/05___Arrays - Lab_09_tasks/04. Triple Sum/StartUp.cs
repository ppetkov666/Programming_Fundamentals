namespace _04._Triple_Sum
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            string value = Console.ReadLine();
            string[] item = value.Split(' ');
            int[] arr = new int[item.Length];
            for (int i = 0; i < item.Length; i++)
            {
                arr[i] = int.Parse(item[i]);
            }
            int sum = 0;
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {

                    sum = arr[i] + arr[j];
                    if (arr.Contains(sum))
                    {
                        Console.WriteLine(arr[i] + " + " + arr[j] + " == " + sum);
                        counter += 1;
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
