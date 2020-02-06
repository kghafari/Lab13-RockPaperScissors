using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12_Rock_Paper_Scissors
{

    class User : Player
    {

        
        public override Roshambo generateRoshambo()
        {
            GetUserRoshambo("");
            return Choice;
        }

        public void GetUserRoshambo(string input)
        {
            // use ValidateUserRPS 
            string validResponse = Validator.ValidateUserRPS(input); //can only return 'r' 'p' or 's'
            if (validResponse == "r")
            {
                this.Choice = Roshambo.rock;
                Console.WriteLine("User chose rock.");
            }
            else if (validResponse == "p")
            {
                this.Choice = Roshambo.paper;
                Console.WriteLine("User chose paper.");

            }
            else
            {
                this.Choice = Roshambo.scissors;
                Console.WriteLine("User chose scissors.");
            }
        }
    }
}
