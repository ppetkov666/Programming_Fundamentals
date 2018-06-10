namespace _09.Index_of_Letters
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            string letters = Console.ReadLine();
            for (int i = 0; i < letters.Length; i++)
            {
                Console.WriteLine(string.Format("{0} -> {1}", letters[i], letters[i] - 'a'));
            }
        }
    }
}
