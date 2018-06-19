namespace _02.Convert_from_base_N_to_base_10
{
    using System;
    using System.Linq;
    using System.Numerics;
    class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToArray();
            var num =BigInteger.Parse( input[0]);
            var number = input[1];
            BigInteger result = 0;
            int poww = number.Length - 1;
            for (int i = 0; i < number.Length; i++)
            {
                var digit = BigInteger.Parse(number[i].ToString());
                result += BigInteger.Multiply(digit, BigInteger.Pow(num, poww));
                poww--;
            }
            Console.WriteLine(result);

        }
    }
}
