using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Human : Player
    {
        //member variables

        //constructor

        //methods
        public override void GetPlayerName()
        {
            base.GetPlayerName();
            Console.WriteLine("Please enter name.");
            name = Console.ReadLine();
        }
        public override void GetPlayerInput()
        {
            base.GetPlayerInput();
            Console.WriteLine("Enter '0' for rock, '1' for paper, '2' for scissors, '3' for lizard, or '4' for spock.");
            input = int.Parse(Console.ReadLine());
        }
    }
}
