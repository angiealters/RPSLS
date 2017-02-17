using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Rules
    {
        //member variables
        

        //constructor
        public Rules()
        {


        }

        //methods
        public void DisplayRules()
        {
            Console.WriteLine("Welcome to Rock Paper Scissors Lizard Spock! Here are the rules:"
                + "\n Scissors cuts Paper"
                + "\n Paper covers Rock"
                + "\n Rock crushes Lizard"
                + "\n Lizard poisons Spock"
                + "\n Spock smashes Scissors"
                + "\n Scissors decapitates Lizard"
                + "\n Lizard eats Paper"
                + "\n Paper disproves Spock"
                + "\n Spock vaporizes Rock"
                + "\n Rock crushes Scissors");
        }
    }
}
