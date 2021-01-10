using System;
using System.Linq;

namespace _04.NikulsdensCharity
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Finish")
            {
                string[] tokens = command.Split();

                if (command.Contains("Replace"))
                {
                    char curChar = (char.Parse(tokens[1]));
                    char newChar = (char.Parse(tokens[2]));

                    input = input.Replace(curChar, newChar);
                    Console.WriteLine(input);
                }

                if (command.Contains("Cut"))
                {
                    int startIndex = int.Parse(tokens[1]);
                    int endIndex = int.Parse(tokens[2]);

                    if (startIndex < 0 || endIndex > input.Length-1)
                    {
                        Console.WriteLine("Invalid indexes!");
                    }
                    else
                    {
                        //Вариант 1
                        //input = input.Substring(0, startIndex) + input.Substring(endIndex + 1);

                        // Вариант 2
                        int length = endIndex - startIndex + 1;
                        input = input.Remove(startIndex, length);
                        Console.WriteLine(input);
                    }
                }

                if (command.Contains("Make"))
                {
                    if (tokens[1] == "Upper")
                    {
                        input = input.ToUpper();
                        Console.WriteLine(input);
                    }
                    else if (tokens[1] == "Lower")
                    {
                        input = input.ToLower();
                        Console.WriteLine(input);
                    }
                }

                if (command.Contains("Check"))
                {
                    var proof = tokens[1];

                    if (input.Contains(proof))
                    {
                        Console.WriteLine($"Message contains {proof}");
                    }
                    else
                    {
                        Console.WriteLine($"Message doesn't contain {proof}");
                    }
                }

                if (command.Contains("Sum"))
                {
                    int startIndex = int.Parse(tokens[1]);
                    int endIndex = int.Parse(tokens[2]);
                    int index = 0;
                    if (startIndex >= 0 && endIndex <= input.Length-1)
                    {
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            index += (char)input[i];
                        }
                        Console.WriteLine(index);
                    }
                    else
                    {
                        Console.WriteLine("Invalid indexes!");
                    }
                }

                command = Console.ReadLine();
            }

        }
    }
}
