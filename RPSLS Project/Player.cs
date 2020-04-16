using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS_Project
{
    abstract class Player
    {
        public int playerScore;
        public string gesture;
        public List<string> gestures;


        public Player()
        {
            gestures = new List<string>();
            gestures.Add("Rock");
            gestures.Add("Paper");
            gestures.Add("Scissors");
            gestures.Add("Lizard");
            gestures.Add("Spock");
            playerScore = 0;

        }
        public abstract void Gesture();
    }
}
