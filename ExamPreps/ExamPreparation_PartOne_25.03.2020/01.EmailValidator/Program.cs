using System;
using System.Text;

namespace _01.EmailValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = Console.ReadLine();

            string input = Console.ReadLine();
            while (input != "Complete")
            {
                if (input.Contains("Make Upper"))
                {
                    
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < email.Length; i++)
                    {
                        string newChar = email[i].ToString();
                        sb.Append(newChar.ToUpper());
                        
                    }
                    string result = sb.ToString();
                    Console.WriteLine(result);
                }

                if (input.Contains("Make Lower"))
                {
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < email.Length; i++)
                    {
                        string newChar = email[i].ToString();
                        sb.Append(newChar.ToLower());

                    }
                    string result = sb.ToString();
                    Console.WriteLine(result);
                }

                if (input.Contains("GetDomain"))
                {
                    string[] newCommand = input.Split();
                    int count = int.Parse(newCommand[1]);

                    var result = email.Substring(email.Length - count);
                    //StringBuilder sb = new StringBuilder();
                    //for (int i = input.Length - 1; i >= count; i--)
                    //{
                    //    string newChar = input[i].ToString();
                    //    sb.Append(newChar);
                    //}
                    //string result = sb.ToString();
                    Console.WriteLine(result);
                }
                input = Console.ReadLine();
            }
                 
        }
    }
}
