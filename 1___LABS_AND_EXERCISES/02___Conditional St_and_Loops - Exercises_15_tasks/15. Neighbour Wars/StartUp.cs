namespace _15._Neighbour_Wars
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int peterHit = int.Parse(Console.ReadLine());
            int georgeHit = int.Parse(Console.ReadLine());

            int peterHealth = 100;
            int georgeHealh = 100;
            string peter = "Pesho";
            string george = "Gosho";
            int round = 1;
            while (true)
            {
                if (round % 2 != 0)
                {
                    georgeHealh = georgeHealh - peterHit;
                    if (georgeHealh <= 0)
                    {
                        Console.WriteLine($"{peter} won in {round}th round.");
                        return;
                    }
                    else
                    {
                        Console.WriteLine($"{peter} used Roundhouse kick and reduced {george} " +
                                          $"to {georgeHealh} health.");
                    }
                }
                if (round % 2 == 0)
                {
                    peterHealth = peterHealth - georgeHit;
                    if (peterHealth <= 0)
                    {
                        Console.WriteLine($"{george} won in {round}th round.");
                        return;
                    }
                    else
                    {
                        Console.WriteLine($"{george} used Thunderous fist and reduced {peter}" +
                                          $" to {peterHealth} health.");
                    }
                }
                if (round % 3 == 0)
                {
                    georgeHealh += 10;
                    peterHealth += 10;
                }
                round++;
            }
        }
    }
}
