namespace _12.Master_Number
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i < number; i++)
            {
                if (ISpalindrome(i) == true && SumOfDigits(i)==true && ContainsEvenDigits(i)==true)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static bool ContainsEvenDigits(int num)
        {
            var contain = false;
            var number = num.ToString();
            for (int i = 0; i < number.Length; i++)
            {
                var numforcheck = int.Parse(number[i].ToString());
                if (numforcheck % 2 == 0)
                {
                    contain = true;
                    break;
                }
            }
            return contain;
        }
        static bool SumOfDigits(int num)
        {
            var sum = 0;
            var number = num.ToString();
            var sumofdigit = false;
            for (int i = 0; i < number.Length; i++)
            {
                sum += int.Parse(number[i].ToString());
            }
            if (sum % 7 == 0)
            {
                sumofdigit = true;
            }
            return sumofdigit;
        }
        static bool ISpalindrome(int num)
        {
            var ispalindrome = false;
            string number = num.ToString();
            int count = 0;
            for (int i = 0; i < number.Length / 2; i++)
            {
                if (number[i] == number[number.Length-1-i])
                {
                    count++;
                }     
            }
            if (count == number.Length/2)
            {
                ispalindrome = true;
            }
            return ispalindrome;
        }
    }
}
