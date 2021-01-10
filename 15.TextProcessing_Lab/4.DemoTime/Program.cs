using System;
using System.Diagnostics;
using System.Text;

namespace _4.DemoTime
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = 100000;
            
            //Тук ще използваме стринг
            string stringResult = "";
            Stopwatch watch = Stopwatch.StartNew();
            for (int i = 0; i < time; i++)
            {
                stringResult += "text";
            }

            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds);

            // Ресетваме часовника
            watch.Reset();

            // Тук ще използваме StringBuilder
            StringBuilder sbResult = new StringBuilder();
            watch.Start();

            for (int i = 0; i < time; i++)
            {
                sbResult.Append("text");
            }

            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds);
        }

        // Резултат: string -> 9180 milliseconds / StringBuilder -> 1 millisecond

    }
}
