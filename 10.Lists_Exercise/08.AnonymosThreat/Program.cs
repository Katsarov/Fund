using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.AnonymosThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> data = Console.ReadLine().Split().ToList();


            string input = Console.ReadLine();
            while (input != "3:1")
            {
                string[] commandElements = input.Split();  // получаваме команда

                string command = commandElements[0]; //това е текущата команда

                if (command == "merge")
                {
                    int startIndex = int.Parse(commandElements[1]);
                    int endIndex = int.Parse(commandElements[2]);

                    string concatData = string.Empty;  // правим си един празен стринг, в който ще държим конкатенираните елементи

                    if (startIndex < 0 )
                    {
                        if (endIndex >= 0 && endIndex <= data.Count - 1)
                        {
                            startIndex = 0;
                        }
                    }

                    if (endIndex > data.Count - 1)
                    {
                        if (startIndex >= 0 && startIndex <= data.Count - 1)
                        {
                            endIndex = data.Count - 1;
                        }
                    }

                    if ((startIndex >= 0 & startIndex <= data.Count - 1) &&(endIndex >= 0 && endIndex <= data.Count - 1))
                    // Ако тоша цялото твърдение е грешно, го пропускаме
                    {
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            concatData += data[i];  //при всяко завъртане добавяме в празния стринг елемента от лист на позиция i
                        }

                        //сега трябва да махнем първите 2 елемента, които конкатенирахме и да съобразим следното:
                        // 1. да проверим дали startIndex не е извън границите на масива
                        // 2. да проверим дали endIndex не е извън границите на масива
                        // 3. да проверим дали RemoveRange не е извън границите на масива

                        data.RemoveRange(startIndex, endIndex - startIndex + 1);  //премахваме конкат. елементи (аналогично на зад.5)
                        data.Insert(startIndex, concatData);  // вмукваме конкат.стринг на позицияна на startIndex
                    }
                }

                else if (command == "divide")
                {
                    int index = int.Parse(commandElements[1]);
                    int partitions = int.Parse(commandElements[2]);

                   // if (index >= 0 && index < data.Count - 1)
                   // {

                        string word = data[index];  // Това ще ни върне конкретната дума

                        // Наяата цел е: abcdef -> divide 0 3 --> ab, cd, ef (да разделим нулевия стринг на 3 равни подстринга

                        List<string> dividedWord = new List<string>();
                        // Правим си нов лист, в който ще държим разделения на 3 части стринг (ab cd ef)

                        int stringLengthToAdd = word.Length / partitions;  // Това ще вземе дължината на думата (в случая е 6), ще я раздели на 3 (според броя на партишъните, които са ни дадени) и ще видим по колко символа ще имаме във всяка една част

                        int startIndex = 0;
                        for (int i = 0; i < partitions; i++) // Цикъл от 0 до числото, на което трябва да делим стринга
                        {
                            // Ако думата не се дели без остатък, към последния елемент трябва да добавим и предния
                            // Пример: abcd -> divide 0 3 --> a, b, cd
                            if (i == partitions - 1)
                            {
                                dividedWord.Add(word.Substring(startIndex, word.Length - startIndex));
                            }

                            else
                            {
                                dividedWord.Add(word.Substring(startIndex, stringLengthToAdd));
                                // Substring взима част от някакъв стринг, като му указваме кой е старт индекса и каква е дължината

                                startIndex += stringLengthToAdd;  // Всеки път към този индекс трябва да му добавяме и дълвината на стрига за добавяне, защото ако не го направим, всеки път ще добавяме едно и също нещо
                            }
                        }

                        //Искаме на мястото на индекса [1] да дойде листа divideWord (ред 72)

                        data.RemoveAt(index);  // Това ще махне елемента на съответния индекс (в нашия случай индекса е 0)

                        data.InsertRange(index, dividedWord);  //Да вмъкне на мястото на индекс 0 разделената дума
                    //}
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", data));
        }
    }
}
