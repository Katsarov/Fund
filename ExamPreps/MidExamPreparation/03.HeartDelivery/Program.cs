using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.HeartDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split("@").Select(int.Parse).ToArray();

            string command = Console.ReadLine();

            int currentPosition = 0;
            int lastPositionIndex = 0;

            while (command != "Love!")
            {
               
                string[] curCommand = command.Split();

                int timesToJump = int.Parse(curCommand[1]);               //Convert.ToInt32(curCommand[1]);
                if (curCommand[0] == "Jump")
                {

                    for (int i = 0; i < input.Length; i++)
                    {
                        if (timesToJump + currentPosition >= 0 && timesToJump + currentPosition < input.Length)
                        {
                            currentPosition += timesToJump;
                        }
                        else
                        {
                            currentPosition = (currentPosition + timesToJump) % input.Length;
                        }

                        lastPositionIndex = currentPosition;

                        if (input[currentPosition] == 0)
                        {
                            Console.WriteLine($"Place {currentPosition} has Valentine's day.");
                            //break;
                        }
                        else
                        {
                            input[currentPosition] -= 2;
                            //break;
                        }

                       
                    }
                }
                

                command = Console.ReadLine();
            }

            int failedPlaces = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != 0)
                {
                    failedPlaces++;
                }
            }

            Console.WriteLine($"Cupid's last position was {lastPositionIndex}.");


            if (failedPlaces == 0)
            {
                Console.WriteLine("Mission was successful.");
            }

            else
            {
                Console.WriteLine($"Cupid has failed {failedPlaces} places.");
            }

        }
    }
}
