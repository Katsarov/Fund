using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string weekDay = Console.ReadLine();

            decimal pricePerPerson = 0;

            if (typeOfGroup == "Students")
            {
                if (weekDay == "Friday")
                {
                    pricePerPerson = 8.45M;
                }
                else if (weekDay == "Saturday")
                {
                    pricePerPerson = 9.8M;
                }
                else if (weekDay == "Sunday")
                {
                    pricePerPerson = 10.46M;
                }
            }
            else if (typeOfGroup == "Business")
            {
                if (weekDay == "Friday")
                {
                    pricePerPerson = 10.9M;
                }
                else if (weekDay == "Saturday")
                {
                    pricePerPerson = 15.6M;
                }
                else if (weekDay == "Sunday")
                {
                    pricePerPerson = 16.0M;
                }
            }
            else if (typeOfGroup == "Regular")
            {
                if (weekDay == "Friday")
                {
                    pricePerPerson = 15.0M;
                }
                else if (weekDay == "Saturday")
                {
                    pricePerPerson = 20.0M;
                }
                else if (weekDay == "Sunday")
                {
                    pricePerPerson = 22.5M;
                }
            }

            decimal totalPrice = pricePerPerson * people;

            if (typeOfGroup == "Students" && people >= 30)
            {
                totalPrice = totalPrice * 0.85M;
            }
            else if (typeOfGroup == "Business" && people >= 100)
            {
                totalPrice = totalPrice - pricePerPerson * 10;
            }
            else if (typeOfGroup == "Regular" && people >= 10 && people <= 20)
            {
                totalPrice = totalPrice * 0.95M;
            }

            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
