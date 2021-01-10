using System;

namespace _04._1.PasswordValidatorExplanation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ще имаме 3 булеви метода, по един за всяка проверка
            // Първият проверява дали паролата съдържа 6-10 символа
            // Вторият проверява дали паролата се състои само от букви и цифри
            // Третият проверява дали паролата има най-малко 2 цифри

            // Четем си входа
            string password = Console.ReadLine();

            // Правим си трите прошерки
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

            // Проверяваме дали и трите са валидни
            if (isValidlength(password) && IsLetterOrDigit(password) && HasAtLeastTwoDigits(password))
            {
                Console.WriteLine("Password is valid");
            }

        }

        // Да съдържа 6-10 символа
        static bool isValidlength(string password)
        {
            return password.Length >= 6 && password.Length <= 10;
        }

        // Да се състои само от букви и цифри
        static bool IsLetterOrDigit(string password)
        {
            foreach (char symbol in password)  //при цикъл foreach нямаме индекси, а минаваме през всички елементи
                                               // Този вид цикъл НЕ работи върху: int, double, long. 
                                               // Този вид цикъл работи върху колекции: масиви, стрингове, списъци, т.е. всичко, което мове да се обховда
            {
                if (!char.IsLetterOrDigit(symbol))  //използваме вградена функция IsLetterOrDigit(). 
                                                    // В наяич случай: ако НЕ Е буква или цифра (този символ)
                {
                    return false;
                }
            }

            return true;
        }

        // Да има най-малко 2 цифри

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
