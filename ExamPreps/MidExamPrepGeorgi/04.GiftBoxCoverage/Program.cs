using System;

namespace _04.GiftBoxCoverage
{
    class Program
    {
        static void Main(string[] args)
        {
            double sizeOfSide = double.Parse(Console.ReadLine());
            int numOfPaperSheets = int.Parse(Console.ReadLine());
            double areaOfPaperSheet = double.Parse(Console.ReadLine());

            double areaGiftBox = (sizeOfSide * sizeOfSide) * 6;  // obem na kutiyata

            double totalPaperArea = 0;

            for (int i = 1; i <= numOfPaperSheets; i++)
            {
                double currSheetArea = areaOfPaperSheet;

                if (i % 3 == 0)
                {
                    currSheetArea = areaOfPaperSheet * 0.25;
                }
                totalPaperArea += currSheetArea;
            }

            double percentage = totalPaperArea / areaGiftBox * 100;

            Console.WriteLine($"You can cover {percentage:f2}% of the box.");
        }
    }
}
