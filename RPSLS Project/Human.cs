using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS_Project
{
    class Human : Player
    {
        public Human(string name, string moves)
        {
            this.name = name;
            this.moves = moves;
        }
    }
}
