using System;
using System.Text;

namespace _3.DemoStringbuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder result = new StringBuilder("Pesho");
            result.Append("Gosho");
            result.Append("Todoraki");
            result[0] = 'Z';
            result.Insert(2, "???");
            result.Remove(2, 1);
            string stringResult = result.ToString();

            Console.WriteLine(stringResult);
        }
    }
}
