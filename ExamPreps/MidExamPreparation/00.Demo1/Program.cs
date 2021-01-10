using System;

namespace _01.PrepBonusScoringSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());
            int lectureCount = int.Parse(Console.ReadLine());
            int initialBonus = int.Parse(Console.ReadLine());

            double maxBonus = 0;
            int maxStudentAttendance = 0;

            for (int i = 0; i < studentsCount; i++)
            {
                int attendence = int.Parse(Console.ReadLine());

                double totalBonus = 1.0 *attendence / lectureCount * (5 + initialBonus);

                if (totalBonus > maxBonus)
                {
                    maxBonus = totalBonus;
                    maxStudentAttendance = attendence;
                }
            }

            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}.");
            Console.WriteLine($"The student has attended {maxStudentAttendance} lectures.");
        }
    }
}
