using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS_Project
{
    class AIPlayer : Player
    {
        public AIPlayer()
        {
            
        }

        public override void Gesture()
        {
            Random random = new Random();
            int aIGesture = random.Next(gestures.Count);
            bool aIChoice = false;
            while (!aIChoice)
            {
                if(aIGesture == 0)
                {
                    gestChoice = "Rock";
                    Console.WriteLine("A.I. chose Rock");
                    aIChoice = true;
                }
                else if (aIGesture == 1)
                {
                    gestChoice = "Paper";
                    Console.WriteLine("A.I. chose Paper");
                    aIChoice = true;
                }
                else if (aIGesture == 2)
                {
                    gestChoice = "Scissors";
                    Console.WriteLine("A.I. chose Scissors");
                    aIChoice = true;
                }
                else if (aIGesture == 3)
                {
                    gestChoice = "Lizard";
                    Console.WriteLine("A.I. chose Lizard");
                    aIChoice = true;
                }
                else if (aIGesture == 4)
                {
                    gestChoice = "Spock";
                    Console.WriteLine("A.I. chose Spock");
                    aIChoice = true;
                }
            }
            
        }
        public override void GestureOptions()
        {
            
        }
    }
}