using System;

namespace _07.StringManipulator_Kris
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();  // input
            string command = Console.ReadLine();  // comanda
            while (command != "End")
            {
                string[] cmdArgs = command.Split();

                string cmdType = cmdArgs[0];
                input = ProcessInput(input, cmdArgs, cmdType);

                command = Console.ReadLine();
            }
        }

        private static string ProcessInput(string input, string[] cmdArgs, string cmdType)
        {
            if (cmdType.Contains("Translate"))
            {
                string ch = cmdArgs[1];
                string replacement = cmdArgs[2];

                input = input.Replace(ch, replacement);
                Console.WriteLine(input);
            }

            else if (cmdType.Contains("Includes"))
            {
                string subStr = cmdArgs[1];
                bool result = input.Contains(subStr);

                Console.WriteLine(result);
            }

            else if (cmdType.Contains("Start"))
            {
                string subStr = cmdArgs[1];
                bool result = input.StartsWith(subStr);

                Console.WriteLine(result);
            }

            else if (cmdType.Contains("Lowercase"))
            {
                input = input.ToLower();
                Console.WriteLine(input);
            }

            else if (cmdType.Contains("FindIndex"))
            {
                string ch = cmdArgs[1];
                int lastIndex = input.LastIndexOf(ch);

                Console.WriteLine(lastIndex);
            }

            else if (cmdType.Contains("Remove"))
            {
                int startIndex = int.Parse(cmdArgs[1]);
                int count = int.Parse(cmdArgs[2]);

                input = input.Remove(startIndex, count);
                Console.WriteLine(input);
            }

            return input;
        }
    }
}
