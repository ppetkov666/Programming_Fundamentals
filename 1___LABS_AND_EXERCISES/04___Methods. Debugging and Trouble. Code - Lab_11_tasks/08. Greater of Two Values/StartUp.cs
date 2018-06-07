namespace _08._Greater_of_Two_Values
{
    using System;
    class StartUp
    {
        static void Main()
        {
            var inputType = Console.ReadLine();
            GetMaxNumber(inputType);
            
        }
        private static void GetMaxNumber(string inputType)
        {
            if (inputType == "int")
            {
                var numfirst = int.Parse(Console.ReadLine());
                var numsecond = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(numfirst, numsecond));

            }
            else if (inputType == "char")
            {
                var charfirst = char.Parse(Console.ReadLine());
                var charsecond = char.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(charfirst, charsecond));
            }
            if (inputType == "string")
            {
                var stringfirst = Console.ReadLine();
                var stringsecond = Console.ReadLine();
                Console.WriteLine(GetMax(stringfirst, stringsecond));
            }
        }

        static int GetMax(int numfirst, int numsecond)
        {
            if (numfirst < numsecond)
            {
                return numsecond;
            }
            else
            {
                return numfirst;
            }
        }
        static char GetMax(char first, char second)
        {
            if (first < second)
            {
                return second;
            }
            else
            {
                return first;
            }
        }
        static string GetMax(string first, string second)
        {
            var comparedstring = first.CompareTo(second);
            if (comparedstring < 0)
            {
                return second;
            }
            else
            {
                return first;
            }

        }
    }
}
