namespace _07.Multiply_big_number
{
    using System;
    using System.Text;
    class StartUp
    {
        static void Main(string[] args)
        {
            var firstnum = Console.ReadLine();
            var secondnum = Console.ReadLine();
            if (firstnum == "0" || secondnum == "0")
            {
                Console.WriteLine(0);
                return;
            }
            if (firstnum.Length < secondnum.Length)
            {
                var temp = firstnum;
                firstnum = secondnum;
                secondnum = temp;
            }
            var lastdigit = 0;
            var restOfTheNum = 0;
            var nummultyply = 0;
            StringBuilder sum = new StringBuilder();
            for (int i = firstnum.Length - 1; i >= 0; i--)
            {
                nummultyply = int.Parse(firstnum[i].ToString())
                            * int.Parse(secondnum.ToString())
                            + restOfTheNum;
                lastdigit = nummultyply % 10;
                restOfTheNum = nummultyply / 10;
                sum.Insert(0, lastdigit);
                if (i == 0 & restOfTheNum != 0)
                {
                    sum.Insert(0, restOfTheNum);
                }
            }
            Console.WriteLine(sum);
        }
    }
}
