using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace _02.GaussTrickExplanation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = ReadList();

            for (int i = 0; i < list.Count / 2; i++)  // въртим цикъла само до средата
            {
                Console.Write(list[i] + list[list.Count - 1 - i] + " ");  // към първия елемент [i] добавяме последния елемент [list.Count - 1 - i] и въртим цикъла на обратно.
            }

            if (list.Count % 2 == 1)
            {
                Console.Write(list[list.Count / 2]);
            }
            Console.WriteLine();
        }

        static List<int> ReadList()
        {
            List<int> list = new List<int>();  //Създаваме си празен лист от интове
            string[] elements = Console.ReadLine().Split();  // Създаваме масив от стрингове и ги сплитваме по интервали
            for (int i = 0; i < elements.Length; i++)  //  С цикъл минаваме по всеки един от тези елементи
            {
                list.Add(int.Parse(elements[i]));  //Елемента "i" го парсваме към число, което добавяме в листа
            }
            return list;
        }
    }
}

