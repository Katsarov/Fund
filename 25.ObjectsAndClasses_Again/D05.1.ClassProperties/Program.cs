using System;

namespace D05._1.ClassProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog pesho = new Dog("Pesho", 77);
            pesho.PrintDog();

            Dog gosho = new Dog("Gosho", 55);
            gosho.PrintDog();
        }
    }
}
