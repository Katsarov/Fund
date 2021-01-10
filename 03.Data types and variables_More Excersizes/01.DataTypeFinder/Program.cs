using System;

namespace _01.DataTypeFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            while (command != "END")
            {
                string dataName = string.Empty;

                int numberInt;
                bool isInt = Int32.TryParse(command, out numberInt);

                double numberDouble;
                bool isDouble = Double.TryParse(command, out numberDouble);

                char charValue;
                bool isChar = Char.TryParse(command, out charValue);

                bool boolValue;
                bool isBool = Boolean.TryParse(command, out boolValue);

                if (isInt)
                {
                    dataName = "integer";
                }
                else if (isDouble)
                {
                    dataName = "floating point";
                }
                else if (isChar)
                {
                    dataName = "character";
                }
                else if (isBool)
                {
                    dataName = "boolean";
                }
                else
                {
                    dataName = "string";
                }

                Console.WriteLine($"{command} is {dataName} type");

                command = Console.ReadLine();
            }

            if (command == "END")
            {
                return;
            }
        }
    }
}
