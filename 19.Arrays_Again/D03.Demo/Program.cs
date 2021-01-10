using System;

namespace D03.Demo_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            // Прашим си един масив с имена на студенти
            string[] names = new string[n];

            for (int i = 0; i < names.Length; i++)
            {
                // Прочети ми всяко едно име, което сме въвели на конзолата
                names[i] = Console.ReadLine();
            }

            // За да отпечатаме всички имена, използваме for - цикъл
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"Ne haresvam: { names[i]}");
            }
        }
    }
}
