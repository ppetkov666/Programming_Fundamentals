namespace _05.Sort_Numbers
{
    using System;  
    using System.Linq;
    class StartUp
    {
        static void Main(string[] args)
        {
            var listinput = Console.ReadLine().Split().Select(decimal.Parse).ToList();
            listinput.Sort();
            for (int i = 0; i < listinput.Count; i++)
            {
                Console.Write(listinput[i]);
                bool istrue = i == listinput.Count - 1;
                if (! istrue)
                {
                    Console.Write(" <= ");
                }
            }
            Console.WriteLine();
        }
    }
}
