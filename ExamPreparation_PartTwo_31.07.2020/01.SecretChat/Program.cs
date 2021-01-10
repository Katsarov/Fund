using System;
using System.Linq;
using System.Text;

namespace _01.SecretChat
{
    class Program
    {
        static void Main(string[] args)
        {
            string concealedMessage = Console.ReadLine();

            string input = Console.ReadLine();

            while (input != "Reveal")
            {
                string[] tokens = input.Split(":|:", StringSplitOptions.RemoveEmptyEntries);
                var command = tokens[0];

                switch (command)
                {
                    case "InsertSpace":
                        var index = int.Parse(tokens[1]);
                        concealedMessage = concealedMessage.Insert(index, " ");
                        break;

                    case "Reverse":
                        break;

                    case "ChangeAll":
                        break;
                }


                input = Console.ReadLine();
            }
        }
    }
}
