using System;

namespace _02.TestArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] names = new string[n];

            for (int i = 0; i < names.Length; i++)  //инициализираме имената в клетките
            {
                names[i] = Console.ReadLine();
            }

            for (int i = 0; i < names.Length; i++)  // разпечатваме имената от клетките
            {
                Console.Write(names[i] + " ");
            }
        }
    }
}
