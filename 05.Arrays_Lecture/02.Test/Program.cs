using System;

namespace _02.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = new string[] {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            int dayAsNumber = int.Parse(Console.ReadLine());

            if (dayAsNumber >= 1 && dayAsNumber <= 7)
            {
                Console.WriteLine(daysOfWeek [dayAsNumber- 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
