using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS_Project
{
    public class Player
    {
        public int score;
        public string gestureLists;

        Human human = new Human();

        private AIPlayer player1;
        private AIPlayer player2;
        public List<AIPlayer> identifynames;

        public Player()
        {
            player1 = new AIPlayer("Samantha");
            player2 = new AIPlayer("Tony");
            identifynames = new List<AIPlayer>();
            identifynames.Add(player1);
            identifynames.Add(player2);
        }


        public abstract void GestureList();

    }
}
