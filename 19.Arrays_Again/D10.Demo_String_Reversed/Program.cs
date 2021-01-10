using System;

namespace D10.Demo_String_Reversed
{
    class Program
    {
        static void Main(string[] args)
        {
            // Искаме да разменим елементите на пършата и последната клетки, след това на втората и предпоследната и т.н.

            string[] names = Console.ReadLine().Split();
            for (int i = 0; i < names.Length / 2; i++)
            {
                string temp = names[i];
                names[i] = names[names.Length - i - 1];
                names[names.Length - i - 1] = temp;
            }

            Console.WriteLine(string.Join(" ", names));
        }
    }
}
