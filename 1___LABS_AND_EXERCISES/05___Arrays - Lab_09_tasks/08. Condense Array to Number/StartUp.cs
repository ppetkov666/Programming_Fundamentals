namespace _08._Condense_Array_to_Number
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main(string[] args)
        {
            var arrray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var condensed = new int[arrray.Length - 1];
            if (arrray.Length == 1)
            {
                Console.WriteLine(arrray[0]);
            }
            else
            {
                while (arrray.Length > 1)
                {
                    condensed = new int[arrray.Length - 1];
                    for (int i = 0; i < arrray.Length - 1; i++)
                    {
                        condensed[i] = arrray[i] + arrray[i + 1];

                    }
                    arrray = condensed;

                }
                Console.WriteLine(string.Join("", condensed));
            }
        }
    }
}
