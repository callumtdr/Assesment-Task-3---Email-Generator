using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    internal class Generator
    {
        /// <summary>
        /// this Method prompts the user to enter a first and second name to generate an email address.
        /// </summary>
        /// <returns></returns>
        public string getUsername()
        {

            string userName;    //declares the userName variable,

                do   //loops until a valid name is entered,
                {
                    Console.WriteLine("Enter your First and Second name"); //prompts the user to enter a first and second name.
                    userName = Console.ReadLine(); //reads the users input and stores it in the userName Variable.
                }
                while (!IsValidName(userName) == true);
            
                Console.WriteLine($"Your Email is {EmailBuilder(userName)}");  //if a valid name is entered, the email is constructed from the EmailBuilder Method and prints it.

                return getUsername(); //calls the getUsername Method returns the result.
        }

        /// <summary>
        /// This Method runs through the enter userName variable and validates that it has been input correctly.
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        private bool IsValidName(string userName)
        {

            userName.Trim(); //Removes spaces from the the start and end of the userName.
            string[] names = userName.Split(' '); //Creates a new array called names and splits userName at the space to populate the array.
        

            if (names.Length != 2) //Checks wether the name array does not have 2 names. 
            {
                Console.WriteLine("ERROR: Enter First Name, Second Name,and Use Characters only");
                return false;
            }


            foreach (char c in names[0]) //Checks if the first name in the array only has characters.
            {
                if (!char.IsLetter(c))
                {
                    Console.WriteLine("ERROR: Enter First Name, Second Name,and Use Characters only");
                    return false;
                
                }
            
            }

            foreach (char c in names[1]) //Checks if the second name only has characters.
            {
                if (!char.IsLetter(c))
                {
                    Console.WriteLine("ERROR: Enter First Name, Second Name,and Use Characters only");
                    return false;
                }
            }

            return true; // returns true if no errors are found in the userName.
        }


        /// <summary>
        /// This Method takes the users input userName and builds the final Email.
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public string EmailBuilder(string userName)
        {
            string dAndA = "@dundeeandanguscollege.ac.uk"; //declares the string dAndA and assigns its data.

            userName.Trim(); //Removes spaces from the the start and end of the userName.

            string[] names = userName.Split(' '); //Creates a new array called names and splits userName at the space to populate the array.

            string firstName = names[0].Substring(0, 1).ToUpper() + names[0].Substring(1).ToLower(); //Declares the variable firstName name and assigns it to Index 0 of the names array. Then takes the first character, changing it to uppercase then taking the rest of the characters from index 1 and changing them to lowercase.
            string secondName = names[1].Substring(0, 1).ToUpper() + names[1].Substring(1).ToLower(); //Declares the variable secondName name and assigns it to Index 1 of the names array. Then takes the first character, changing it to uppercase then taking the rest of the characters from index 1 and changing them to lowercase

            string email = string.Concat(firstName, ".", secondName, dAndA); //Concatenate's the firstName, a period, the secondName and dAndA and assigns it to the email Variable.


            return email; //Returns the email variable.
        }
    }

