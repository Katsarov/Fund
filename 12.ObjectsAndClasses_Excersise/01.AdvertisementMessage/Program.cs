using System;

namespace _01.AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            // Ще използваме for цикъл за да си генерираме толкова фрази, колкото е числото n.

            for (int i = 0; i < n; i++)
            {
                // За да приложим метода за генериране на съобщенията, трябва да посочим: class.method
                // Задълвително е обаче метода да бъде static, като пропъртитата (стринговете) за Phrases, Events, Autors & Cities също трчбва да са статични.

                Console.WriteLine(AdvertisementMessage.GenerateMessage());
            }
        }
    }

    public class AdvertisementMessage
    {
        // Правим си 4 стринга със сбора от думи, от които след това ще генерираме съобщения
        public static string[] Phrases = new string[] { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };

        public static string[] Events = new string[] { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };

        public static string[] Autors = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

        public static string[] Cities = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

        // Сега си правим един метод, който ще връща съобщенията от рандомизиране на думите. Той няма да приема нищо и ще работи с информацията от горните 4 стринга 
        public static string GenerateMessage()
        {
            Random rand = new Random();
            string currentPhrase = Phrases[rand.Next(0, Phrases.Length)];

            // Това ни генерира рандом число в диапазона от 0 до Phrases.Length - 1 (до дължината на масива)
            // По същия начин си правим и за останалите 3 стринга

            string currentEvent = Events[rand.Next(0, Events.Length)];
            string currentAutor = Autors[rand.Next(0, Autors.Length)];
            string currentCity = Cities[rand.Next(0, Cities.Length)];

            //Връщаме резултата в зададения формат

            return $"{currentPhrase} {currentEvent} {currentAutor} - {currentCity}";
        }
    }
}
