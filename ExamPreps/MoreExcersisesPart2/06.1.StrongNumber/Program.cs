using System;

namespace _06._1.StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());  
            int tempNum = num;  
            int totalFactorialSum = 0;

            // Стъпка 1 - вземаме цифрите от едно число една по една
            while (tempNum > 0) 
            {
                int digit = tempNum % 10; 
                tempNum = tempNum / 10;  

                // Стъпка 2 - смятаме фактуриел от едно число
                int currentFactorialSum = 1; 

                for (int i = 1; i <= digit; i++)  
                {
                    currentFactorialSum *= i;  
                }

                totalFactorialSum += currentFactorialSum;  
            }

            if (num == totalFactorialSum)  
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
