using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Game
    {
        //member variables
        string[] action = { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
        string winner;
        Player playerOne;
        Player playerTwo;
        Rules rules;
        //constructor
        public Game()
        {
            rules = new Rules();
         

        }

        //methods
        public void RunGame()
        {
            rules.DisplayRules();
            GetNumberOfPlayers();
            playerOne.GetPlayerName();
            playerTwo.GetPlayerName();
            while (playerOne.score < 2 && playerTwo.score < 2)
            {
                playerOne.GetPlayerInput();
                playerTwo.GetPlayerInput();
                DetermineWinner();
            }
            GameWinner();
            

        }
        public void GetNumberOfPlayers()
        {
            Console.WriteLine("You can play one player, or two player. Enter 'one' for one player, or 'two' for two player.");
            string playerSelection = Console.ReadLine();

            switch (playerSelection)
            {
                case "one":
                    playerOne = new Human();
                    playerTwo = new Computer();
                    break;
                case "two":
                    playerOne = new Human();
                    playerTwo = new Human();
                    break;
                default:
                    Console.WriteLine("That was not a valid entry. Please try again.");
                    GetNumberOfPlayers();
                    break;
            }
        }
        public void GameWinner()
        {            
            if (playerOne.score == 2)
            {
                Console.WriteLine($"{playerOne.name} wins the game!");
            }
            else if (playerTwo.score == 2)
            {
                Console.WriteLine($"{playerTwo.name} wins the game!");
            }
            Console.ReadLine();
        }
        public void DetermineWinner()
        {
            string playerOneAction = action[playerOne.input];
            string playerTwoAction = action[playerTwo.input];

                if (playerOneAction == action[0])
                {
                    if (playerTwoAction == action[0])
                    {
                        Console.WriteLine("You both chose Rock. Play again.");
                    }
                    else if (playerTwoAction == action[3])
                    {
                        Console.WriteLine($"{playerOne.name} wins. Rock crushes Lizard.");
                        playerOne.score++;
                    }
                    else if (playerTwoAction == action[2])
                    {
                        Console.WriteLine($"{playerOne.name} wins. Rock crushes Scissors.");
                        playerOne.score++;
                    }
                    else if (playerTwoAction == action[1])
                    {
                        Console.WriteLine($"{playerTwo.name} wins. Paper covers Rock.");
                        playerTwo.score++;
                    }
                    else if (playerTwoAction == action[4])
                    {
                        Console.WriteLine($"{playerTwo.name} wins. Spock vaporizes Rock.");
                        playerTwo.score++;
                    }
                }
                else if (playerOneAction == action[1])
                {
                    if (playerTwoAction == action[1])
                    {
                        Console.WriteLine("You both chose Paper. Play again.");
                    }
                    else if (playerTwoAction == action[0])
                    {
                        Console.WriteLine($"{playerOne.name} wins. Paper covers Rock.");
                        playerOne.score++;
                    }
                    else if (playerTwoAction == action[4])
                    {
                        Console.WriteLine($"{playerOne.name} wins. Paper disproves Spock.");
                        playerOne.score++;
                    }
                    else if (playerTwoAction == action[2])
                    {
                        Console.WriteLine($"{playerTwo.name} wins. Scissors cuts Paper.");
                        playerTwo.score++;
                    }
                    else if (playerTwoAction == action[3])
                    {
                        Console.WriteLine($"{playerTwo.name} wins. Lizard eats Paper.");
                        playerTwo.score++;
                    }
                }
                else if (playerOneAction == action[2])
                {
                    if (playerTwoAction == action[2])
                    {
                        Console.WriteLine("You both chose Scissors. Play again.");
                    }
                    else if (playerTwoAction == action[1])
                    {
                        Console.WriteLine($"{playerOne.name} wins. Scissors cuts Paper.");
                        playerOne.score++;
                    }
                    else if (playerTwoAction == action[3])
                    {
                        Console.WriteLine($"{playerOne.name} wins. Scissors decapitates Lizard.");
                        playerOne.score++;
                    }
                    else if (playerTwoAction == action[4])
                    {
                        Console.WriteLine($"{playerTwo.name} wins. Spock smashes Scissors.");
                        playerTwo.score++;
                    }
                    else if (playerTwoAction == action[0])
                    {
                        Console.WriteLine($"{playerTwo.name} wins. Rock crushes Scissors.");
                        playerTwo.score++;
                    }
                }
                else if (playerOneAction == action[3])
                {
                    if (playerTwoAction == action[3])
                    {
                        Console.WriteLine("You both chose Lizard. Play again.");
                    }
                    else if (playerTwoAction == action[4])
                    {
                        Console.WriteLine($"{playerOne.name} wins. Lizard poisons Spock.");
                        playerOne.score++;
                    }
                    else if (playerTwoAction == action[1])
                    {
                        Console.WriteLine($"{playerOne.name} wins. Lizard eats Paper.");
                        playerOne.score++;
                    }
                    else if (playerTwoAction == action[0])
                    {
                        Console.WriteLine($"{playerTwo.name} wins. Rock crushes Lizard.");
                        playerTwo.score++;
                    }
                    else if (playerTwoAction == action[2])
                    {
                        Console.WriteLine($"{playerTwo.name} wins. Scissors decapitates Lizard.");
                        playerTwo.score++;
                    }
                }
                else if (playerOneAction == action[4])
                {
                    if (playerTwoAction == action[4])
                    {
                        Console.WriteLine("You both chose Spock. Play again.");
                    }
                    else if (playerTwoAction == action[2])
                    {
                        Console.WriteLine($"{playerOne.name} wins. Spock smashes Scissors.");
                        playerOne.score++;
                    }
                    else if (playerTwoAction == action[0])
                    {
                        Console.WriteLine($"{playerOne.name} wins. Spock vaporizes Rock.");
                        playerOne.score++;
                    }
                    else if (playerTwoAction == action[3])
                    {
                        Console.WriteLine($"{playerTwo.name} wins. Lizard poisons Spock.");
                        playerTwo.score++;
                    }
                    else if (playerTwoAction == action[1])
                    {
                        Console.WriteLine($"{playerTwo.name} wins. Paper disproves Spock.");
                        playerTwo.score++;
                    }
                }
                Console.ReadLine();
        }

    }
}

