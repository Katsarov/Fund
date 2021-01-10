using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5; //имаме едно число 5

            int[] ages = new int[n];  //направи масив от 5 елемента

            for (int i = 0; i < n; i++)  //правим един цикъл с 5 завъртания
            {
                ages[i] = i ;  // i = 0; дай ми ages от 0 и го направи 5. Тук все още нищо не печатаме 
                Console.WriteLine(ages[i]);  //тук вече печатаме 5 пъти стойността на i, всеки път увеличена с 1
            }

            Console.WriteLine($"The array lenght is: {ages.Length}");
        }
    }
}
 