namespace _02.Count_Substring_Occurrences
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            var inputstring = Console.ReadLine().ToLower();
            var searchedstring = Console.ReadLine().ToLower();
            int counter = 0;
            var founded = inputstring.IndexOf(searchedstring);
            while (founded != -1)
            {
                counter++;
                founded = inputstring.IndexOf(searchedstring,founded+1);
            }
            Console.WriteLine(counter);
        }
    }
}
