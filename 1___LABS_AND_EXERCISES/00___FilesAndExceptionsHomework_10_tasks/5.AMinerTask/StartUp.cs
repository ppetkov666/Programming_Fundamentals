namespace _5.AMinerTask
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    class StartUp
    {
        static void Main(string[] args)
        {
            var resoursedataandquantity = new Dictionary<string, decimal>();
            var inputresourse = File.ReadAllLines("../../input.txt");
            File.Delete("../../output.txt");
            for (int i = 0; i < inputresourse.Length; i+=2)
            {
                while (inputresourse[i] != "stop")
                {
                    var valueresourse = inputresourse[i];
                    var quantity = inputresourse[i+1];
                    if (!resoursedataandquantity.ContainsKey(valueresourse))
                    {
                        resoursedataandquantity[valueresourse] = 0;
                    }
                    resoursedataandquantity[valueresourse] += int.Parse(inputresourse[i+1]);                  
                    break;
                }              
            }
            foreach (var item in resoursedataandquantity)
            {
                var output = string.Join(" -> ", item.Key, item.Value);
                File.AppendAllText("../../output.txt", output);
                File.AppendAllText("../../output.txt", Environment.NewLine);

            }
        }
    }
}
