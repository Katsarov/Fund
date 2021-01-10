using System;

namespace _2.DemoReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "It is not Linux, it is Linux. Linux is merely the kernel, while Linux adds the functionality.";
            
            // Замени навсякъде "Linux" с "Windows"
            string replaced = text.Replace("Linux", "Windows");
            Console.WriteLine(replaced);

            // Замени навсякъде "W" с "w"
            string newReplace = replaced.Replace('W', 'w');
            Console.WriteLine(newReplace);
        }
    }
}
