using System;
using System.Linq;

namespace D08.Demo_Reverse_Round
{
    class Program
    {
        static void Main(string[] args)
        {
            // Имаме поредица от дробни числа. Да ги закръглим към цяло число и да ги отпечатаме ш обратен ред

            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            //   За да ги закръглим към цяло число, минаваме по всяко едно число
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Math.Round(numbers[i], MidpointRounding.AwayFromZero);
            }

            //   Отпечатваме ги на 1 ред
            Console.WriteLine(string.Join(" ", numbers));

            // Отпечатваме всяко число на отделен ред
            Console.WriteLine(string.Join(Environment.NewLine, numbers));
        }
    }
}