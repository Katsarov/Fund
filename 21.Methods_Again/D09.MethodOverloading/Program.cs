using System;

namespace D09.MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleWriteline(5);
            ConsoleWriteline("Stringa");
            ConsoleWriteline("stringa", 6);
        }

        static void ConsoleWriteline(string input, int times)
        {
            Console.WriteLine($"string: {input} times: {times}");
        }

        static void ConsoleWriteline(string input)
        {
            Console.WriteLine($"string: {input}");
        }


        static void ConsoleWriteline(int num)
        {
            Console.WriteLine($"int: {num}");
        }
    }
}
