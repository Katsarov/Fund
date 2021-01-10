using System;

namespace D02.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = new string[7] {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            Console.WriteLine("Enter a number for a weekday between 1 - 7");
            int dayAsNumber = int.Parse(Console.ReadLine());

            while (dayAsNumber < 1 || dayAsNumber > 7)
            {
                Console.WriteLine("Invalid day entered!");
                Console.WriteLine("Enter a valid day!!");

                dayAsNumber = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(daysOfWeek[dayAsNumber - 1]);
        }
    }
}
