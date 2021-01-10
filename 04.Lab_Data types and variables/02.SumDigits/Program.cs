using System;

namespace _02.SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int sum = 0;

            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }

            Console.WriteLine(sum);

            // Същото, но времето е 2 пъти по-кратко
            
            //int number = int.Parse(Console.ReadLine());
            //int digit = number;

            //int sum = 0;

            //while (digit > 0)
            //{
            //    sum += digit % 10;
            //    digit /= 10;
            //}

            //Console.WriteLine(sum);
        }


    }
}
