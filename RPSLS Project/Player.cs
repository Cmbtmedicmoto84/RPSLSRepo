using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS_Project
{
    public abstract class Player
    {
        public string name;
        public string moves;
        public Player()
        {
            
        }

        public Player(string moves)
        {
            this.moves = moves;
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