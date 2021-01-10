using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.FancyBarcode
{
    class Program
    {
        static void Main(string[] args)
        {
            // Правим си първо регекса
            Regex regex = new Regex(@"@#+(?<product>[A-Z][a-zA-Z0-9]{4,}[A-Z])@#+");

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                // Прочитаме си входния баркод
                string barcodeInput = Console.ReadLine();
                Match match = regex.Match(barcodeInput);

                // Проверяваме дали баркода е валиден. Ако не е валиден:
                if (!match.Success)
                {
                    Console.WriteLine("Invalid barcode");
                    continue;
                }

                // Ако баркода е валиден, го мачваме с регекса
                string barcode = match.Groups["product"].Value;

                StringBuilder group = new StringBuilder();
                // Сега минаваме с един фор цикъл за да вземем само числата и да го конкатенираме
                for (int j = 0; j < barcode.Length; j++)
                {
                    //  Проверяваме дали текущия чар е число или не е
                    if (Char.IsDigit(barcode[j]))
                    {
                        group.Append(barcode[j]);
                    }
                }

                if (String.IsNullOrEmpty(group.ToString()))
                {
                    group.Append("00");
                }

                Console.WriteLine($"Product group: {group}");

            }
        }

    }
}
