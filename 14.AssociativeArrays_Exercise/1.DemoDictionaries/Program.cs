using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.DemoDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> dict = new Dictionary<string, List<int>>();
            dict.Add("1", new List<int>() { 2, 1, 3 });
            dict.Add("2", new List<int>() { 5, 7, 3 });
            dict.Add("3", new List<int>() { 6, 1, 3 });

            //  Как да сортираме числата в речника за 2 и 3?

            //dict["2"] = dict["2"].OrderBy(x => x).ToList(); // по този начин сортирахме целия масив по value във възходящ ред
            //dict["3"].Sort();

            // Как да сортираме и за трите речника по value?

            var keys = dict.Keys.ToList();  // вземаме всички ключове, кастваме ги към лист
            for (int i = 0; i < keys.Count; i++)  // обхождаме всеки един
            {
                dict[keys[i]] = dict[keys[i]].OrderBy(x => x).ToList();  // всеки един го сортираме
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} : {String.Join(" ", item.Value)}");
            }
        }
    }
}
