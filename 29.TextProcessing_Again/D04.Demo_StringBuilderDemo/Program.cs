using System;
using System.Diagnostics;
using System.Text;

namespace D04.Demo_StringBuilderDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int times = 100000;
            string stringResult = "";
            Stopwatch watch = Stopwatch.StartNew();

            for (int i = 0; i < times; i++)
            {
                stringResult += "text";
            }

            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds);  // 9905 милисекунди, т.е. около 2 секунди

            // ---------------------------------------------------------
            watch.Reset();
            StringBuilder sbresult = new StringBuilder();

            watch.Start();
            for (int i = 0; i < times; i++)
            {
                sbresult.Append("text");
            }
            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds);  // 1 милисекунди, т.е. около 10 хиляди пъти по-бързо
        }
    }
}
