using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12_Rock_Paper_Scissors
{
    abstract class Player
    {
        //properties
        public string Name { get; set; }

        public Roshambo Choice { get; set; }

        //methods
        public abstract Roshambo generateRoshambo();

        
    }
}
