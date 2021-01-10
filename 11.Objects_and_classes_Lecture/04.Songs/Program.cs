using System;
using System.Collections.Generic;

namespace _04.Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numSongs = int.Parse(Console.ReadLine());  // прочитаме броя на песните

            List<Song> songs = new List<Song>(); // инициализираме си лист с песните, като извикваме конструктора с new List

            for (int i = 0; i < numSongs; i++)
            {
                string[] data = Console.ReadLine().Split("_");

                string type = data[0];
                string name = data[1];
                string time = data[2];

                Song song = new Song();  //Правим си нова колекция, в която добавяме песните

                song.TypeList = type;
                song.Name = name;
                song.Time = time;

                songs.Add(song);

                
            }

            string typeList = Console.ReadLine();  // Прочитаме си какъв ще бъде листа, който ще печатаме
            if (typeList == "all")
            {
                foreach (Song song  in songs)
                {
                    Console.WriteLine($"{song.Name}");
                }
            }
            else
            {
                foreach (Song song in songs)
                {
                    if (song.TypeList == typeList)
                    {
                        Console.WriteLine($"{song.Name}");
                    }
                }
            }
        }
    }

    class Song  // създаваме си структурата на обекта
    {
        public string TypeList { get; set; }

        public string Name { get; set; }

        public string Time { get; set; }
    }
}
