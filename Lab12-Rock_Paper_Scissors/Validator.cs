using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12_Rock_Paper_Scissors
{
    class Validator
    {

        public static string ValidateUserRPS(string input)
        {           
            bool validChoice = true;
            while(validChoice)
            {
                string userSelection = GetUserInput("Rock, Paper, or Scissors? (r/p/s)");
                validChoice = false;

                switch(userSelection)
                {
                    case "r":
                        return userSelection;
                    case "p":
                        return userSelection;
                    case "s":
                        return userSelection;
                    default:
                        validChoice = true;
                        Console.WriteLine("Please make a valid selection (r, p, or s)");
                        break;
                }              
            }
            return "uhh.. that's no good?";
        }

        private static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }
    }
}
