namespace _03._Snowflake
{
    using System;
    using System.Text.RegularExpressions;

    class StartUp
    {
        static void Main(string[] args)
        {
            var surface = Console.ReadLine();
            var mantle = Console.ReadLine();
            var middle = Console.ReadLine();
            var mantleSecond = Console.ReadLine();
            var surfaceSecond = Console.ReadLine();

            string surfacePatt = @"^([\D\W]+)$";
            bool surfaceMatch = Regex.IsMatch(surface, surfacePatt);
            bool surfaceMatchSecond = Regex.IsMatch(surfaceSecond, surfacePatt);

            string mantlePat = @"([\d_]+)$";
            bool mantleMatch = Regex.IsMatch(mantle, mantlePat);
            bool mantleMatchSecond = Regex.IsMatch(mantleSecond, mantlePat);

            string corePat = @"^[\D\W]+([\d_])+([a-zA-ZА-Яа-я]+)([\d_]+)[\D\W]";
            bool coremach = Regex.IsMatch(middle, corePat);

            if (surfaceMatch && surfaceMatchSecond && mantleMatch && mantleMatchSecond && coremach) 
            {
                MatchCollection corematches = Regex.Matches(middle, corePat);

                string corePat2 = @"^[\D\W]+([\d_])+(?<core>[a-zA-ZА-Яа-я]+)"; 
                Match coremach2 = Regex.Match(middle, corePat2);

                Console.WriteLine("Valid");
                Console.WriteLine(coremach2.Groups["core"].Length);

            }
            else
            {
                Console.WriteLine("Invalid");
            }

        }
    }
}
