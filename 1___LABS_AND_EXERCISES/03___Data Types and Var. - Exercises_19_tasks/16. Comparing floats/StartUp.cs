namespace _16._Comparing_floats
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double numberA = double.Parse(Console.ReadLine());
            double numberB = double.Parse(Console.ReadLine());

            bool istrue = true;
            double epsilon = 0.000001;
            double difference = Math.Abs(numberA - numberB);

            if (difference >= epsilon)
            {
                istrue = false;
            }
            Console.WriteLine(istrue);
        }
    }
}
