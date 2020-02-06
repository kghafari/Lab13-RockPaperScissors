using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12_Rock_Paper_Scissors
{
    class RoshamboApp
    {
        //setup objects for our different player types, so we don't have to 
        //  instatiate new ones while we jump around methods.
        RockBot rockBot = new RockBot();
        RandomBot randomBot = new RandomBot();
        User user = new User();

        public void StartRosh()
        {
            string userName = GetUserName();
            PrintMainMenu(userName);

        }

        private void PrintMainMenu(string userName)
        {
            //prints main menu (lazy)
            Console.WriteLine($"Hi, {userName}. Let's play some Roshambo!");

            bool validChoice = true;
            while (validChoice)
            {
                Console.WriteLine("1. Rockman, 2. Random Randy 3. Exit");
                string userSelection = Console.ReadLine();
                validChoice = false;

                switch (userSelection)
                {
                    case "1": //rockman
                        FightRockMan(user, rockBot);
                        break;
                    case "2": //random randy
                        FightRandomGuy(user, randomBot);
                        break;
                    case "3":
                        ExitProgram();
                        break;
                    default:
                        validChoice = true;
                        Console.WriteLine("Please make a valid selection (1, 2 or 3)");
                        break;
                }

            }
        }

        private void FightRockMan(User user, RockBot rockBot)
        {
            // 1. get user (r, p or s)
            user.GetUserRoshambo("");

            // 2. Get a new rocky boy, and set Choice to Roshambo.rock

            rockBot.generateRoshambo(); //returns an Enum, Roshambo.rock
            Console.WriteLine($"Rockman chose {rockBot.Choice}.");

            //do stuff
            if (user.Choice == Roshambo.scissors)
            {
                Console.WriteLine("Rockman wins! :(");
            }
            else if (user.Choice == Roshambo.paper)
            {
                Console.WriteLine("You win! :)");
            }
            else
            {
                Console.WriteLine("You tied! :| ");
            }
            Console.WriteLine();
            UserContinue();



        }

        private void FightRandomGuy(User user, RandomBot randomBot)
        {
            //dostuff
            user.GetUserRoshambo("");
            randomBot.generateRoshambo();
            Console.WriteLine($"Random Randy chose {randomBot.Choice}");

            // all ties case
            if (user.Choice == randomBot.Choice)
            {
                Console.WriteLine("You tied! :| ");
            }
            else if ((user.Choice == Roshambo.rock) && (randomBot.Choice == Roshambo.scissors))
            {
                Console.WriteLine("You win! :) ");
            }
            else if ((user.Choice == Roshambo.rock) && (randomBot.Choice == Roshambo.paper))
            {
                Console.WriteLine("You lose :( ");
            }
            else if ((user.Choice == Roshambo.paper) && (randomBot.Choice == Roshambo.rock))
            {
                Console.WriteLine("You win :) ");
            }
            else if ((user.Choice == Roshambo.paper) && (randomBot.Choice == Roshambo.scissors))
            {
                Console.WriteLine("You lose :( ");
            }
            else if ((user.Choice == Roshambo.scissors) && (randomBot.Choice == Roshambo.paper))
            {
                Console.WriteLine("You win :) ");
            }
            else if ((user.Choice == Roshambo.scissors) && (randomBot.Choice == Roshambo.rock))
            {
                Console.WriteLine("You lose :( ");
            }
            else
            {
                Console.WriteLine("I must have forgotten a case..."); //if i was a real wizard, i would throw an exception here
            }

            UserContinue();

            // r = 0, p = 1, s = 2
            // r - r    p - p   s - s ties
            // r - p    p - r   s - r 
            // r - s    p - s   s - p

        }

        private void UserContinue()
        {          
            bool userContinue = true;
            while (userContinue)
            {
                Console.WriteLine("Would you like to continue? (y/n)");
                string userSelection = Console.ReadLine();
                userContinue = false;

                switch(userSelection)
                {
                    case "y":
                        PrintMainMenu("again ");
                        break;
                    case "n":
                        Console.WriteLine("Goodbye!");
                        ExitProgram();
                        break;
                    default:
                        Console.WriteLine("Please make a valid selection (y or n).");
                        userContinue = true;
                        break;
                }
                
            }
            Console.WriteLine();
        }

        private void ExitProgram()
        {
            Environment.Exit(0);
        }

        private string GetUserName()
        {
            Console.Write("Name: ");
            return Console.ReadLine();
        }



    }
}
