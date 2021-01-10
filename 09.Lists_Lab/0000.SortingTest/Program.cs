using System;
using System.Collections.Generic;
using System.Linq;

namespace _0000.SortingListMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            Sort(nums);

            Console.WriteLine(string.Join(" ", nums));
        }

        static void Sort(List<int> nums)
        {
            for (int i = 0; i < nums.Count; i++)
            {
                int min = i;
                for (int j = i + 1; j < nums.Count; j++)
                {
                    if (nums[j] < nums[min])
                    {
                        min = j;
                    }
                }

                int temp = nums[i];
                nums[i] = nums[min];
                nums[min] = temp;
            }
        }
    }
}
