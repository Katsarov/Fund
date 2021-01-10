using System;

namespace _12.RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //int kolkko = int.Parse(Console.ReadLine()); ok 1
            //int obshto = 0;
            //int takova = 0; ok 3
            //bool toe = false;
            //for (int ch = 1; ch <= kolkko; ch++) ok 2
            //{
            //    takova = ch;
            //    while (ch > 0)
            //    {
            //        obshto += ch % 10;
            //        ch = ch / 10;
            //    }
            //    toe = (obshto == 5) || (obshto == 7) || (obshto == 11);
            //    Console.WriteLine("{0} -> {1}", takova, toe);
            //    obshto = 0;
            //    ch = takova;
            //}

            int number = int.Parse(Console.ReadLine());
            int current = 0;

            for (int i = 1; i <= number; i++)
            {
                current = i;
                int sum = 0;

                while (current > 0)
                {
                    sum += current % 10;
                    current /= 10;
                }

                bool isSpecial = false;
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    isSpecial = true;
                }

                Console.WriteLine($"{i} -> {isSpecial}");
            }
        }
    }
}
