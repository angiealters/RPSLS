using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Computer : Player
    {
        //member variables

        //constructor
        public Computer()
        {
            this.name = "Sheldon";
           
        }
    
        //methods
        public override void GetPlayerInput()
        {
            base.GetPlayerInput();
            Random random = new Random();
            input = random.Next(0,5);
            Console.WriteLine($"Sheldon chose {input}");
            Console.ReadLine();
        }

    }
}
