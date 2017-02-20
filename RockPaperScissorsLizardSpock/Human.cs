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
            Console.WriteLine("{0}: Enter '0' for rock, '1' for paper, '2' for scissors, '3' for lizard, or '4' for spock.", name);
            try
            {
                input = int.Parse(Console.ReadLine());
            }
            catch(Exception)
            {
                Console.WriteLine("Please enter a number between 0 and 4");
                GetPlayerInput();
            }
        }
    }
}
