using System;

namespace D02.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintEvenNumbersTo100();
            Hello();
        }

        static void PrintEvenNumbersTo100()
        {
            Console.WriteLine("Print 1 to 100");
            Console.WriteLine("Exiting");
            Console.WriteLine("Exiting Main");
        }

        static void Hello()
        {
            Console.WriteLine("In hello");
            PrintEvenNumbersTo100();
            Console.WriteLine("exiting HELLO");
        }
    }
}
