using System;

namespace _02.Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            GradeInWords(grade);
        }

        static void GradeInWords(double digit)
        {
            string result = string.Empty;
            if (digit >= 2.0 && digit <= 2.99)
            {
                result = "Fail";
            }
            else if (digit >= 3.0 && digit <= 3.49)
            {
                result = "Poor";
            }
            else if (digit >= 3.5 && digit <= 4.49)
            {
                result = "Good";
            }
            else if (digit >= 4.5 && digit <= 5.49)
            {
                result = "Very good";
            }
            else if (digit >= 5.5 && digit <= 6.0)
            {
                result = "Excellent";
            }
            else
            {
                Console.WriteLine();
            }
            Console.WriteLine(result);
        }
    }
}
