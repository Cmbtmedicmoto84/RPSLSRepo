using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS_Project
{
    class Game
    {
        
        AIPlayer aIPlayer;
        Human human;
        public Game()
        {
            aIPlayer = new AIPlayer();
            human = new Human();
        }

    }
}
