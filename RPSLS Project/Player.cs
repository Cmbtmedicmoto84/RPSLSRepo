using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS_Project
{
    public class Player
    {
        public string moves;
        public string moves1;
        public string moves2;
        public string moves3;
        public string moves4;
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

        public Player(string gestureLists)
        {  //                                                  0       1          2          3        4
            List<string> gestureList = new List<string>() { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
            //gestureList.Add("Rock");
            //gestureList.Add("Paper");
            //gestureList.Add("Scissors");
            //gestureList.Add("Lizard");
            //gestureList.Add("Spock");
        }
    }
}
// "Rock crushes Scissors"
// "Scissors cuts Paper"
// "Paper covers Rock"
// "Rock crushes Lizard"
// "Lizard poisons Spock"
// "Spock smashes Scissors"
// "Scissors decapitates Lizard"
// "Lizard eats Paper"
// "Papers disproves Spock"
// "Spock vaporizes Rock"