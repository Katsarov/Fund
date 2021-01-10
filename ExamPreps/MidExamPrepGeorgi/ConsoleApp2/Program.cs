using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {

        
            static void Main(string[] args)
            {
                List<int> time = Console.ReadLine().Split().Select(int.Parse).ToList();

                string command = Console.ReadLine();

                while (command != "End")
                {
                    string[] currCommand = command.Split().ToArray();

                    if (currCommand[0] == "Complete")
                    {
                        int index = int.Parse(currCommand[1]);
                        if (index >= 0 && index < time.Count)
                        {
                            time[index] = 0;
                        }
                    }

                    else if (currCommand[0] == "Change")
                    {
                        int index = int.Parse(currCommand[1]);
                        int timeIndex = int.Parse(currCommand[2]);

                        if (index >= 0 && index < time.Count)
                        {
                            time[index] = timeIndex;
                        }
                    }

                    else if (currCommand[0] == "Drop")
                    {
                        int index = int.Parse(currCommand[1]);
                        if (index >= 0 && index < time.Count)
                        {
                            time[index] = -1;
                        }
                    }

                    else if (currCommand[0] == "Count")
                    {
                        int counter = 0;
                        if (currCommand[1] == "Completed")
                        {
                            for (int i = 0; i < time.Count; i++)
                            {
                                if (time[i] == 0)
                                {
                                    counter++;

                                }
                            }
                        }
                        else if (currCommand[1] == "Incomplete")
                        {
                            for (int i = 0; i < time.Count; i++)
                            {
                                if (time[i] > 0)
                                {
                                    counter++;

                                }
                            }
                        }
                        else if (currCommand[1] == "Dropped")
                        {
                            for (int i = 0; i < time.Count; i++)
                            {
                                if (time[i] < 0)
                                {
                                    counter++;

                                }
                            }
                        }
                        Console.WriteLine(counter);
                    }



                    command = Console.ReadLine();
                }

                for (int i = 0; i < time.Count; i++)
                {
                    if (time[i] > 0)
                    {
                        Console.Write(time[i] + " ");
                    }
                }

            }
        }
    }

