using System;
using System.Linq;
using System.Windows.Markup;

namespace _04.ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            // да се обърнат елементите от първия масив на обратно и да се запазят в друг масив
            string[] elements = Console.ReadLine().Split();

            for (int i = 0; i < elements.Length/2; i++)
            {
                //алгоритъм за обръщане на 2 стойности

                string temp = elements[i];
                elements[i] = elements[elements.Length - i - 1];
                elements[elements.Length - i - 1] = temp;

                //Console.Write(elements[i] + " ");
            }
                Console.WriteLine(String.Join(" ", elements));
        }
    }
}
