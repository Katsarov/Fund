using System;
using System.Text;

namespace _2.DemoStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Hello!");  // Добавя Hello! и минава на нов ред
            sb.Append("My name is "); // Добавя My name is 
            sb.Append("Kalin");       // Добавя Kalin към горното
            sb.AppendLine();          // Добавя нов ред

            string returnedSB = sb.ToString().Trim(); // След всички промени си го обръщаме отново в стринг

            Console.WriteLine(returnedSB);  // Отпечатва новия стринг с промените и маха един празен ред
        }
    }
}
