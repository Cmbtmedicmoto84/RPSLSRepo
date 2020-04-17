using System;

namespace RPSLS_Project
{
    class Game
    {
        public Player playerUno;
        public Player playerDos;
        public int playerUnoScore;
        public int playerDosScore;

        public Game()
        {
            playerUno = new Human();
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
        }

        public void CompareSelections(Player playerUno, Player playerDos)
        {
            bool gestCompare = true;
            while (gestCompare)
            {
                if(playerUno.gestChoice == "Rock" && (playerDos.gestChoice == "Scissors" || playerDos.gestChoice == "Lizard"))
                {
                    Console.WriteLine("Rock Wins!");
                    playerUnoScore++;
                    gestCompare = true;
                }
                else if (playerUno.gestChoice == "Paper" && (playerDos.gestChoice == "Rock" || playerDos.gestChoice == "Spock"))
                {
                    Console.WriteLine("Paper Wins!");
                    playerUnoScore++;
                    gestCompare = true;
                }
                else if (playerUno.gestChoice == "Scissors" && (playerDos.gestChoice == "Paper" || playerDos.gestChoice == "Lizard"))
                {
                    Console.WriteLine("Scissors Wins!");
                    playerUnoScore++;
                    gestCompare = true;
                }
                else if (playerUno.gestChoice == "Lizard" && (playerDos.gestChoice == "Spock" || playerDos.gestChoice == "Paper"))
                {
                    Console.WriteLine("Lizard Wins!");
                    playerUnoScore++;
                    gestCompare = true;
                }
                else if (playerUno.gestChoice == "Spock" && (playerDos.gestChoice == "Scissors" || playerDos.gestChoice == "Rock"))
                {
                    Console.WriteLine("Spock Wins!");
                    playerUnoScore++;
                    gestCompare = true;
                }
                else if (playerDos.gestChoice == "Rock" && (playerUno.gestChoice == "Scissors" || playerUno.gestChoice == "Lizard"))
                {
                    Console.WriteLine("Rock Wins!");
                    playerDosScore++;
                    gestCompare = true;
                }
                else if (playerDos.gestChoice == "Paper" && (playerUno.gestChoice == "Rock" || playerUno.gestChoice == "Spock"))
                {
                    Console.WriteLine("Paper Wins!");
                    playerDosScore++;
                    gestCompare = true;
                }
                else if (playerDos.gestChoice == "Scissors" && (playerUno.gestChoice == "Lizard" || playerUno.gestChoice == "Paper"))
                {
                    Console.WriteLine("Scissors Wins!");
                    playerDosScore++;
                    gestCompare = true;
                }
                else if (playerDos.gestChoice == "Lizard" && (playerUno.gestChoice == "Paper" || playerUno.gestChoice == "Spock"))
                {
                    Console.WriteLine("Lizard Wins!");
                    playerDosScore++;
                    gestCompare = true;
                }
                else if (playerDos.gestChoice == "Spock" && (playerUno.gestChoice == "Rock" || playerUno.gestChoice == "Scissors"))
                {
                    Console.WriteLine("Spock Wins!");
                    playerDosScore++;
                    gestCompare = true;
                }
            }
        }
        public void AnnounceWinner(int playerUnoScore, int playerDosScore)
        {
            if (playerUnoScore == 3 && playerDosScore < 3)
            {
                Console.WriteLine("Player One Wins!");
            }
            else if (playerDosScore == 3 && playerUnoScore < 3)
            {
                Console.WriteLine("Player Two Wins!");
            }
        }

        public void RunGame()
        {
            DisplayPlayerRules();
            GameMode();
            
            while(playerUnoScore < 3 && playerDosScore < 3)
            {   
                playerUno.Gesture();
                playerDos.Gesture();
            }
            CompareSelections(playerUno, playerDos);
            AnnounceWinner(playerUnoScore, playerDosScore);
            {
                Console.ReadLine();
            }
        }

        
    }
}
