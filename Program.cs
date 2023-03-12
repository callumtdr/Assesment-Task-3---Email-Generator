using System;

namespace ConsoleApp1
{
    internal class Program
    {
        
        /// <summary>
        /// The Main Method creates an object called generator from the Generator Class and calls the getUsername method from the Generator Class.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Generator generator = new Generator(); //Creates the generator object of the Generator Class

            generator.getUsername(); //Calls the getUsername method from the Generator Class


        }
    }
}
