using System;

namespace _01.SoftUniReception
{
    class Program
    {
        static void Main(string[] args)
        {
            int employeeFirst = int.Parse(Console.ReadLine());
            int employeeSecond = int.Parse(Console.ReadLine());
            int employeeThird = int.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());

            int studentsPerHour = employeeFirst + employeeSecond + employeeThird;  // примерно: 5 + 6 + 4 = 11 часа
            int timeneeded = 0;

            bool studentsServed = false;  // първоначална стойност: условието е грешно

            if (studentsCount != 0)  // ако бройката на студентите е различна от 0, условието е вярно
            {
                while (!studentsServed)  // докато условието е вярно
                {
                    timeneeded++; // веднага като влезем в цикъла добавяме първия час
                    if (timeneeded % 4 == 0)  //всеки 4-ти час работниците имат почишка и не работят през този час, затова не го добавяме към общите часове
                    {
                        continue;  //продължаваме без да го добавяме
                    }

                    studentsCount -= studentsPerHour;  // в началото сме имали 20 студенти. Обслужени са 11 за 1 час: 20 = 20 - 11;
                    if (studentsCount <= 0)  // докато студентите са повече от 0
                    {
                        studentsServed = true;  // условието е вярно и цикъла се завърта отново
                    }
                }
            }

            Console.WriteLine($"Time needed: {timeneeded}h.");
        }
    }
}
