using System;

namespace _01.BiscuitFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int biscuitsPerWorkerPerDay = int.Parse(Console.ReadLine());
            int numberOfWorkers = int.Parse(Console.ReadLine());
            int totalBiscuitsCompetitor = int.Parse(Console.ReadLine());

            int totalBiscuitsPerDay = biscuitsPerWorkerPerDay * numberOfWorkers;
            double totalBiscuits = 0;

            for (int i = 0; i < 30; i++)
            {
                if (i % 3 == 0)
                {
                    totalBiscuits += Math.Floor(totalBiscuitsPerDay * 0.75);
                }
                else
                {
                    totalBiscuits += totalBiscuitsPerDay;
                }
            }

            double diff = Math.Abs(totalBiscuitsCompetitor - totalBiscuits);

            double percentage = diff / totalBiscuitsCompetitor * 100;

            Console.WriteLine($"You have produced {totalBiscuits:f0} biscuits for the past month.");

            if (totalBiscuits > totalBiscuitsCompetitor)
            {
                Console.WriteLine($"You produce {percentage:f2} percent more biscuits.");
            }
            else
            {
                Console.WriteLine($"You produce {percentage:f2} percent less biscuits.");
            }
        }
    }
}
