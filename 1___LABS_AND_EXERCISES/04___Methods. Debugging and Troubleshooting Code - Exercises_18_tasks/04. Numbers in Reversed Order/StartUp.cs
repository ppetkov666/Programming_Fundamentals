namespace _04.Numbers_in_Reversed_Order
{
    using System;
    using System.Text;

    class StartUp
    {
        static void Main()
        {
            string number = Console.ReadLine();
            var reversedNumber = GetReverseNum(number);
            Console.WriteLine(reversedNumber);
        }
        static StringBuilder GetReverseNum(string num)
        {
            StringBuilder reversed = new StringBuilder();
            for (int i = num.Length-1; i >= 0; i--)
            {
                reversed.Append(num[i]);
            }
            return reversed;
        }
    }
}
