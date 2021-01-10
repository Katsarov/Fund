using System;

namespace E01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            // You will be given a count of wagons in a train n. On the next n lines you will receive how many people are going to get on each wagon. At the end print the whole train and after that, on the next line, the sum of the people in the train. 
            int n = int.Parse(Console.ReadLine());

            int[] vagons = new int[n];

            int people = 0;
            for (int i = 0; i < vagons.Length; i++)
            {
                vagons[i] = int.Parse(Console.ReadLine());
                people += vagons[i];
            }

            Console.WriteLine(string.Join(" ", vagons));

            Console.WriteLine(people);
        }
    }
}
