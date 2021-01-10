using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace _04.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new Dictionary<string, Product>();  // string -> name, Product -> класа product

            while (true)
            {
                string input = Console.ReadLine();  // " Beer 2.20 25"
                if (input == "buy")
                {
                    break;
                }

                string[] splittedInput = input.Split();  // ["Beer", "2.20", "25"]
                string name = splittedInput[0];
                double price = double.Parse(splittedInput[1]);
                int quantity = int.Parse(splittedInput[2]);

                // Чрез конструктора си създаваме един конкретен обект
                
                Product product = new Product(name, price, quantity);

                // Проверка дали имаме продукта в речника или не
                if (!products.ContainsKey(name))  // Ако нямаме такъв продукт
                {
                    products.Add(name, product); // Слагаме името(key) и целия продукт (value)
                }
                else
                {
                    // products[name] - това вече ни е обекта, който има име, цена и количество. 
                    // products[name] е целият обект.И на него вече искаме цената му (.Price) да стане равна на новата цена, която получаваме на ред 23.
                    products[name].Price = price;

                    // И на същия обект (products[name] ушеличаваме количеството)
                    products[name].Quantity += quantity;

                }
            }

            foreach (var pair in products)
            {
                //Чрез pair.Value.Price -> достъпваме до цената в обекта. Аналогично и за количеството.
                Console.WriteLine($"{pair.Key} -> {pair.Value.Price * pair.Value.Quantity:f2}");
                //И накрая трябва да закръглим до 2-я знак.
            }
        }
    }

    public class Product
    {
        public string name;
        public double price;
        public int quantity;

        public Product(string name, double price, int quantity)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }

        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;  // Цената да е равна на някаква стойност
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value; // Количеството да е равно на някаква стойност
            }
        }
    }
}
