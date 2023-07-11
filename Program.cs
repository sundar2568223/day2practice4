using System;
using System.Text;

namespace Consoleday2prac4
{
    internal class program
    {
        static void Main(string[] args)
        {
            //string userName;
            //Again:
            //Console.WriteLine("Enter User Name");
            //userName = Console.ReadLine();
            //if (userName.Length >= 6)
            //{
            //    Console.WriteLine("Welcome : \t " + userName);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid User Name");
            //    goto Again;
            //}
            //Console.ReadKey();
            //string mystring = "sundar";
            //StringBuilder stringBuilder = new StringBuilder("welcome");
            //stringBuilder.Append("To C#");
            //stringBuilder.Append("I am String Builder");
            //stringBuilder.Append("string:\t " + mystring);
            //Console.WriteLine(stringBuilder);
            //Console.ReadKey();
            for(int i = 1;i<10;i++)
            {
                if(i == 6)
                {
                    goto end;
                }
                Console.WriteLine("i value:{0}", i);
            }
        end: Console.WriteLine("The end");
       
        }

    }
}