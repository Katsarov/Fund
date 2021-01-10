using System;
using System.Threading;

namespace _07.StringManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] curCommand = command.Split();

                string action = curCommand[0];

                if (action.Contains("Translate"))
                {
                    string oldChar = curCommand[1];
                    string newChar = curCommand[2];

                    message = message.Replace(oldChar, newChar);
                    Console.WriteLine(message);
                }

                if (action.Contains("Includes"))
                {
                    string includes = curCommand[1];

                    if (message.Contains(includes))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                if (action.Contains("Start"))
                {
                    string start = curCommand[1];
                    int count = 0;
                    for (int i = 0; i < start.Length; i++)
                    {
                        count++;
                    }

                    string substring = message.Substring(0, count);

                    if (start == substring)
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                if (action.Contains("Lowercase"))
                {
                    message = message.ToLower();
                    Console.WriteLine(message);
                }
                if (action.Contains("FindIndex"))
                {
                    char charIndex = char.Parse(curCommand[1]);
                    int neededIndex = message.LastIndexOf(charIndex);
                    Console.WriteLine(neededIndex);
                }
                if (action.Contains("Remove"))
                {
                    int startIndex = int.Parse(curCommand[1]);
                    int count = int.Parse(curCommand[2]);

                    message = message.Remove(startIndex, count);
                    Console.WriteLine(message);
                }

                command = Console.ReadLine();
            }
        }
    }
}
