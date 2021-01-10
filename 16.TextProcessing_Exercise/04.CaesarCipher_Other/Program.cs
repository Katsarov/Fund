using System;
using System.Linq;

namespace _04.CaesarCipherLambda

{
    class Program
    {
        static void Main(string[] args)
        {
            char[] text = Console.ReadLine().Select(x => x + 3).Select(x => (char)x).ToArray();
            Console.WriteLine(string.Join("", text));
        }
    }
}
