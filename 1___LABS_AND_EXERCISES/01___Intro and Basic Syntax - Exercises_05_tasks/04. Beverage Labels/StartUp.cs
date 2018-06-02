namespace _04._Beverage_Labels
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            int energyKcal = int.Parse(Console.ReadLine());
            int sugarContent = int.Parse(Console.ReadLine());

            double pergram = (double)quantity / 100;

            double Kcal = energyKcal * pergram;
            double sugar = sugarContent * pergram;

            Console.WriteLine(quantity + "ml " + name + ':');
            Console.WriteLine($"{Kcal}kcal, {sugar}g sugars");
        }
    }
}
