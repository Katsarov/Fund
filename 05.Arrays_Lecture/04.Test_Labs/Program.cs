using System;
using System.Linq;

namespace _04.Test_Labs
{
    class Program
    {
        static void Main(string[] args)
        {
            // отпечатване с string.Join, без да ползваме цикъл

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string array = String.Join('\n', numbers);
            Console.WriteLine(array);

        }
    }
}
