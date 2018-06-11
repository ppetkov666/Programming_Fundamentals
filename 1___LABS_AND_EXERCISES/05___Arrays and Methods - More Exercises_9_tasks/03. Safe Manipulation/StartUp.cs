namespace _03.Safe_Manipulation
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split(' ').ToArray();
            
            var command = Console.ReadLine().Split(' ').ToArray();
            while ( command[0] != "END")
            {
                
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
                    if (int.Parse(command[1]) < 0 || int.Parse(command[1]) > array.Length - 1)
                    {
                        Console.WriteLine("Invalid input!");
                    }
                    else
                    {
                        array[int.Parse(command[1])] = command[2];
                    }      
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
                command = Console.ReadLine().Split(' ').ToArray();
            }
            Console.WriteLine(string.Join(", ", array));
        }
    }
}
