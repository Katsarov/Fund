using System;

namespace _10._1.MultiplyEvensByOddDakov
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            n = Math.Abs(n);  // прашим си числото половително
            Console.WriteLine(MultiplyEvenAndOddDigits(n));
        }

        static int MultiplyEvenAndOddDigits(int n)
        {
            return CalculateDigitsSum(n, 0) * CalculateDigitsSum(n, 1);
        }

        static int CalculateDigitsSum(int n, int isOdd)
        {
            string number = n.ToString();  // правим си числото на стринг
            int sum = 0; 
            for (int i = 0; i < number.Length; i++)   //  минаваме по цялата дължина на стринга
            {
                int currentDigit = int.Parse(number[i].ToString()); //сегаяният елемент е чар. Него го кастваме към стринг, след което го парсваме към int и го правим на число.
                if (currentDigit % 2 == isOdd)  
                {
                    sum += currentDigit;  // така събираме всички нечетни числа
                }
            }

            return sum;
        }
    }
}
