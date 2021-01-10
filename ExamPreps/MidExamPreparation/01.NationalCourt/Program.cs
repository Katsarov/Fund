using System;

namespace _01.NationalCourt
{
    class Program
    {
        static void Main(string[] args)
        {
            int employeeFirst = int.Parse(Console.ReadLine());
            int employeeSecond = int.Parse(Console.ReadLine());
            int employeeThird = int.Parse(Console.ReadLine());
            int peopleCount = int.Parse(Console.ReadLine());

            int peoplePerHour = employeeFirst + employeeSecond + employeeThird;


            int timeNeeded = 0;

            while (peopleCount > 0)
            {
                peopleCount -= peoplePerHour;
                timeNeeded++;

                if (timeNeeded % 4 == 0 && timeNeeded != 0)
                {
                    timeNeeded++;

                }
            }

            Console.WriteLine($"Time needed: {timeNeeded}h.");
        }
    }
}


