using System;

namespace _10.RangeExpences
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGameCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            // if lostGame % 2 == 0 -> headset
            // if lostGame % 2 == 0 -> mouse
            // if lostGame % 2 == 0 -> keyboard
            // if lostGame % 2 == 0 -> display

            double rageExpences = 0;

            for (int i = 1; i <= lostGameCount; i++)
            {
                if (i % 2 == 0)
                {
                    rageExpences += headsetPrice;
                }
                if (i % 3 == 0)
                {
                    rageExpences += mousePrice;
                }
                if (i % 6 == 0)
                {
                    rageExpences += keyboardPrice;
                }
                if (i % 12 == 0)
                {
                    rageExpences += displayPrice;
                }
            }

            Console.WriteLine($"Rage expenses: {rageExpences:f2} lv.");
        }
    }
}
