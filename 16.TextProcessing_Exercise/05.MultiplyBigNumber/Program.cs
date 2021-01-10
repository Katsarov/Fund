using System;
using System.Text;

namespace _05.MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ако има нули в началото на числото - да ги махнем
            // Ако второто число, с което умноваваме е 0, то няма смисъл въобще да смятаме, резултата е нула

            string reallyBigNumber = Console.ReadLine().TrimStart('0');
            int number = int.Parse(Console.ReadLine());

            if (number == 0)
            {
                Console.WriteLine(0);
                return;
            }

            // Ако още горе на ред 13 не използваме .TrimStart('0'), тук трябва да направим проверка за водещи нули (примерно числото е 000013583)
            // Ако имаме 00723. Влизаме в цикъла, защото първата цифра е 0. След това казваме на reallyBigNumber да стане равно на reallyBigNumber но като започне от първия индекс. В случая той отново е 0 и цикъла се завърта още веднъж. При третото завъртане първия индекс вече е 7 и излизаме от while цикъла.
            //while (reallyBigNumber[0] == '0')
            //{
            //    reallyBigNumber = reallyBigNumber.Substring(1);
            //}

            // За да запазваме резултата, ще използваме StringBuilder, който първоначално ще е празен
            StringBuilder sb = new StringBuilder();

            
            // Правим си една променлива, в която ще държим "едно на ум", което остава при умножението на числа > 5 (примерно 3 * 8 = 24. 4 го запазваме и държим 2 "на ум")
            int reminder = 0;

            // С един обратен фор цикъл ще обходим първото число отзад напред, за да вземем всяка една цифра от него, след което резултатаще го долепяме в стрингбилдъра
            for (int i = reallyBigNumber.Length - 1; i >= 0; i--)
            {
                // Тъй като текущата цифра тук е чар (reallyBigNumber[i]), първо трябва да я превърнем в стринг, след което цялото това да го парснем към int
                int result = int.Parse(reallyBigNumber[i].ToString()) * number + reminder;

                // след като сме добавили reminder-a, сега го зануляваме.
                reminder = 0;

                // Сега проверяваме дали след като сме добавили резултата, текущата вифра не е станала по-голяма от 9
                if (result > 9)
                {
                    reminder = result / 10;  // защото примерно 27 / 10 = 2 понеже делим две цели числа и тази двойка ни остава "на ум"
                    result = result % 10;    // за резултат вземаме само последната цифра, от горния пример това е 7
                }

                sb.Append(result);
            }

            // Тук си правим финална проверка, дали случайно reminder не е  > 0, защото ако е така, трябва накрая да го добавим и него
            if (reminder != 0)
            {
                sb.Append(reminder);
            }

            // Готови сме със сметките, но полученото число е на обратно. За да го обърнем, използваме още един StringBuilder
            StringBuilder finalResult = new StringBuilder();

            // Логика за обръщане на резултата
            // Обхождаме с с обратен фор цикъл първия стрингбилдър и всеки елемент ще го долепяме в новия билдър finalResult
            for (int i = sb.Length - 1; i >= 0; i--)
            {
                finalResult.Append(sb[i]);
            }

            Console.WriteLine(finalResult);
        }
    }
}
