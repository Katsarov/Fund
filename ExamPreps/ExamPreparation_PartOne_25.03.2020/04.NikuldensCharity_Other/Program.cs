using System;

namespace _04.NikuldensCharity_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string specialWord = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Finish")
            {
                string[] commandInfo = command.Split();

                string action = commandInfo[0];

                if (action == "Replace")
                {
                    string currentChar = commandInfo[1];
                    string newChar = commandInfo[2];

                    specialWord = specialWord.Replace(currentChar, newChar);
                    Console.WriteLine(specialWord);
                }

                if (action == "Cut")
                {
                    // Command: Cut 1 4
                    // Input: ILIKESHEREN
                    // Output: ISHEREN -> т.е. трчбва да махнем символите от поз.1 до поз. 4 включително (I----SHEREN)
                    int startIndex = int.Parse(commandInfo[1]);
                    int endIndex = int.Parse(commandInfo[2]);

                    if (startIndex < 0 || startIndex >= specialWord.Length || endIndex < 0 || endIndex >= specialWord.Length)
                    {
                        Console.WriteLine("Invalid indexes!");
                    }
                    else
                    {
                        int length = endIndex - startIndex + 1;
                        specialWord = specialWord.Remove(startIndex, length);
                        Console.WriteLine(specialWord);
                    }
                }

                if (action == "Make")
                {
                    string subAction = commandInfo[1];
                    if (subAction == "Upper")
                    {
                        specialWord = specialWord.ToUpper();
                    }
                    else if (subAction == "Lower")
                    {
                        specialWord = specialWord.ToLower();
                    }
                    Console.WriteLine(specialWord);
                }

                if (action == "Check")
                {
                    string targetString = commandInfo[1];
                    if (specialWord.Contains(targetString))
                    {
                        Console.WriteLine($"Message contains {targetString}");
                    }
                    else
                    {
                        Console.WriteLine($"Message doesn't contain {targetString}");
                    }
                }

                if (action == "Sum")
                {
                    int startIndex = int.Parse(commandInfo[1]);
                    int endIndex = int.Parse(commandInfo[2]);

                    if (startIndex < 0 || startIndex >= specialWord.Length || endIndex < 0 || endIndex >= specialWord.Length)
                    {
                        Console.WriteLine("Invalid indexes!");
                    }

                    else
                    {
                        int sum = 0;
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            sum += specialWord[i];
                        }
                        Console.WriteLine(sum);
                    }
                    
                }

                command = Console.ReadLine();
            }
        }
    }
}
