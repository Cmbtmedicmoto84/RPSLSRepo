using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS_Project
{
    class Game
    {
        public int pointsNeedToWin;
        public Player playerUno;
        public Player playerDos;


        public Game()
        {
            pointsNeedToWin = 3;
            playerUno = new Human();
        }

        public void DisplayPlayerRules()
        {
            Console.WriteLine("Here are the rules to the game R.P.S.L.S");
            Console.WriteLine("Rock crushes Scissors, Scissors cuts Paper, Paper covers Rock, Rock crushes Lizard, Lizard poisons Spock");
            Console.WriteLine("Spock smashes Scissors, Scissors decapitates Lizard,Lizard eats Paper, Papers disproves Spock, Spock vaporizes Rock");
        }

        public void GameMode()
        {
            Console.WriteLine("Please enter 1 to play against the computer, or enter 2 for Player vs Player battle!");

            string userInput = Console.ReadLine();
            {
                if(userInput == "1")
                {
                    playerDos = new AIPlayer();
                }
                else if(userInput == "2")
                {
                    playerDos = new Human();
                }
                else
                {
                    Console.WriteLine("Choice entered is INVALID!  Please enter 1 to play against the computer, or enter 2 for Player vs Player battle!");
                }
            }
        }

        public void RunGame()
        {
            DisplayPlayerRules();
            GameMode();
        }

        
    }
}
