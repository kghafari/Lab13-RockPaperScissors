using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12_Rock_Paper_Scissors
{
    class RockBot : Player
    {
        //fields
        //prop?
        //const
        public RockBot()
        {

        }

        public string returnRoshamboAsString()
        {
            Roshambo choice = generateRoshambo();
            string roshString = choice.ToString();
            return roshString;
        }

        //methods
        public override Roshambo generateRoshambo()
        {
            Choice = Roshambo.rock;
            return Choice;
        }
    }
}
