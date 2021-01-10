using System;
using System.Globalization;

namespace E01.DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string dateString = Console.ReadLine();
            DateTime date = DateTime.ParseExact(dateString, "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(date.DayOfWeek);
        }
    }
}
