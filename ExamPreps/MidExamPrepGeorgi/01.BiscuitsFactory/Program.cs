using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.WeaponSmith

{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> weaponNames = Console.ReadLine().Split("|").ToList();

            string command = Console.ReadLine();

            while (command != "Done")
            {
                string[] curCommand = command.Split().ToArray();

                if (curCommand[0] == "Move")
                {
                    if (curCommand[1] == "Left")
                    {
                        int index = int.Parse(curCommand[2]);

                        if (index >= 1 && index < weaponNames.Count)
                        {
                            string temp = weaponNames[index];  // tova ste vzeme "om" ot primera
                            weaponNames[index] = weaponNames[index - 1];
                            weaponNames[index - 1] = temp;
                        }
                    }
                    else if (curCommand[1] == "Right")
                    {
                        int index = int.Parse(curCommand[2]);
                        if (index >= 0 && index < weaponNames.Count - 1)
                        {
                            string temp = weaponNames[index];  // tova ste vzeme "om" ot primera
                            weaponNames[index] = weaponNames[index + 1];
                            weaponNames[index + 1] = temp;
                        }
                    }
                }

                else if (curCommand[0] == "Check")
                {
                    if (curCommand[1] == "Even")
                    {
                        for (int i = 0; i < weaponNames.Count; i++)
                        {
                            if (i % 2 == 0)
                            {
                                Console.Write($"{weaponNames[i]} ");
                            }
                        }
                        Console.WriteLine();
                    }
                    else if (curCommand[1] == "Odd")
                    {
                        for (int i = 0; i < weaponNames.Count; i++)
                        {
                            if (i % 2 != 0)
                            {
                                Console.Write($"{weaponNames[i]} ");
                            }
                        }
                        Console.WriteLine();
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"You crafted {string.Join("", weaponNames)}!");
        }
    }
}
