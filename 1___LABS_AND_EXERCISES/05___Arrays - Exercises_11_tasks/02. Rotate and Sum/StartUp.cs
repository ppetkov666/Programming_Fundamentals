namespace _02.Rotate_and_Sum
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var inputsplitted = input.Split(' ');
            var inputINT = new int[inputsplitted.Length];
            for (int i = 0; i < inputINT.Length; i++)
            {
                inputINT[i] = int.Parse(inputsplitted[i]);        
            }
            var rotator = int.Parse(Console.ReadLine());
            var sumArray = new int[inputINT.Length];
            for (int i = 0; i < rotator; i++)
            {
                var firstelement = inputINT[inputINT.Length - 1];
                for (int a = inputINT.Length - 1; a >= 1; a--)
                {
                    
                    inputINT[a] = inputINT[a - 1];
                    
                }
                inputINT[0] = firstelement;
                for (int b = 0; b < sumArray.Length; b++)
                {
                    sumArray[b] += inputINT[b];
                }
            }
            Console.WriteLine(string.Join(" ",sumArray));   
        }
    }
}
