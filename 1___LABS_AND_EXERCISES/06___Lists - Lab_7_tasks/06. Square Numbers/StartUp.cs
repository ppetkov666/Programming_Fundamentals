namespace _06.Square_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            var result = new List<double>();
            for (int i = 0; i < inputLine.Count; i++)
            {
                double number = inputLine[i];
                double root = Math.Sqrt(number);
                double rootcheckasint = (int)(root);
                if (root==rootcheckasint)
                {
                    result.Add(number);
                }
            }
            result.Sort();
            for (int i = result.Count-1; i >=0 ; i--)
            {
                if (i == 0)
                {
                    Console.Write(result[i]);
                }
                else
                {
                    Console.Write(result[i] + " ");
                }
                
            }
            Console.WriteLine();
        }
    }
}
