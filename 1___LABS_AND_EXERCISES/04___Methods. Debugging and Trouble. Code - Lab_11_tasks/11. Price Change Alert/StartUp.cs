namespace _11._Price_Change_Alert
{
    using System;
    using System.Text;

    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double treshhold = double.Parse(Console.ReadLine()) * 100;
            double initialNum = double.Parse(Console.ReadLine());
            for (int i = 0; i < n - 1; i++)
            {
                double nextNum = double.Parse(Console.ReadLine());

                var percentageDifference = GetPercentageDifference(initialNum, nextNum);
                bool isSignificant = CheckTheDifference(percentageDifference, treshhold);
                var printtheresult = GetResult(percentageDifference, initialNum, nextNum, isSignificant);
                Console.WriteLine(printtheresult);
                initialNum = nextNum;
            }
        }

        static StringBuilder GetResult(double percentageDiff, double initialNum, double nextNum, bool isSignificant)
        {
            StringBuilder finalOutput = new StringBuilder();
            if (percentageDiff == 0)
            {
                finalOutput = finalOutput.AppendFormat($"NO CHANGE: {initialNum}");
                return finalOutput;
            }
            else if (!isSignificant)
            {
                finalOutput = finalOutput.AppendFormat($"MINOR CHANGE: {initialNum} to {nextNum} ({percentageDiff:f2}%)");
                return finalOutput;
            }
            else if (isSignificant && (percentageDiff > 0))
            {
                finalOutput = finalOutput.AppendFormat($"PRICE UP: {initialNum} to {nextNum} ({percentageDiff:f2}%)");
                return finalOutput;
            }
            else if (isSignificant && (percentageDiff < 0))
            {
                finalOutput = finalOutput.AppendFormat($"PRICE DOWN: {initialNum} to {nextNum} ({percentageDiff:f2}%)");
                return finalOutput;
            }
            else
            {
                return finalOutput;
            }
        }

        static bool CheckTheDifference(double percentageDifference, double treshhold)
        {
            if (Math.Abs(percentageDifference) >= treshhold)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static double GetPercentageDifference(double initialNum, double nextNum)
        {
            var difference = ((nextNum - initialNum) / initialNum) * 100;
            return difference;
        }
    }
}
