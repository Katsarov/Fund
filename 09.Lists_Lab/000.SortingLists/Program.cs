using System;
using System.Collections.Generic;

namespace _000.SortingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //Сортиране на стрингове

            //List<string> names = new List<string>() { "Peter", "John", "Ivan", "Michael", "Toni" };
            //names.Sort();

            //Console.WriteLine(string.Join(", ", names));

            //----------------------


            //Сортиране на числа

            List<int> numbers = new List<int>() { 1, -1, 2, 3, -5, 5, 7 };

            Console.WriteLine(string.Join(" ", numbers));

            //Отпечатва ги от малко число към  голямо 
            numbers.Sort();
            Console.WriteLine(string.Join(" ", numbers));
            
            //Отпечатва ги от голямо към малко число
            numbers.Reverse();
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
