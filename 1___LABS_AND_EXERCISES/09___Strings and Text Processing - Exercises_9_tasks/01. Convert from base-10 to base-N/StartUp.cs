namespace _01.Convert_from_base_10_to_base_N
{
    using System;
    using System.Linq;
    using System.Numerics;
    using System.Text;
    class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToArray();
            var baseN = int.Parse(input[0]);
            var numberBase10 = BigInteger.Parse(input[1]);
            BigInteger result = 0;
            StringBuilder outputresult = new StringBuilder();
            while (numberBase10 > 0)
            {
                result = numberBase10 % baseN;
                outputresult.Insert(0,result);
                numberBase10 = numberBase10 / baseN;
            }
            Console.WriteLine(outputresult);
        }
    }
}
