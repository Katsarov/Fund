using System;

namespace D04.Demo_anonymosObject
{
    class Program
    {
        static void Main(string[] args)
        {
            var birthday = new Birthday();
            birthday.Day = 22;
            birthday.Month = 6;
            birthday.Year = 1983;

            Console.WriteLine($"{birthday.Day} : {birthday.Month} : {birthday.Year}");
        }

        public class Birthday
        {
            public int Day;
            public int Month;
            public int Year;
        }
    }
}
