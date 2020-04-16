using System;

namespace RPSLS_Project
{
    class Game
    {
        public int pointsNeedToWin;
        public Player playerUno;
        public Player playerDos;
        public int playerUnoScore;
        public int playerDosScore;
        //public int totalPlayersScore;
        public string gesture;
        
        //public string userInput; not sure if i need this here.

        public Game()
        {
            pointsNeedToWin = 3;
            playerUno = new Human();
            playerUnoScore = 0;
            playerDosScore = 0;

            
        }

        public void DisplayPlayerRules()
        {
            Console.WriteLine("Welcome to the Rock, Paper, Scissors, Lizard, Spock game.");
            Console.WriteLine();
            Console.WriteLine("Here are the rules to the game R.P.S.L.S");
            Console.WriteLine("Rock crushes Scissors, Scissors cuts Paper, Paper covers Rock, Rock crushes Lizard, Lizard poisons Spock,");
            Console.WriteLine("Spock smashes Scissors, Scissors decapitates Lizard, Lizard eats Paper, Papers disproves Spock, Spock vaporizes Rock");
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

        public void CompareSelections()
        {
            //readinput?

            bool strongerGesture = false;
            while (!strongerGesture)
            {
                string gesture = Console.ReadLine();

                switch (gesture)
                {
                    case "0":
                        Console.WriteLine();
                        break;
                    case "1":
                        Console.WriteLine();
                        break;
                    case "2":
                        Console.WriteLine();
                        break;
                    case "3":
                        Console.WriteLine();
                        break;
                    case "4":
                        Console.WriteLine();
                        break;
                }
            

            }

            //bool strongerGesture = false;
            //while (!strongerGesture)

            //int gestures[0] = strong;
            //bool weakerGesture[2] = true;
            //bool weakerGesture[3] = true;

            //int gestures = 1;
            //bool weakerGesture[0] = true;
            //bool weakerGesture[4] = true;

            //int gestures = 2;
            //bool weakerGesture[1] = true;
            //bool weakerGesture[3] = true;

            //int gestures = 3;
            //bool weakerGesture[4] = true;
            //bool weakerGesture[1] = true;

            //int gestures = 4;
            //bool weakerGesture[2] = true;
            //bool weakerGesture[0] = true;



            //{

            //}
        }

        public void RunGame()
        {
            DisplayPlayerRules();
            GameMode();
            playerUno.Gesture();
            playerDos.Gesture();
            CompareSelections();

            
            //Figure out how this is going to work!
            //playerUno.WhatGesture();
            //playerDos.WhatGesture();
        }

        
    }
}
