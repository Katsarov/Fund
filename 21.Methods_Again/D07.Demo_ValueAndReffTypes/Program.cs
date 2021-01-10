using System;

namespace D07.Demo_ValueAndReffTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = x;
            y = 7;

            Console.WriteLine(y);
            
        }

        
    }
}
