using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            string operands = Console.ReadLine();

            while (operands != "End")
            {
                List<string> commands = operands.Split().ToList();


                switch (commands[0])
                {
                    case "Add":
                        list.Add(int.Parse(commands[1]));
                        break;

                    case "Insert":
                        int index = int.Parse(commands[2]);
                        if (index >= 0 && index < list.Count)
                        {
                            list.Insert(index, int.Parse(commands[1]));
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");

                        }
                        break;

                    case "Remove":
                        int indexToRemove = int.Parse(commands[1]);
                        if (indexToRemove >= 0 && indexToRemove < list.Count)
                        {
                            list.RemoveAt(indexToRemove);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;

                    case "Shift":
                        int count = int.Parse(commands[2]);
                        if (commands[1] == "left")
                        {
                            for (int i = 0; i < count; i++)  //правим си цикъл, тъй като трябва да въртим колкото пъти трябва
                            {
                                int firstNum = list[0];   // вземаме елемента, който е с индекс 0
                                list.Add(firstNum);  // добавяме този елемент в края на листа, като той присъства и на първа позиция
                                list.RemoveAt(0);  // и сега премахваме елемента, който е на първа позиция
                            }
                        }
                        else if(commands[1] == "right")
                        {
                            for (int i = 0; i < count; i++)  //правим си цикъл, тъй като трябва да въртим колкото пъти трябва
                            {
                                int lastNum = list[list.Count - 1];   // вземаме елемента, който е на края на листа
                                list.Insert(0, lastNum);  // добавяме този елемент в началото на листа, като той присъства и на последна позиция
                                list.RemoveAt(list.Count - 1);  // и сега премахваме елемента, който е на последната позиция
                            }
                        }
                        break;

                    
                }

                operands = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
