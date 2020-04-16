using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS_Project
{
    abstract class Player
    {
        public int playerScore;
        public string gestures;
        public List<string> gesture;


        public Player()
        {
            gesture = new List<string>();
            gesture.Add("Rock");
            gesture.Add("Paper");
            gesture.Add("Scissors");
            gesture.Add("Lizard");
            gesture.Add("Spock");
            playerScore = 0;

        }
        public abstract void Gesture();
    }


}
