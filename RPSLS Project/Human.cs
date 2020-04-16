using System;

namespace RPSLS_Project
{
    class Human : Player
    {
        int playerScore;
        string gesture;

        public Human()
        {
           
        }

        public override void Gesture()
        {
            Console.WriteLine("Please choose from the list of moves");
            Console.WriteLine("Type the corresponding number for the selected move: 0 - Rock, 1 - Paper, 2 - Scissors, 3 - Lizard, 4 - Spock \n");

            bool gestureChoice = false;
            while (!gestureChoice)
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
        }
    }
}
