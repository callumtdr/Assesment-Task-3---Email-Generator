using System;

namespace ConsoleApp1
{
    internal class Program
    {
        //public static string email { get; private set; }

        static void Main(string[] args)
        {
            Generator generator = new Generator();

            generator.getUsername();

            //string userEmail = generator.getUsername();

            //Console.WriteLine($"Your Email is {userEmail}");


            //string email = generator.EmailBuilder();
        }
    }
}
