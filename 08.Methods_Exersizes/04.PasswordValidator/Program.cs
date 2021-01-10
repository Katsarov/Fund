using System;

namespace _04.PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            if (!isValidlength(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (!IsLetterOrDigit(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (!HasAtLeastTwoDigits(password))
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (isValidlength(password) && IsLetterOrDigit(password) && HasAtLeastTwoDigits(password))
            {
                Console.WriteLine("Password is valid");
            }
            
        }

        static bool isValidlength(string password)
        {
            return password.Length >= 6 && password.Length <= 10;
        }

        static bool IsLetterOrDigit(string password)
        {
            foreach (char symbol in password)  
            {
                if (!char.IsLetterOrDigit(symbol))  
                {
                    return false;  
                }
            }

            return true;
        }

        static bool HasAtLeastTwoDigits(string password)
        {
            int digitsCounter = 0;

            for (int i = 0; i < password.Length; i++)
            {
                foreach (char symbol in password)
                {
                    if (char.IsDigit(symbol))
                    {
                        digitsCounter++;
                    }
                }
            }

            return digitsCounter >= 2;
        }
    }
}
