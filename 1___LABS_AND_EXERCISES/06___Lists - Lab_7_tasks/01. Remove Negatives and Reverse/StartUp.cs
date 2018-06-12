namespace _01.Remove_Negatives_and_Reverse
{
    using System;
    using System.Collections.Generic;
    class StartUp
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            var line = input.Split(' ');
            var lineList = new List<int>();
            for (int i = 0; i < line.Length; i++)
            {
                lineList.Add(int.Parse(line[i]));
            }
            var changedList = new List<int>();
            for (int i = 0; i < lineList.Count; i++)
            {
                if (lineList[i] >= 0)
                {
                    changedList.Add(lineList[i]);
                }
            }
            if (changedList.Count==0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                for (int i = changedList.Count-1; i >=0; i--)
                {

                    Console.Write(changedList[i]);
                    bool istrue = i == 0;
                    if (! istrue)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();            
            }
        }
    }
}
