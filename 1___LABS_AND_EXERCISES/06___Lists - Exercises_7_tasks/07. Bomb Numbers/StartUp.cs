namespace _07.Bomb_Numbers
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();
            var bombs = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var bomb = bombs[0];
            var power = bombs[1];
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] == bomb)
                {
                    var leftpart = Math.Max(i - power, 0);
                    var rightpart = Math.Min(i + power, input.Count-1);
                    var range = Math.Abs(leftpart - rightpart) + 1;
                    while (range > 0)
                    {
                        input.RemoveAt(leftpart);
                        range--;
                    }
                    i--;
                }
            }
            Console.WriteLine(input.Sum());
        }
    }
}
