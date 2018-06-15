namespace _04.Fix_Emails
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main(string[] args)
        {
            var outputDict = new Dictionary<string, string>();
            var inputName = Console.ReadLine();
            while (inputName != "stop")
            {
                var email = Console.ReadLine();
                outputDict[inputName] = email;
                inputName = Console.ReadLine();
            }
            var fixedDictionary = outputDict
                .Where(email => !email.Value.ToLower().EndsWith("us"))
                .Where(email => !email.Value.ToLower().EndsWith("uk"));        
            foreach (var item in fixedDictionary)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
