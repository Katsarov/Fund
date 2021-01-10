using System;
using System.Globalization;

namespace _01.DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string dateString = Console.ReadLine();  // прочитаме си дата от конзолата

            DateTime date = DateTime.ParseExact(dateString, "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(date.DayOfWeek);

            // въвеждаме: 18-04-2016  --> отпечатва ни: Monday
        }
    }
}
