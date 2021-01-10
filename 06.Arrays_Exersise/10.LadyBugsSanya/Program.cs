using System;
using System.Linq;

namespace _10.LadyBugsSanya
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());

            int[] initialIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();  // на тези полета имаме калинки

            int[] field = new int[fieldSize];  // правим си нов масив, който е големината на полето и той е с размера на fieldSize

            // трябва да напълним това поле, чрез цикъл

            for (int i = 0; i < initialIndexes.Length; i++)  // няма смисъл да обхождаме целия масив а само този, в който имаме калинки
            {
                int currentIndex = initialIndexes[i];

                if (currentIndex >= 0 && currentIndex < field.Length)
                {
                    field[currentIndex] = 1;
                }

            }

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "end")  //  чети командата всеки път от конзолата и докато тя не е  "END" продълвавай
            {
                string[] elements = command.Split();  //пример: "0" "right" "1"
                int ladyBugIndex = int.Parse(elements[0]);
                string direction = elements[1];
                int flyLength = int.Parse(elements[2]);

                if (ladyBugIndex < 0 || ladyBugIndex > field.Length - 1 || field[ladyBugIndex] == 0)
                {
                    continue;
                }

                field[ladyBugIndex] = 0;   //  полето, от което е излетяла калинката става празно, т.е. е 0

                if (direction == "right")
                {
                    int landIndex = ladyBugIndex + flyLength;

                    if (landIndex > field.Length - 1)
                    {
                        continue;
                    }

                    if (field[landIndex] == 1)
                    {
                        while (field[landIndex] == 1)
                        {
                            landIndex += flyLength;
                            if (landIndex > field.Length - 1)
                            {
                                break;
                            }
                        }
                    }
                    if (landIndex >= 0 && landIndex <= field.Length - 1)
                    {
                        field[landIndex] = 1;
                    }

                }
                else if (direction == "left")
                {
                    int landIndex = ladyBugIndex - flyLength;

                    if (landIndex < 0)
                    {
                        continue;
                    }

                    if (field[landIndex] == 1)
                    {
                        while (field[landIndex] == 1)
                        {
                            landIndex -= flyLength;
                            if (landIndex < 0)
                            {
                                break;
                            }
                        }
                    }
                    if (landIndex >= 0 && landIndex <= field.Length - 1)
                    {
                        field[landIndex] = 1;
                    }
                }
            }

            Console.WriteLine(string.Join(' ', field));
        }
    }
}
