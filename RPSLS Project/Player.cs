using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS_Project
{
    public abstract class Player
    {
        public string name;
        public string moves;
        public string moves1;
        public string moves2;
        public string moves3;
        public string moves4;
        public string gestureLists;
        Human human = new Human();
        AIPlayer aiplayer = new AIPlayer();



        public Player()
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