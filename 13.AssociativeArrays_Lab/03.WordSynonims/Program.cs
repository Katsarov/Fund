using System;
using System.Collections.Generic;

namespace _03.WordSynonims
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            // Ключа ни ще е самата дума, а стойността ни ще бъде лист от стрингове (тъй като синонимите може да са повече от един)
            Dictionary<string, List<string>> wordSynonims = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonim = Console.ReadLine();

                // да имаме думата -> добавяме синонима
                // да нямаме думата -> добавяме думата и после нейния синоним

                if (wordSynonims.ContainsKey(word))
                {
                    // Достъпваме value в листа чрез: wordSynonims[word] и към него добавяме синонима
                    wordSynonims[word].Add(synonim);
                }
                else
                {
                    //Ако я нямаме думата, трябва да я добавим в речника (добавяме Key  и един празен лист за Value)
                    wordSynonims.Add(word, new List<string>());

                    //И сега, за да добавим синонима в този празен лист:
                    wordSynonims[word].Add(synonim);
                }
            }

            // Отпеюатваме
            foreach (var pair in wordSynonims)
            {
                Console.WriteLine(pair.Key + " - " + string.Join(", ", pair.Value));
            }
        }
    }
}
