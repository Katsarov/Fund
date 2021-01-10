using System;

namespace _09.PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyAmount = double.Parse(Console.ReadLine());
            int numOfStudents = int.Parse(Console.ReadLine());
            double lightSaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double actualNumOfStudents = Math.Ceiling(numOfStudents * 1.1);

            double totalLightSaber = actualNumOfStudents * lightSaberPrice;
            double totalRobePrice = numOfStudents * robePrice;
            double totalBeltPrice = numOfStudents * beltPrice - (numOfStudents / 6 * beltPrice);

            double neededEquipment = totalLightSaber + totalRobePrice + totalBeltPrice;

            double moneyNeeded = neededEquipment - moneyAmount;

            if (neededEquipment > moneyAmount)
            {
                Console.WriteLine($"Ivan Cho will need {moneyNeeded:f2}lv more.");
            }

            else
            {
                Console.WriteLine($"The money is enough - it would cost {neededEquipment:f2}lv.");
            }
        }
    }
}
