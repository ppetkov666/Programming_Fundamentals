namespace _01._Blank_Receipt
{
    using System;
    class StartUp
    {
        static void Main()
        {
            PrintReceipt();
        }
        private static void PrintReceipt()
        {
            PrintHeather();
            PrintBody();
            PrintFooter();

        }
        private static void PrintHeather()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");

        }
        private static void PrintBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");

        }
        private static void PrintFooter()
        {
            Console.WriteLine("------------------------------");
            Console.Write("\u00A9");
            Console.WriteLine(" SoftUni");
        }
    }
}
