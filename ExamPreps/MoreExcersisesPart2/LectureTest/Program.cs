using System;

namespace LectureTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            // username -> Acer
            // 1. lenght = 4
            // 2. username [0] -> A

            string password = string.Empty;  // recA

            for (int i = username.Length - 1; i >= 0; i--)  //правим обратно обховдане на стринг
            {
                password += username[i];  // добавяме по 1 символ
            }

            string input = Console.ReadLine();
            int counter = 1;

            while (input != password)
            {
                if (counter == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                Console.WriteLine("Incorrect password. Try again.");
                input = Console.ReadLine();
                counter++;
            }

            if (input == password)
            {
                Console.WriteLine($"User {username} logged in.");
            }
        }
    }
}
