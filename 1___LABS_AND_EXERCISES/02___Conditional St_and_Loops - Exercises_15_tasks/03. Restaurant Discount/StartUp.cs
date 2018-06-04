namespace _03._Restaurant_Discount
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            double priceHall = 0;
            double pricePackage = 0;
            double discount = 0;
            string hall = string.Empty;
            if (groupSize <= 50)
            {
                priceHall = 2500;
                hall = "Small Hall";
            }
            else if (groupSize > 50 && groupSize <= 100)
            {
                priceHall = 5000;
                hall = "Terrace";
            }
            else if (groupSize > 100 && groupSize <= 120)
            {
                priceHall = 7500;
                hall = "Great Hall";
            }
            if (package == "Normal")
            {
                pricePackage = 500;
                discount = 0.05;
            }
            else if (package == "Gold")
            {
                pricePackage = 750;
                discount = 0.10;
            }
            else if (package == "Platinum")
            {
                pricePackage = 1000;
                discount = 0.15;
            }
            double sumprice = priceHall + pricePackage;
            double discountFull = sumprice * discount;
            double sumWithDiscount = sumprice - discountFull;
            double pricePerPerson = sumWithDiscount / groupSize;
            if (groupSize > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
            else
            {
                Console.WriteLine($"We can offer you the {hall}");
                Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
            }
        }
    }
}
