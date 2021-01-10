using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace TribonachiSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = long.Parse(Console.ReadLine());

            var array = Tribonachi(num);
            Console.WriteLine(string.Join(" ", array));
        }

        static long[] Tribonachi(long number)
        {
            var array = new long[number];
            if (number == 1)
            {
                array[0] = 1;
                return array;
            }

            else if (number == 2)
            {
                array[0] = 1;
                array[1] = 1;
                return array;
            }

            else if (number == 3)
            {
                array[0] = 1;
                array[1] = 1;
                array[2] = 2;
                return array;
            }

            else
            {
                array[0] = 1;
                array[1] = 1;
                array[2] = 2;
                for (int i = 3; i < number; i++)
                {
                    array[i] = array[i - 1] + array[i - 2] + array[i - 3]; 
                }

                return array;
            }
        }
    }
}
