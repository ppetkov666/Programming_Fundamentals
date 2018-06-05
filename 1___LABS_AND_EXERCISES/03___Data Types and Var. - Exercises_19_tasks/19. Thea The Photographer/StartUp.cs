namespace _19._Thea_The_Photographer
{
    using System;
    class StartUp
    {
        static void Main()
        {
            long pictures = long.Parse(Console.ReadLine());
            long filterTimePerPicture = long.Parse(Console.ReadLine());
            long goodPicsReadyForUpload = long.Parse(Console.ReadLine());
            long timeToUploadFilteredPics = long.Parse(Console.ReadLine());

            long timeAfterFiltering = pictures * filterTimePerPicture;

            double useFullPics = Math.Ceiling((pictures * (double)(goodPicsReadyForUpload) / 100));

            long timeForUseFullPics = (long)useFullPics * timeToUploadFilteredPics;

            long totalTime = timeAfterFiltering + timeForUseFullPics;

            TimeSpan formaterdTime = TimeSpan.FromSeconds(totalTime);
            Console.WriteLine(formaterdTime.ToString(@"d\:hh\:mm\:ss"));
        }
    }
}
