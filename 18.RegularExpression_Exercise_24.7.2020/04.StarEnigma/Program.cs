using System;
using System.Text.RegularExpressions;

namespace _04.StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "STCDoghudd4=63333$D$0A53333";
            string pattern = @"[sStTaArR";

            string newPattern = @"^[^@!:>-]*@(?<planetName>[A-Za-z]*)[^@!:>-]*:[^@!:>-]*?(?<populationCount>\d+)[^@!:>-]*![^@!:>-]*(?<attackType>[AD])![^@!:>-]*->(?<soldierCount>\d+)[^@!:>-]*$";

            var matches = Regex.Matches(input, pattern);

            int count = matches.Count;

            string decryptedMessage = String.Empty;

            foreach (var character in input)
            {
                decryptedMessage += (char)(character - count);
            }

            Console.WriteLine(decryptedMessage);
        }
    }
}
