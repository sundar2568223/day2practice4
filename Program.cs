using System;
namespace Consoleday2prac4
{
    internal class program
    {
        static void Main(string[] args)
        {
            string userName;
            Again:
            Console.WriteLine("Enter User Name");
            userName = Console.ReadLine();
            if (userName.Length >= 6)
            {
                Console.WriteLine("Welcome : \t " + userName);
            }
            else
            {
                Console.WriteLine("Invalid User Name");
                goto Again;
            }
            Console.ReadKey();
        }

    }
}