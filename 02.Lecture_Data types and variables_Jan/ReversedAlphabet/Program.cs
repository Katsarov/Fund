using System;

namespace ReversedAlphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            // Да се отпечатат големите букви от английската азбука наобратно

            for (int i = 0; i < 26; i++)  //  в английската азбука има 26 букви
            {
                Console.Write((char)(90 - i) + " ");  // 90 е ASCII кода на 'Z'
            }

            Console.WriteLine();
            // Да се отпечатат големите букви от английската азбука 

            for (int i = 0; i < 26; i++)  //  в английската азбука има 26 букви
            {
                Console.Write((char)(65 + i) + " ");  // 65 е ASCII кода на 'A'
            }
        }
    }
}
