using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS_Project
{
    class Game : Player
    {
        public int pointsNeedToWin;
        public Player playerUno;
        public Player playerDos;
        //public string userInput; not sure if i need this here.

        public Game()
        {
            pointsNeedToWin = 3;
            playerUno = new Human();
        }

        public void DisplayPlayerRules()
        {
            Console.WriteLine("Welcome to the Rock, Paper, Scissors, Lizard, Spock game.");
            Console.WriteLine();
            Console.WriteLine("Here are the rules to the game R.P.S.L.S");
            Console.WriteLine("Rock crushes Scissors, Scissors cuts Paper, Paper covers Rock, Rock crushes Lizard, Lizard poisons Spock");
            Console.WriteLine("Spock smashes Scissors, Scissors decapitates Lizard,Lizard eats Paper, Papers disproves Spock, Spock vaporizes Rock");
        }

        public void GameMode()
        {
            Console.WriteLine("Please enter 1 to play against the computer, or enter 2 for Player vs Player battle! \n");
            string mode = Console.ReadLine();

            switch (mode)
            {
                case "1":
                    Console.WriteLine("Welcome to the Player vs Computer game of R.P.S.L.S!!");
                    break;
                case "2":
                    Console.WriteLine("Welcome to the Player vs Player game of R.P.S.L.S!!");
                    break;
                default:
                    Console.WriteLine("Choice entered is INVALID!  Please enter 1 to play against the computer, or enter 2 for Player vs Player battle! \n");
                    string userinput = Console.ReadLine();
                    break;
            }
            return;
        }

        public override void WhatGesture()
        {
           
        }

        public void RunGame()
        {
            DisplayPlayerRules();
            GameMode();

            
            //Figure out how this is going to work!
            //playerUno.WhatGesture();
            //playerDos.WhatGesture();
        }

        
    }
}
