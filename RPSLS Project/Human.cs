using System;

namespace RPSLS_Project
{
    class Human : Player
    {

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
                        Console.WriteLine("Rock");
                        gestureChoice = true;
                        break;
                    case "1":
                        Console.WriteLine("Paper");
                        gestureChoice = true;
                        break;
                    case "2":
                        Console.WriteLine("Scissors");
                        gestureChoice = true;
                        break;
                    case "3":
                        Console.WriteLine("Lizard");
                        gestureChoice = true;
                        break;
                    case "4":
                        Console.WriteLine("Spock");
                        gestureChoice = true;
                        break;
                    default:
                        Console.WriteLine("Invalid selection");
                        break;
                }
            }
        }
        public override void GestureOptions()
        {
            
        }
    }
}
