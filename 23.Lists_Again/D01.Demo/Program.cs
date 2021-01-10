using System;
using System.Collections.Generic;

namespace D01.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();

            names.Add("Peter");
            names.Add("Ivan");
            names.Add("Maria");
            names.Add("Dimitar");

            // Вариант 1: Отпечатва всяко име на нов ред
            
            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}

            // Вариант 2: Отпечатва всяко име на нов ред
            Console.WriteLine(string.Join(Environment.NewLine, names));

            // Отпечатва бройката на имената в листа
            Console.WriteLine(names.Count);

            // Отпечатва името с индекс 0 (на позиция 1)
            Console.WriteLine(names[0]);
        }
    }
}
