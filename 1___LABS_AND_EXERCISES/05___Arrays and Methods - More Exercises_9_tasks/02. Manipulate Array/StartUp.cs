namespace _02.Manipulate_Array
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split(' ').ToArray();
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var command = Console.ReadLine().Split(' ').ToArray();
                if (command[0] == "Distinct")
                {
                    array = array.Distinct().ToArray();

                }
                else if (command[0] == "Reverse")
                {
                    array = array.Reverse().ToArray();
                }
                else if (command[0] == "Replace")
                {
                    array[int.Parse(command[1])] = command[2];
                }
            }
            Console.WriteLine(string.Join(", ", array));
        }
    }
}
