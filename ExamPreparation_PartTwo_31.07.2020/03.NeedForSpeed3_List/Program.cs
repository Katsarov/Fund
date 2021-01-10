using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.NeedForSpeed3_List
{
    class Program
    {
        static void Main(string[] args)
        {
            // {car}|{mileage}|{fuel}
            // Прашвим си речник със стринг име на колата, и в него още един речник, в който ще държим километри и гориво
            Dictionary<string, List<int>> cars = new Dictionary<string, List<int>>();

            int n = int.Parse(Console.ReadLine());

            // На следващите n редове четем: 

            for (int i = 0; i < n; i++)
            {
                // Стринг масив с информацич за сегашната кола
                var carInfo = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);

                var name = carInfo[0];
                var mileage = int.Parse(carInfo[1]);
                var fuel = int.Parse(carInfo[2]);

                // Към дикшинърито cars добавяме името на колата (Key), а на позицич Value ще добавим още едно дикшинъри с 2 записа: един за километраж и един за гориво
                // Структура на речника: 
                // Key (name ) -> Audi
                // Value (mileage, fuel) -> mileage -> 120000
                //                       -> fuel -> 50
                cars.Add(name, // Key: Opel
                    new List<int>()
                    {
                        mileage, fuel
                    });
                    // Value:
                
            }

            // Сега преминаваме към прочитане и изпълнение на командите
            string command = Console.ReadLine();


            while (command != "Stop")
            {
                // Първо четем сегаяната команда и я сплитваме
                var tokens = command.Split(" : ", StringSplitOptions.RemoveEmptyEntries);

                var action = tokens[0];
                var carName = tokens[1];

                // Команда Drive : {car} : {distance} : {fuel}
                if (action.Contains("Drive"))
                {
                    var distance = int.Parse(tokens[2]);
                    var fuel = int.Parse(tokens[3]);

                    // Проверяваме дали колата има достатъчно гориво
                    var carFuel = cars[carName][1];  // това ни дава горивото на колата с това конкретно име
                    if (fuel > carFuel)
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }
                    else
                    {
                        // увеличаваме километрава на колата с разстоянието, което трябва да измине
                        cars[carName][0] += distance;

                        // намаляваме горивото на колата с горивото, необходимо за изминаване на това разстояние
                        cars[carName][1] -= fuel;
                        Console.WriteLine($"{carName} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                    }

                    // Проверяваме дали колата е достаигнала 100 000 км. Ако е така, да я махнем от списъка
                    if (cars[carName][0] >= 100000)
                    {
                        Console.WriteLine($"Time to sell the {carName}!");
                        cars.Remove(carName);
                    }

                }

                if (action.Contains("Refuel"))
                {
                    var fuelToAdd = int.Parse(tokens[2]);
                    var currentFuel = cars[carName][1];

                    if (fuelToAdd + currentFuel > 75)
                    {
                        fuelToAdd = 75 - currentFuel;
                    }
                    cars[carName][1] += fuelToAdd;
                    Console.WriteLine($"{carName} refueled with {fuelToAdd} liters");
                }

                if (action.Contains("Revert"))
                {
                    var kilometers = int.Parse(tokens[2]);
                    cars[carName][0] -= kilometers;
                    if (cars[carName][0] < 10000)
                    {
                        cars[carName][0] = 10000;
                    }
                    else
                    {
                        Console.WriteLine($"{carName} mileage decreased by {kilometers} kilometers");
                    }
                }

                command = Console.ReadLine();
            }

            // Финално отпечатваме
            var ordered = cars.OrderByDescending(x => x.Value[0]).ThenBy(x => x.Key);

            foreach (var car in ordered)
            {
                Console.WriteLine($"{car.Key} -> Mileage: {car.Value[0]} kms, Fuel in the tank: {car.Value[1]} lt.");
            }
        }
    }
}