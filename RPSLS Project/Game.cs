using System;

namespace RPSLS_Project
{
    class Game : Player
    {
        public int pointsNeedToWin;
        public Player playerUno;
        public Player playerDos;
        public string[] whatGesture;
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

            bool validChoice = false;
            while (!validChoice)
            {
                string mode = Console.ReadLine();
                switch (mode)
                {
                    case "1":
                        Console.WriteLine("Welcome to the Player vs Computer game of R.P.S.L.S!!");
                        playerDos = new AIPlayer();
                        validChoice = true;
                        break;
                    case "2":
                        Console.WriteLine("Welcome to the Player vs Player game of R.P.S.L.S!!");
                        playerDos = new Human();
                        validChoice = true;
                        break;
                    default:
                        Console.WriteLine("Choice entered is INVALID!  Please enter 1 to play against the computer, or enter 2 for Player vs Player battle! \n");
                        break;
                }
            }
            return;
        }
        public void ChooseWhatGesture()
        {
            Console.WriteLine("Please choose from the list of moves");
            Console.WriteLine("Type the corresponding number for the selected move: 0 - Rock, 1 - Paper, 2 - Scissors, 3 - Lizard, 4 - Spock \n");

            bool gestureChoice = false;
            while(!gestureChoice) 
            {
                string gesture = Console.ReadLine();
                switch (gesture)
                {
                    case "0":
                        Console.WriteLine("Player chooses Rock");
                        gestureChoice = true;
                        break;
                    case "1":
                        Console.WriteLine("Player chooses Paper");
                        gestureChoice = true;
                        break;
                    case "2":
                        Console.WriteLine("Player chooses Scissors");
                        gestureChoice = true;
                        break;
                    case "3":
                        Console.WriteLine("Player chooses Lizard");
                        gestureChoice = true;
                        break;
                    case "4":
                        Console.WriteLine("Player chooses Spock");
                        gestureChoice = true;
                        break;
                    default:
                        Console.WriteLine("Invalid selection");
                        break;
                }
            }
            //problem here
        }


        public void RunGame()
        {
            DisplayPlayerRules();
            GameMode();
            ChooseWhatGesture();

            
            //Figure out how this is going to work!
            //playerUno.WhatGesture();
            //playerDos.WhatGesture();
        }

        
    }
}
