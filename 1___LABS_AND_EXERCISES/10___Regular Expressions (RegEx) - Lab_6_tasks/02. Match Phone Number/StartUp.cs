namespace _02.Match_Phone_Number
{
    using System;
    using System.Text.RegularExpressions;
    class StartUp
    {
        static void Main()
        {
            var pattern = @"\+359\s2\s[0-9]{3}\s[0-9]{4}\b|\+359\-2\-[0-9]{3}\-[0-9]{4}\b";
            var phonenumbers = Console.ReadLine();
            var matched = Regex.Matches(phonenumbers, pattern);
            var count = 1;
            foreach (Match item in matched)
            {
                if (count.Equals(matched.Count))
                {
                    Console.Write(item);
                }
                else
                {
                    Console.Write(item + ", ");
                } 
                count++;
            }
            Console.WriteLine();
        }
    }
}
