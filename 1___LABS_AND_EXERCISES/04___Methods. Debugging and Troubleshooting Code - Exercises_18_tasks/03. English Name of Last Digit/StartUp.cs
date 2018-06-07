namespace _03.English_Name_of_Last_Digit
{
    using System;
    using System.Text;

    class StartUp
    {
        static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            string name = GetNameOfLastDigit(number).ToString();
            Console.WriteLine(name);
        }
        static StringBuilder GetNameOfLastDigit(long number)
        {
            StringBuilder result = new StringBuilder();
            long lastdigit = number % 10;
            lastdigit = Math.Abs(lastdigit);
            if (lastdigit == 0) result.Append("zero");
            else if (lastdigit == 1) result.Append("one");
            else if (lastdigit == 2) result.Append("two");
            else if (lastdigit == 3) result.Append("three");
            else if (lastdigit == 4) result.Append("four");
            else if (lastdigit == 5) result.Append("five");
            else if (lastdigit == 6) result.Append("six");
            else if (lastdigit == 7) result.Append("seven");
            else if (lastdigit == 8) result.Append("eight");
            else if (lastdigit == 9) result.Append("nine");
            
            return result;
        }
    }
}
