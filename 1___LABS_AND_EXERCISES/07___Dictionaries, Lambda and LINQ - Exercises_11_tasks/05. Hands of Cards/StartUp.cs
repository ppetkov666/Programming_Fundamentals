namespace _05.Hands_of_Cards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main(string[] args)
        {
            var outputDict = new Dictionary<string, HashSet<string>>();
            var command = Console.ReadLine().Split(':').ToList();
            while (command[0] != "JOKER")
            {
                var playerName = command[0];
                var playerCards = command[1]
                    .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                if (!outputDict.ContainsKey(playerName))
                {
                    outputDict[playerName] =  new HashSet<string>();
                }
                foreach (var card in playerCards)
                {
                    outputDict[playerName].Add(card);   
                }        
                command = Console.ReadLine().Split(':').ToList();
            }
            foreach (var item in outputDict)
            {
                var player = item.Key;
                var result = 0;
                foreach (var card in item.Value)
                {
                    var type = 0;
                    var multiplier = 0;
                    
                    var firstSymboloftheCard = card.Remove(card.Length - 1, 1);
                    if (firstSymboloftheCard == "2") type = 2;
                    else if (firstSymboloftheCard == "3") type = 3;
                    else if (firstSymboloftheCard == "4") type = 4;
                    else if (firstSymboloftheCard == "5") type = 5;
                    else if (firstSymboloftheCard == "6") type = 6;
                    else if (firstSymboloftheCard == "7") type = 7;
                    else if (firstSymboloftheCard == "8") type = 8;
                    else if (firstSymboloftheCard == "9") type = 9;
                    else if (firstSymboloftheCard == "10") type = 10;
                    else if (firstSymboloftheCard == "J") type = 11;
                    else if (firstSymboloftheCard == "Q") type = 12;
                    else if (firstSymboloftheCard == "K") type = 13;
                    else if (firstSymboloftheCard == "A") type = 14;

                    var secondSymbolofTheCard = card[card.Length - 1];
                    if (secondSymbolofTheCard == 'S') multiplier = 4;
                    else if (secondSymbolofTheCard == 'H') multiplier = 3;
                    else if (secondSymbolofTheCard == 'D') multiplier = 2;
                    else if (secondSymbolofTheCard == 'C') multiplier = 1;

                    result += type * multiplier;
                }
                Console.WriteLine($"{player}: {result}");  
            }
        }
    }
}
