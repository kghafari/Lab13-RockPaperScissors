using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12_Rock_Paper_Scissors
{
    class RandomBot : Player
    {
       
        public override Roshambo generateRoshambo()
        {
            Random r = new Random();
            int randomChoice = r.Next(0, 3);
            Roshambo[] choices = { Roshambo.rock, Roshambo.paper, Roshambo.scissors };
            Roshambo randomSelection = choices[randomChoice];
            return randomSelection;
        }

        public void printRoshambo()
        {
            Roshambo botChoice = generateRoshambo();
            Console.WriteLine(botChoice);
        }
    }
}
