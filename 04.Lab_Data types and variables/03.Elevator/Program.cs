using System;

namespace _03.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPeople = int.Parse(Console.ReadLine());  // 17
            int capacity = int.Parse(Console.ReadLine());  // 3

            int courses = (int)Math.Ceiling(numOfPeople / (double)capacity);

            Console.WriteLine(courses);
        }
    }
}
