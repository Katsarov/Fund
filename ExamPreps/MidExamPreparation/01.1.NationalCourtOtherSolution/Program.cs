using System;

namespace _01._1.NationalCourtOtherSolution
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
            int timeneeded = 0;

            bool customersAreServed = false;

            if (peopleCount != 0)
            {
                while (!customersAreServed)
                {
                    timeneeded++;
                    if (timeneeded % 4 == 0)
                    {
                        continue;
                    }

                    peopleCount -= peoplePerHour;
                    if (peopleCount <= 0)
                    {
                        customersAreServed = true;
                    }
                }
            }

            Console.WriteLine($"Time needed: {timeneeded}h.");
        }
    }
}
