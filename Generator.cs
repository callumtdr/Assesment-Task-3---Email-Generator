using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    internal class Generator
    {
    public string getUsername()
    {
        //Console.WriteLine("Enter your First and Second name");

        string userName;
        try
        {
            do
            {
                Console.WriteLine("Enter your First and Second name");
                userName = Console.ReadLine();
            }
            while (!IsValidName(userName) == true);
            
            Console.WriteLine($"Your Email is {EmailBuilder(userName)}");

            
        }
        catch (Exception e)
        {
            Console.WriteLine("error:" + e);
        }



        return getUsername();
    }


    private bool IsValidName(string userName)
    {

        userName.Trim();
        string[] names = userName.Split(' ');
        

        if (names.Length != 2)
        {
            Console.WriteLine("ERROR: Enter First Name, Second Name,and Use Characters only");
            return false;
        }


        foreach (char c in names[0])
        {
            if (!char.IsLetter(c))
            {
                Console.WriteLine("ERROR: Enter First Name, Second Name,and Use Characters only");
                return false;
                
            }
            
        }

        foreach (char c in names[1])
        {
            if (!char.IsLetter(c))
            {
                Console.WriteLine("ERROR: Enter First Name, Second Name,and Use Characters only");
                return false;

            }

        }

        return true;
    }



    public string EmailBuilder(string userName)
        {
            string dAndA = "@dundeeandanguscollege.ac.uk";

            userName.Trim();

            string[] names = userName.Split(' ');

            string firstName = names[0].Substring(0, 1).ToUpper() + names[0].Substring(1).ToLower();
            string secondName = names[1].Substring(0, 1).ToUpper() + names[1].Substring(1).ToLower();

            string email = string.Concat(firstName, ".", secondName, dAndA);


            return email;
        }
    }

