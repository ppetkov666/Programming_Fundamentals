namespace _06._Reverse_Array_of_Strings
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputsplit = input.Split(' ');
            for (int i = 0; i < inputsplit.Length / 2; i++)
            {
                string a = inputsplit[i];
                inputsplit[i] = inputsplit[inputsplit.Length - 1 - i];
                inputsplit[inputsplit.Length - 1 - i] = a;
            }
            Console.WriteLine(string.Join(" ", inputsplit));
        }
    }
}
