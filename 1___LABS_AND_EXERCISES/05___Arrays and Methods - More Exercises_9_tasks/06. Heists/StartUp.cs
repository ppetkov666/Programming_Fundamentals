namespace _06.Heists
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main(string[] args)
        {
            var prices = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
           
            var jewelsPrice = prices[0];
            var goldPrice = prices[1];

            long jewelssum = 0;
            long goldsum = 0;
            long expensesSum = 0;
            
            string command = Console.ReadLine();
            while (command != "Jail Time")
            {
                var lootHeistAndExp = command.Split(' ').ToArray();
                var lootheist = lootHeistAndExp[0];
                var expenses = int.Parse(lootHeistAndExp[1]);
                for (int i = 0; i < lootheist.Length; i++)
                {
                    if (lootheist[i] == '%')
                    {
                        jewelssum += jewelsPrice;
                    }
                    else if (lootheist[i] == '$')
                    {
                        goldsum += goldPrice;
                    }
                }
                expensesSum += expenses;
                 command = Console.ReadLine();
            }
            long total = jewelssum + goldsum - expensesSum;
            Console.WriteLine(total >= 0 ?
                $"Heists will continue. Total earnings: {total}.":
                $"Have to find another job. Lost: {Math.Abs(total)}.");
        }
    }
}
