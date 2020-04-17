using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS_Project
{
    abstract class Player
    {
        public int playerUnoScore;
        public int playerDosScore;
        public List<string> gestures;
        public string gestChoice;
        public string playerUno; 
        public string playerDos;

        public Player()
        {
            gestures = new List<string>() { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
        }
        public Player(string playerUno, string playerDos)
        {
            playerUno = "Player One";
            playerDos = "Player Two";
        }
        public Player(int playerUnoScore, int playerDosScore)
        {
            playerUnoScore = 0;
            playerDosScore = 0;
        }
        public abstract void Gesture();
        public abstract void GestureOptions();
    }


}
